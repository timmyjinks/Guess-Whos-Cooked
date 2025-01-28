using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{
  void onClick() {
    SceneManager.LoadScene("SampleScene");
  }
}
