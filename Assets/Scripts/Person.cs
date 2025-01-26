using System.Collections.Generic;
using System;
using UnityEngine;

[System.Serializable]
public class Person
{
  public GameObject person;
  public string name;
  public Trait hairColor;
  public Trait hairLength;
  public Trait facialHair;
  // public EyeColor eyeColor;
  public Trait gender;
  public Trait glasses;
  public Trait shirtColor;
  // public ShirtType shirtType;
  public Trait skinColor;

  public Person(GameObject person, 
      string name, 
      Trait hairColor,
      Trait hairLength,
      Trait facialHair,
      Trait gender, 
      Trait glasses,
      Trait shirtColor,
      Trait skinColor,
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

  public bool checkTraits(Trait question) {
    return question == hairColor || 
      question == hairLength ||
      question == facialHair ||
      question == gender ||
      question == glasses ||
      question == shirtColor ||
      question == skinColor;
  }

}
