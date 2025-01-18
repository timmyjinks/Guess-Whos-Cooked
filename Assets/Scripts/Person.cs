using System.Collections.Generic;
using System;
using UnityEngine;

[System.Serializable]
public class Person
{
  public GameObject person;
  public string hair;
  public string eyes;
  public string image;

  public Person(GameObject person) {
    this.person = person;
    this.hair = "dark hair";
    this.eyes = "blue";
    this.image = "goodtogo";
  }

  public bool checkTraits(string question) {
    return question == hair || question == eyes;
  }

}
