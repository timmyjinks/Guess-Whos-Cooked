using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject personPrefab;
    public GameObject cookedPrefab;
    public Camera MainCamera;
    public UI ui;
    public Transform board1Transform;
    public Transform board2Transform;

    public int playerTurn;

    public Player player1 = new Player();
    public Player player2 = new Player();

    public List<Person> board1 = new List<Person>();
    public List<Person> board2 = new List<Person>();

    void Start()
    {
      if (board1.Count > 1 || board2.Count > 1) {
        for (int i = 0; i < 24; i++) {
          Destroy(board1[i].person);
          Destroy(board2[i].person);
        }
        board1 = new List<Person>();
        board2 = new List<Person>();
      }

      MainCamera = Camera.main;
      MainCamera.enabled = true;

      populateBoard(board1, board1Transform, 100, 15);
      populateBoard(board2, board2Transform, -100, 15);

      Person secret1 = board1[Random.Range(0,23)];
      Person secret2 = board2[Random.Range(0,23)];

      GameObject player1Prefab = Instantiate(secret1.person);
      GameObject player2Prefab = Instantiate(secret2.person);
      player1Prefab.transform.SetParent(board1Transform);
      player2Prefab.transform.SetParent(board2Transform);

      player1.secret = new Person(player1Prefab, 
          secret1.name, 
          secret1.hairColor, 
          secret1.hairLength,
          secret1.facialHair,
          secret1.gender,
          secret1.glasses,
          secret1.shirtColor,
          secret1.skinColor,
          new Vector3(126.9F, 16.4F, 10)
      );
      player2.secret = new Person(player2Prefab, 
          secret2.name, 
          secret2.hairColor, 
          secret2.hairLength,
          secret2.facialHair,
          secret2.gender,
          secret2.glasses,
          secret2.shirtColor,
          secret2.skinColor,
          new Vector3(-106.9F, 16.4F, 10)
      );


      player1.name = "Player 1";
      player2.name = "Player 2";

      playerTurn = Random.Range(1,2);

      StartCoroutine(StartGame());
    }

    IEnumerator StartGame() {
      while (true) {
        if (playerTurn == 1) {
          yield return playTurn(board1, board1Transform, player2);
          playerTurn = 2;
        } else if (playerTurn == 2) {
          yield return playTurn(board2, board2Transform, player1);
          playerTurn = 1;
        }
        ui.isGuessClicked = false;
        ui.isEndTurnClicked = false;
      }
    }

    IEnumerator playTurn(List<Person> board, Transform boardTransform, Player opponent) {
        MainCamera.transform.position = new Vector3(boardTransform.transform.position.x, 0, -10);
        yield return new WaitUntil(() => ui.isGuessClicked);
        bool response = opponent.validate(ui.questionValue);
        hidePeople(ui.questionValue, board, response);
        yield return new WaitUntil(() => ui.isEndTurnClicked);
        if (ui.answerValue != "" && opponent.secret.name == ui.answerValue) {
          Debug.Log(opponent.name + "Wins");
          // Go to start screen
        } else if (ui.answerValue != "" && opponent.secret.name != ui.answerValue) {
          Debug.Log(opponent.name + " Loses");
          // Go to start screen
        }
    }

    public void hidePeople(string question, List<Person> board, bool response) {
      for(int i = 0; i < 24; i++) {
        if (response) {
          if (!board[i].checkTraits(question)) {
            changeSprite(board[i].person);
          }
        } else if (board[i].checkTraits(question)) {
          changeSprite(board[i].person);
        }
      }
    }

    void changeSprite(GameObject person) {
        person.GetComponent<SpriteRenderer>().sprite = cookedPrefab.GetComponent<SpriteRenderer>().sprite;
    }

    void populateBoard(List<Person> board, Transform boardParent, float x, float y) {
      float begin = x - 28.33F;
      for(int i = 0; i < 24; i++) {
        if (i % 6 == 0) {
          y -= 6;
          x = begin; 
        }
        GameObject person = Instantiate(PersonData.personObjects[i]);
        person.transform.SetParent(boardParent);
        board.Add(new Person(
              person,
              PersonData.personNames[i],
              PersonData.personHairColor[i],
              PersonData.personHairLength[i],
              PersonData.personFacialHair[i],
              PersonData.personGender[i],
              PersonData.personGlasses[i],
              PersonData.personShirtColor[i],
              PersonData.personSkinColor[i],
              new Vector3(x, y, 10)));
        x += 11;
      }
    }
}

public class Player {
  public Person secret;
  public string name;
  public bool validate(Trait question) {
    return secret.checkTraits(question);
  }
}
