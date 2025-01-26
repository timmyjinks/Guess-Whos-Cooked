using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
  public bool isGuessClicked;
  public bool isEndTurnClicked;
  public Trait questionValue;
  public string answerValue;

  void Start() {
    isGuessClicked = false;
    isEndTurnClicked = false;
  }

  public void guessButton() {
    isGuessClicked = true;
  }

  public void endTurnButton() {
    isEndTurnClicked = true;
  }

  public void onChangeQuestion(int index) {
    switch (index) { 
      case 0: questionValue = Trait.BlackHair; break;
      case 1: questionValue = Trait.BrownHair; break;
      case 2: questionValue = Trait.BlondeHair; break;
      case 3: questionValue = Trait.Long; break;
      case 4: questionValue = Trait.Short; break;
      case 5: questionValue = Trait.Bald; break;
      case 6: questionValue = Trait.Male; break;
      case 7: questionValue = Trait.Female; break;
      case 8: questionValue = Trait.Glasses; break;
      case 9: questionValue = Trait.Beard; break;
      case 10: questionValue = Trait.NoFacialHair; break;
      case 11: questionValue = Trait.Goatee; break;
    }
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
      case 12: answerValue = "Josh Krebs"; break;
      case 13: answerValue = "Kasie Hadley"; break;
      case 14: answerValue = "Kirk Marshall"; break;
      case 15: answerValue = "Matt Brown"; break;
      case 16: answerValue = "Melissa Nelson"; break;
      case 17: answerValue = "Mercedes Wiles"; break;
      case 18: answerValue = "Michael Pritchard"; break;
      case 19: answerValue = "Omkar Terse"; break;
      case 20: answerValue = "Paul Fox"; break;
      case 21: answerValue = "Raymond Maple"; break;
      case 22: answerValue = "Rene Guzman"; break;
      case 23: answerValue = "Ryan Cox"; break;
      case 24: answerValue = "Sarah Carter"; break;
      case 25: answerValue = "Tiffany Hippie"; break;
    }
  }
}
