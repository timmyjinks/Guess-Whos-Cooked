using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.UI;

public class DropdownTests
{
    private Dropdown dropdown;

    [UnitySetUp]
    public IEnumerator SetUp()
    {
        var dropdownGameObject = new GameObject("Dropdown");
        dropdown = dropdownGameObject.AddComponent<Dropdown>();

        dropdown.options.Add(new Dropdown.OptionData("Option 1"));
        dropdown.options.Add(new Dropdown.OptionData("Option 2"));
        dropdown.options.Add(new Dropdown.OptionData("Option 3"));

        yield return null;
    }

    [UnityTest]
    public IEnumerator DropdownSelection_ChangesValueCorrectly()
    {
        dropdown.value = 1;
        yield return null;

        Assert.AreEqual(1, dropdown.value);
        Assert.AreEqual("Option 2", dropdown.options[dropdown.value].text);
    }

    [UnityTearDown]
    public IEnumerator TearDown()
    {
        Object.Destroy(dropdown.gameObject);
        yield return null;
    }
}
