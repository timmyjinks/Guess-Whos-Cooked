using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
  Button guess;
  Button endTurn;
  Dropdown question;

  void Start() {
    Button button = Instantiate(guess);
    button.transform.SetParent(transform);

    button = Instantiate(endTurn);
    button.transform.SetParent(transform);
  }
}
