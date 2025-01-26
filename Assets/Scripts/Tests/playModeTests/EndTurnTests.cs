using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.TestTools;
using UnityEngine.SceneManagement;

public class EndTurnTests
{

    [UnitySetUp]
    public IEnumerator LoadScene()
    {
        SceneManager.LoadScene("SampleScene");
        yield return null;
    }

    [UnityTest]
    public IEnumerator TestEndTurnButton()
    {
        GameObject buttonObject = GameObject.Find("EndTurn");
        Assert.IsNotNull(buttonObject, "The EndTurn button was not found in the scene.");

        Button endTurnButton = buttonObject.GetComponent<Button>();
        Assert.IsNotNull(endTurnButton, "The EndTurn GameObject does not have a Button component attached.");

        bool turnEnded = false;
        endTurnButton.onClick.AddListener(() => turnEnded = true);

        endTurnButton.onClick.Invoke();
        yield return null;

        Assert.IsTrue(turnEnded, "End turn logic was not triggered.");
    }
}
