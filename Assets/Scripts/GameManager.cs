using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject personPrefab;
    public UI ui;
    public Transform Board1;
    public Transform Board2;

    public int playerTurn;

    public Player player1 = new Player();
    public Player player2 = new Player();

    [SerializeField]
    List<Person> board1 = new List<Person>();
    [SerializeField]
    List<Person> board2 = new List<Person>();

    void Start()
    {
      populateBoard(board1, Board1);
      populateBoard(board2, Board2);

      player1.secret = board1[Random.Range(0,26)];
      player2.secret = board1[Random.Range(0,26)];

      playerTurn = Random.Range(1,2);

      Debug.Log("Assets Loaded");
      Debug.Log("");

      StartCoroutine(StartGame());
    }

    IEnumerator StartGame() {
      Debug.Log("Started Game");
      // Take camera to player coords
      bool isValid = false;
      while (true) {
        if (playerTurn == 1) {
          Debug.Log("Player 1 Turn");
          yield return new WaitUntil(() => ui.isGuessClicked);
          Debug.Log("Got input for Player 1 " + ui.questionValue);
          isValid = player2.validate(ui.questionValue);

          if (isValid) {
            // display yes
            Debug.Log("Match");
            hidePeople(ui.questionValue, board1, isValid);
          } else {
            // display no
            Debug.Log("No Match");
            hidePeople(ui.questionValue, board1, isValid);
          }

          Debug.Log("End Turn");
          yield return new WaitUntil(() => ui.isEndTurnClicked);
          playerTurn = 2;
          Debug.Log("Player 1 Turn Ends");
        } else {
          Debug.Log("Player 2 Turn");
          yield return new WaitUntil(() => ui.isGuessClicked);
          Debug.Log("Got input for Player 2 " + ui.questionValue);
          isValid = player1.validate(ui.questionValue);

          if (isValid) {
            // display yes
            Debug.Log("Match");
            hidePeople(ui.questionValue, board2, isValid);
          } else {
            // display no
            Debug.Log("No Match");
            hidePeople(ui.questionValue, board2, isValid);
          }

          playerTurn = 1;
          yield return new WaitUntil(() => ui.isEndTurnClicked);
          Debug.Log("Player 2 Turn Ends");
        }
        ui.isGuessClicked = false;
        ui.isEndTurnClicked = false;

        for(int i = 0; i < 26; i++) {
          Debug.Log(board1[i].image);
        } 

        Debug.Log("");
      }
    }

    void hidePeople(string question, List<Person> board, bool response) {
      for(int i = 0; i < 26; i++) {
        if (response) {
          if(!board[i].checkTraits(question)) {
            board[i].image = "blank";
          }
        } else {
          if(board[i].checkTraits(question)) {
            board[i].image = "blank";
          }
        } 
      }
    }

    void populateBoard(List<Person> board, Transform boardParent) {
      for(int i = 0; i < 25; i++) {
        GameObject person = Instantiate(personPrefab);
        person.transform.SetParent(boardParent);
        person.transform.position = boardParent.transform.position;
        board.Add(new Person(person));
      }
      GameObject perso = Instantiate(personPrefab);
      perso.transform.SetParent(boardParent);
      perso.transform.position = boardParent.transform.position;
      Person test = new Person(perso);
      test.hair = "blue hair";
      board.Add(test);
    }
}

public class Player {
  public Person secret;
  public bool validate(string question) {
    return secret.checkTraits(question);
  }
}
