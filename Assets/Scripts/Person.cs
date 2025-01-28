using System.Collections.Generic;
using System;
using UnityEngine;

[System.Serializable]
public class Person
{
  public GameObject person;
  public string name;
  public string hairColor;
  public string hairLength;
  public string facialHair;
  public string gender;
  public string glasses;
  public string shirtColor;
  public string skinColor;

  public Person(GameObject person, 
      string name, 
      string hairColor,
      string hairLength,
      string facialHair,
      string gender, 
      string glasses,
      string shirtColor,
      string skinColor,
      Vector3 position) {
    this.person = person;
    this.name = name;
    this.hairColor = hairColor;
    this. hairLength = hairLength;
    this.facialHair = facialHair;
    this.gender = gender;
    this.glasses = glasses;
    this.shirtColor = shirtColor;
    this.skinColor = skinColor;
    this.person.transform.position = position;
  }

  public bool checkTraits(string question) {
    return question == hairColor || 
      question == hairLength ||
      question == facialHair ||
      question == gender ||
      question == glasses ||
      question == shirtColor ||
      question == skinColor;
  }

}
