using System.Collections.Generic;
using UnityEngine;

public class Person
{
  public GameObject person;
  string hair;
  string eyes;

  public Person(GameObject person) {
    this.person = person;
  }

  public bool checkTraits(string question) {
    if (question == hair || question == eyes) {
      return true;
    } else {
      return false;
    }
  }

}
