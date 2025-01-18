using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject personPrefab;
    public UI ui;
    public Transform Board1;
    public Transform Board2;

    int playerTurn;

    Player player1 = new Player();
    Player player2 = new Player();

    List<Person> board1 = new List<Person>();
    List<Person> board2 = new List<Person>();

    // vec3 coords board1
    // vec3 coords board2

    void Start()
    {
      populateBoard(board1, Board1);
      populateBoard(board2, Board2);

      player1.secret = board1[Random.Range(0,26)];
      player2.secret = board1[Random.Range(0,26)];
      
      playerTurn = Random.Range(1,2);
      BeginGame();
    }

    void BeginGame() {
      // Take camera to player coords
      // Check for input
      if (playerTurn == 1) {


      } else {

      }
    }

    void hidePeople(string question, List<Person> board) {
      for(int i = 0; i < 26; i++) {
        if(board[i].checkTraits(question)) {
          // change picture
        }
      } 
    }

    void populateBoard(List<Person> board, Transform boardParent) {
      for(int i = 0; i < 26; i++) {
        GameObject person = Instantiate(personPrefab);
        person.transform.SetParent(boardParent);
        board.Add(new Person(person));
      }
    }
}

public class Player {
  public Person secret;
  bool validate(string question) {
    if (secret.checkTraits(question)) {
      return true;
    } else {
      return false;
    }
  }
}
