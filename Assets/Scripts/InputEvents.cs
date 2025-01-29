using UnityEngine;
using UnityEngine.SceneManagement;

public class InputEvents : MonoBehaviour
{
  public void onPlayButtonClick() {
    SceneManager.LoadScene("SampleScene");
  }
  public void onRulesClick() {
    SceneManager.LoadScene("Rules");
  }
  public void onBackClick() {
    SceneManager.LoadScene("MainMenu");
  }
  public void onQuitClick() {
    Application.Quit();
  }
}
