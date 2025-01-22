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

    List<Person> board1 = new List<Person>();
    List<Person> board2 = new List<Person>();

    void Start()
    {
      MainCamera = Camera.main;
      MainCamera.enabled = true;

      populateBoard(board1, board1Transform, 100, 10);
      populateBoard(board2, board2Transform, -100, 10);

      player1.secret = board1[Random.Range(0,23)];
      player2.secret = board2[Random.Range(0,23)];

      playerTurn = Random.Range(1,2);

      StartCoroutine(StartGame());
    }

    IEnumerator StartGame() {
      while (true) {
        if (playerTurn == 1) {
          yield return playTurn(board1, board1Transform, player1);
          playerTurn = 2;
        } else if (playerTurn == 2) {
          yield return playTurn(board2, board2Transform, player2);
          playerTurn = 1;
        }
        ui.isGuessClicked = false;
        ui.isEndTurnClicked = false;
      }
    }

    IEnumerator playTurn(List<Person> board, Transform boardTransform, Player player) {
        MainCamera.transform.position = new Vector3(boardTransform.transform.position.x, 0, -10);
        yield return new WaitUntil(() => ui.isGuessClicked);
        Debug.Log(ui.questionValue);
        bool response = player.validate(ui.questionValue);
        Debug.Log(player.secret.hair);
        Debug.Log(response);
        hidePeople(ui.questionValue, board, response);
        yield return new WaitUntil(() => ui.isEndTurnClicked);
    }

    void hidePeople(string question, List<Person> board, bool response) {
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
      float begin = x - 18.33F;
      for(int i = 0; i < 24; i++) {
        if (i % 6 == 0) {
          y -= 3.5F;
          x = begin; 
        }
        GameObject person = Instantiate(personPrefab);
        person.transform.SetParent(boardParent);
        board.Add(new Person(person, "black hair", "green eyes", new Vector3(x, y, 10)));
        x += 7.34F;
      }
    }
}

public class Player {
  public Person secret;
  public bool validate(string question) {
    return secret.checkTraits(question);
  }
}
