using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
  public bool isGuessClicked;
  public bool isEndTurnClicked;
  public string questionValue;
  public string answerValue;

  void Start() {
    isGuessClicked = false;
    isEndTurnClicked = false;
    questionValue = "brown hair";
  }

  public void guessButton() {
    isGuessClicked = true;
  }

  public void endTurnButton() {
    isEndTurnClicked = true;
  }

  public void onChangeQuestion(int index) {
    switch (index) { 
      case 0: questionValue = "black hair"; break;
      case 1: questionValue = "brown hair"; break;
      case 2: questionValue = "blonde hair"; break;
      case 3: questionValue = "long hair"; break;
      case 4: questionValue = "short hair"; break;
      case 5: questionValue = "bald"; break;
      case 6: questionValue = "male"; break;
      case 7: questionValue = "female"; break;
      case 8: questionValue = "glasses"; break;
      case 9: questionValue = "beard"; break;
      case 10: questionValue = "no facial hair"; break;
      case 11: questionValue = "goatee"; break;
      case 12: questionValue = "black shirt"; break;
      case 13: questionValue = "white shirt"; break;
      case 14: questionValue = "green shirt"; break;
      case 15: questionValue = "pink shirt"; break;
      case 16: questionValue = "blue shirt"; break;
      case 17: questionValue = "red shirt"; break;
      case 18: questionValue = "grey shirt"; break;
    }
    Debug.Log(questionValue);
  }
  public void onChangeAnswer(int index) {
    switch (index) { 
      case 0: answerValue = ""; break;
      case 1: answerValue = "Aaron Reed"; break;
      case 2: answerValue = "Bj Voorhees"; break;
      case 3: answerValue = "Brett Beardall"; break;
      case 4: answerValue = "Cam Peterson"; break;
      case 5: answerValue = "Chris Cantera"; break;
      case 6: answerValue = "Christian Nickerson"; break;
      case 7: answerValue = "Corey Burk"; break;
      case 8: answerValue = "Eric Kholer"; break;
      case 9: answerValue = "Janet Head Parish"; break;
      case 10: answerValue = "Joe Shull"; break;
      case 11: answerValue = "Josh Krebs"; break;
      case 12: answerValue = "Kirk Marshall"; break;
      case 13: answerValue = "Kasie Hadley"; break;
      case 14: answerValue = "Matt Brown"; break;
      case 15: answerValue = "Melissa Nelson"; break;
      case 16: answerValue = "Mercedes Wiles"; break;
      case 17: answerValue = "Michael Pritchard"; break;
      case 18: answerValue = "Omkar Terse"; break;
      case 19: answerValue = "Paul Fox"; break;
      case 20: answerValue = "Raymond Maple"; break;
      case 21: answerValue = "Rene Guzman"; break;
      case 22: answerValue = "Ryan Cox"; break;
      case 23: answerValue = "Sarah Carter"; break;
      case 24: answerValue = "Tiffany Hippie"; break;
    }
  }
}
