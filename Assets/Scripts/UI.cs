using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
  public bool isGuessClicked;
  public bool isEndTurnClicked;
  public string questionValue;

  void Start() {
    isGuessClicked = false;
    isEndTurnClicked = false;
    questionValue = "dark hair";
  }

  public void guessButton() {
    isGuessClicked = true;
  }

  public void endTurnButton() {
    isEndTurnClicked = true;
  }

  public void onChange(int index) {
    switch (index) { 
      case 0: questionValue = "dark hair"; break;
      case 1: questionValue = "green eyes"; break;
    }
    Debug.Log(index);
    Debug.Log(questionValue);
  }
}
