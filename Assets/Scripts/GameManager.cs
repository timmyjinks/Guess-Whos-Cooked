using System.Collections;
using TMPro;
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
    public TMP_Text objectName;

    public int playerTurn;

    public List<Person> board1 = new List<Person>();
    public List<Person> board2 = new List<Person>();

    void Start()
    {
        string[] personNames = {
          "Aaron Reed",
          "Bj Voorhees",
          "Brett Beardall",
          "Cam Peterson",
          "Chris Cantera",
          "Christian Nickerson",
          "Corey Burk",
          "Eric Kholer",
          "Janet Head Parish",
          "Joe Shull",
          "Josh Krebs",
          "Kasie Hadley",
          "Kirk Marshall",
          "Matt Brown",
          "Melissa Nelson",
          "Mercedes Wiles",
          "Michael Pritchard",
          "Omkar Terse",
          "Paul Fox",
          "Raymond Maple",
          "Rene Guzman",
          "Ryan Cox",
          "Sarah Carter",
          "Tiffany Hippie"
      };
      string[] personHairColor = {
        "brown hair",
        "brown hair",
        "brown hair",
        "brown hair",
        "brown hair",
        "brown hair",
        "brown hair",
        "brown hair",
        "brown hair",
        "brown hair",
        "brown hair",
        "brown hair",
        "brown hair",
        "white hair",
        "brown hair",
        "blonde hair",
        "brown hair",
        "white hair",
        "brown hair",
        "black hair",
        "black hair",
        "brown hair",
        "brown hair",
        "brown hair",
      };


    string[] personHairLength = {
      "short hair",
      "short hair",
      "bald",
      "short hair",
      "short hair",
      "short hair",
      "short hair",
      "short hair",
      "long hair",
      "long hair",
      "short hair",
      "long hair",
      "bald",
      "short hair",
      "short hair",
      "long hair",
      "short hair",
      "short hair",
      "short hair",
      "short hair",
      "long hair",
      "short hair",
      "long hair",
      "long hair",
    };

    string[] personFacialHair = {
      "beard",
      "no facial hair",
      "goatee",
      "goatee",
      "no facial hair",
      "goatee",
      "beard",
      "beard",
      "no facial hair",
      "beard",
      "beard",
      "no facial hair",
      "goatee",
      "no facial hair",
      "no facial hair",
      "no facial hair",
      "no facial hair",
      "beard",
      "beard",
      "no facial hair",
      "beard",
      "beard",
      "no facial hair",
      "no facial hair",
    };
  
    string[] personGender = {
      "male",
      "male",
      "male",
      "male",
      "male",
      "male",
      "male",
      "female",
      "male",
      "male",
      "female",
      "male",
      "male",
      "female",
      "female",
      "male",
      "male",
      "male",
      "male",
      "male",
      "male",
      "male",
      "female",
      "female",
  };

  string[] personGlasses = {
    "no glasses",
    "no glasses",
    "no glasses",
    "no glasses",
    "glasses",
    "glasses",
    "glasses",
    "no glasses",
    "no glasses",
    "no glasses",
    "no glasses",
    "no glasses",
    "glasses",
    "no glasses",
    "no glasses",
    "no glasses",
    "no glasses",
    "no glasses",
    "no glasses",
    "no glasses",
    "no glasses",
    "no glasses",
    "no glasses",
    "no glasses",
  };

  string[] personShirtColor = {
    "blue shirt",
    "blue shirt",
    "blue shirt",
    "red shirt",
    "grey shirt",
    "black shirt",
    "white shirt",
    "green shirt",
    "white shirt",
    "blue shirt",
    "blue shirt",
    "green shirt",
    "blue shirt",
    "white shirt",
    "black shirt",
    "green shirt",
    "red shirt",
    "pink shirt",
    "grey shirt",
    "blue shirt",
    "white shirt",
    "white shirt",
    "brown shirt",
    "black shirt",
  };
  

  string[] personSkinColor = {
    "white",
    "white",
    "white",
    "white",
    "white",
    "white",
    "white",
    "white",
    "white",
    "white",
    "white",
    "white",
    "white",
    "white",
    "white",
    "white",
    "white",
    "not white",
    "white",
    "white",
    "not white",
    "white",
    "white",
    "white",
  };
      Person player1secret;
      Person player2secret;
      string player1name = "Player 1";
      string player2name = "Player 2";


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

      player1secret = new Person(player1Prefab, 
          secret1.name, 
          secret1.hairColor, 
          secret1.hairLength,
          secret1.facialHair,
          secret1.gender,
          secret1.glasses,
          secret1.shirtColor,
          secret1.skinColor,
          new Vector3(125, 14, 10)
      );
      player2secret = new Person(player2Prefab, 
          secret2.name, 
          secret2.hairColor, 
          secret2.hairLength,
          secret2.facialHair,
          secret2.gender,
          secret2.glasses,
          secret2.shirtColor,
          secret2.skinColor,
          new Vector3(-75, 14, 10)
      );

      playerTurn = Random.Range(1,2);

      StartCoroutine(StartGame());
      IEnumerator StartGame() {
        while (true) {
          if (playerTurn == 1) {
            yield return playTurn(board1, board1Transform, player2secret, player1name);
            playerTurn = 2;
          } else if (playerTurn == 2) {
            yield return playTurn(board2, board2Transform, player1secret, player2name);
            playerTurn = 1;
          }
          ui.isGuessClicked = false;
          ui.isEndTurnClicked = false;
        }
      }

      IEnumerator playTurn(List<Person> board, Transform boardTransform, Person opponentSecret, string playerName) {
        MainCamera.transform.position = new Vector3(boardTransform.transform.position.x, 0, -10);
          yield return new WaitUntil(() => ui.isGuessClicked);
          bool response = opponentSecret.checkTraits(ui.questionValue);
          hidePeople(ui.questionValue, board, response);
          yield return new WaitUntil(() => ui.isEndTurnClicked);
          if (ui.answerValue != "" && opponentSecret.name == ui.answerValue) {
            Debug.Log(playerName + "Wins");
          // Go to start screen
          } else if (ui.answerValue != "" && opponentSecret.name != ui.answerValue) {
            Debug.Log(playerName + " Loses");
          // Go to start screen
          }
      }
    }


    public void hidePeople(string question, List<Person> board, bool response) {
      for(int i = 0; i < 24; i++) {
        if (response) {
          if (!board[i].checkTraits(question)) {
            board[i].person.GetComponent<SpriteRenderer>().sprite = cookedPrefab.GetComponent<SpriteRenderer>().sprite;
          }
        } else if (board[i].checkTraits(question)) {
          board[i].person.GetComponent<SpriteRenderer>().sprite = cookedPrefab.GetComponent<SpriteRenderer>().sprite;
        }
      }
    }

    void populateBoard(List<Person> board, Transform boardParent, float x, float y) {
      float begin = x - 30;
      for(int i = 0; i < 24; i++) {
        if (i % 6 == 0) {
          y -= 6;
          x = begin; 
        }
        GameObject person = Instantiate(PersonData.personObjects[i]);
        person.transform.SetParent(boardParent);
        TMP_Text text = Instantiate(objectName);
        text.text = PersonData.personNames[i];
        text.transform.position = new Vector3(x, y-2.5F, 10);
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
