using System.Collections.Generic;
using System;
using UnityEngine;

public class Person
{
  public GameObject person;
  public string name;
  public string hair;
  public string eyes;
  public string image;
    public HairColor hairColor = HairColor.Blonde;

  public Person(GameObject person, string hair, string eyes, Vector3 position) {
    this.person = person;
    this.hair = hair;
    this.eyes = eyes;
    this.person.transform.position = position;
  }

  public bool checkTraits(string question) {
    return question == hair || question == eyes;
  }

}
