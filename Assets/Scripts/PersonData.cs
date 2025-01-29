using System.Collections.Generic;
using UnityEngine;

public class PersonData : MonoBehaviour
{
  public GameObject aaronReed;
  public GameObject bjVoorhees;
  public GameObject brettBeardall;
  public GameObject camPeterson;
  public GameObject chrisCantera;
  public GameObject christianNickerson;
  public GameObject coreyBurk;
  public GameObject ericKohler;
  public GameObject janeHeadParish;
  public GameObject joeShull;
  public GameObject joshKrebs;
  public GameObject kasieHadley;
  public GameObject kirkMarshall;
  public GameObject mattBrown;
  public GameObject melissaNelson;
  public GameObject mercedesWiles;
  public GameObject michealPritchard;
  public GameObject omkarTerse;
  public GameObject paulFox;
  public GameObject raymondMaple;
  public GameObject reneGuzman;
  public GameObject ryanCox;
  public GameObject sarahCarter;
  public GameObject tiffanyHippie;

  public static List<GameObject> personObjects = new List<GameObject>();
  public static string[] personNames = {
      "Aaron Reed",
      "Bj Voorhees",
      "Brett Beardall",
      "Cam Peterson",
      "Chris Cantera",
      "Christian Nickerson",
      "Corey Burk",
      "Eric Kholer",
      "Janet Head Parish",
      "Joe Shull",
      "Josh Krebs",
      "Kasie Hadley",
      "Kirk Marshall",
      "Matt Brown",
      "Melissa Nelson",
      "Mercedes Wiles",
      "Michael Pritchard",
      "Omkar Terse",
      "Paul Fox",
      "Raymond Maple",
      "Rene Guzman",
      "Ryan Cox",
      "Sarah Carter",
      "Tiffany Hippie"
  };

      public static string[] personHairColor = {
        "brown hair",
        "brown hair",
        "brown hair",
        "brown hair",
        "brown hair",
        "brown hair",
        "brown hair",
        "brown hair",
        "brown hair",
        "brown hair",
        "brown hair",
        "brown hair",
        "brown hair",
        "white hair",
        "brown hair",
        "blonde hair",
        "brown hair",
        "white hair",
        "brown hair",
        "black hair",
        "black hair",
        "brown hair",
        "brown hair",
        "brown hair",
      };


    public static string[] personHairLength = {
      "short hair",
      "short hair",
      "bald",
      "short hair",
      "short hair",
      "short hair",
      "short hair",
      "short hair",
      "long hair",
      "long hair",
      "short hair",
      "long hair",
      "bald",
      "short hair",
      "short hair",
      "long hair",
      "short hair",
      "short hair",
      "short hair",
      "short hair",
      "long hair",
      "short hair",
      "long hair",
      "long hair",
    };

    public static string[] personFacialHair = {
      "beard",
      "no facial hair",
      "goatee",
      "goatee",
      "no facial hair",
      "goatee",
      "beard",
      "beard",
      "no facial hair",
      "beard",
      "beard",
      "no facial hair",
      "goatee",
      "no facial hair",
      "no facial hair",
      "no facial hair",
      "no facial hair",
      "beard",
      "beard",
      "no facial hair",
      "beard",
      "beard",
      "no facial hair",
      "no facial hair",
    };
  
    public static string[] personGender = {
      "male",
      "male",
      "male",
      "male",
      "male",
      "male",
      "male",
      "female",
      "male",
      "male",
      "female",
      "male",
      "male",
      "female",
      "female",
      "male",
      "male",
      "male",
      "male",
      "male",
      "male",
      "male",
      "female",
      "female",
  };

  public static string[] personGlasses = {
    "no glasses",
    "no glasses",
    "no glasses",
    "no glasses",
    "glasses",
    "glasses",
    "glasses",
    "no glasses",
    "no glasses",
    "no glasses",
    "no glasses",
    "no glasses",
    "glasses",
    "no glasses",
    "no glasses",
    "no glasses",
    "no glasses",
    "no glasses",
    "no glasses",
    "no glasses",
    "no glasses",
    "no glasses",
    "no glasses",
    "no glasses",
  };

  public static string[] personShirtColor = {
    "blue shirt",
    "blue shirt",
    "blue shirt",
    "red shirt",
    "grey shirt",
    "black shirt",
    "white shirt",
    "green shirt",
    "white shirt",
    "blue shirt",
    "blue shirt",
    "green shirt",
    "blue shirt",
    "white shirt",
    "black shirt",
    "green shirt",
    "red shirt",
    "pink shirt",
    "grey shirt",
    "blue shirt",
    "white shirt",
    "white shirt",
    "brown shirt",
    "black shirt",
  };
  

  public static string[] personSkinColor = {
    "white",
    "white",
    "white",
    "white",
    "white",
    "white",
    "white",
    "white",
    "white",
    "white",
    "white",
    "white",
    "white",
    "white",
    "white",
    "white",
    "white",
    "not white",
    "white",
    "white",
    "not white",
    "white",
    "white",
    "white",
  };

  void Start() {
    Debug.Log("adding");
    personObjects.Add(aaronReed);
    personObjects.Add(bjVoorhees);
    personObjects.Add(brettBeardall);
    personObjects.Add(camPeterson);
    personObjects.Add(chrisCantera);
    personObjects.Add(christianNickerson);
    personObjects.Add(coreyBurk);
    personObjects.Add(ericKohler);
    personObjects.Add(janeHeadParish);
    personObjects.Add(joeShull);
    personObjects.Add(joshKrebs);
    personObjects.Add(kasieHadley);
    personObjects.Add(kirkMarshall);
    personObjects.Add(mattBrown);
    personObjects.Add(melissaNelson);
    personObjects.Add(mercedesWiles);
    personObjects.Add(michealPritchard);
    personObjects.Add(omkarTerse);
    personObjects.Add(paulFox);
    personObjects.Add(raymondMaple);
    personObjects.Add(reneGuzman);
    personObjects.Add(ryanCox);
    personObjects.Add(sarahCarter);
    personObjects.Add(tiffanyHippie);
  }
}
