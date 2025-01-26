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
  public static Trait[] personHairColor = {
    Trait.BrownHair,
    Trait.BrownHair,
    Trait.BrownHair,
    Trait.BrownHair,
    Trait.BrownHair,
    Trait.BrownHair,
    Trait.BrownHair,
    Trait.BrownHair,
    Trait.BrownHair,
    Trait.BrownHair,
    Trait.BrownHair,
    Trait.BrownHair,
    Trait.BrownHair,
    Trait.WhiteHair,
    Trait.BrownHair,
    Trait.BlondeHair,
    Trait.BrownHair,
    Trait.WhiteHair,
    Trait.BrownHair,
    Trait.BlackHair,
    Trait.BlackHair,
    Trait.BrownHair,
    Trait.BrownHair,
    Trait.BrownHair,
  };


  public static Trait[] personHairLength = {
    Trait.Short,
    Trait.Short,
    Trait.Bald,
    Trait.Short,
    Trait.Short,
    Trait.Short,
    Trait.Short,
    Trait.Short,
    Trait.Long,
    Trait.Long,
    Trait.Short,
    Trait.Long,
    Trait.Bald,
    Trait.Short,
    Trait.Short,
    Trait.Long,
    Trait.Short,
    Trait.Short,
    Trait.Short,
    Trait.Short,
    Trait.Long,
    Trait.Short,
    Trait.Long,
    Trait.Long,
  };

  public static Trait[] personFacialHair = {
    Trait.Beard,
    Trait.NoFacialHair,
    Trait.Goatee,
    Trait.Goatee,
    Trait.NoFacialHair,
    Trait.Goatee,
    Trait.Beard,
    Trait.Beard,
    Trait.NoFacialHair,
    Trait.Beard,
    Trait.Beard,
    Trait.NoFacialHair,
    Trait.Goatee,
    Trait.NoFacialHair,
    Trait.NoFacialHair,
    Trait.NoFacialHair,
    Trait.NoFacialHair,
    Trait.Beard,
    Trait.Beard,
    Trait.NoFacialHair,
    Trait.Beard,
    Trait.Beard,
    Trait.NoFacialHair,
    Trait.NoFacialHair,
  };
  
  public static Trait[] personGender = {
    Trait.Male,
    Trait.Male,
    Trait.Male,
    Trait.Male,
    Trait.Male,
    Trait.Male,
    Trait.Male,
    Trait.Male,
    Trait.Female,
    Trait.Male,
    Trait.Male,
    Trait.Female,
    Trait.Male,
    Trait.Male,
    Trait.Female,
    Trait.Female,
    Trait.Male,
    Trait.Male,
    Trait.Male,
    Trait.Male,
    Trait.Male,
    Trait.Male,
    Trait.Female,
    Trait.Female,
  };

  public static Trait[] personGlasses = {
    Trait.NoGlasses,
    Trait.NoGlasses,
    Trait.NoGlasses,
    Trait.NoGlasses,
    Trait.Glasses,
    Trait.Glasses,
    Trait.Glasses,
    Trait.NoGlasses,
    Trait.NoGlasses,
    Trait.NoGlasses,
    Trait.NoGlasses,
    Trait.NoGlasses,
    Trait.Glasses,
    Trait.NoGlasses,
    Trait.NoGlasses,
    Trait.NoGlasses,
    Trait.NoGlasses,
    Trait.NoGlasses,
    Trait.NoGlasses,
    Trait.NoGlasses,
    Trait.NoGlasses,
    Trait.NoGlasses,
    Trait.NoGlasses,
    Trait.NoGlasses,
  };

  public static Trait[] personShirtColor = {
    Trait.BlueShirt,
    Trait.BlueShirt,
    Trait.BlueShirt,
    Trait.RedShirt,
    Trait.GreyShirt,
    Trait.BlackShirt,
    Trait.WhiteShirt,
    Trait.GreenShirt,
    Trait.WhiteShirt,
    Trait.BlueShirt,
    Trait.BlueShirt,
    Trait.GreenShirt,
    Trait.BlueShirt,
    Trait.WhiteShirt,
    Trait.BlackShirt,
    Trait.GreenShirt,
    Trait.RedShirt,
    Trait.PinkShirt,
    Trait.GreyShirt,
    Trait.BlueShirt,
    Trait.WhiteShirt,
    Trait.WhiteShirt,
    Trait.BrownShirt,
    Trait.BlackShirt,
  };
  

  public static Trait[] personSkinColor = {
    Trait.WhiteSkin,
    Trait.WhiteSkin,
    Trait.WhiteSkin,
    Trait.WhiteSkin,
    Trait.WhiteSkin,
    Trait.WhiteSkin,
    Trait.WhiteSkin,
    Trait.WhiteSkin,
    Trait.WhiteSkin,
    Trait.WhiteSkin,
    Trait.WhiteSkin,
    Trait.WhiteSkin,
    Trait.WhiteSkin,
    Trait.WhiteSkin,
    Trait.WhiteSkin,
    Trait.WhiteSkin,
    Trait.WhiteSkin,
    Trait.NotWhiteSkin,
    Trait.WhiteSkin,
    Trait.WhiteSkin,
    Trait.NotWhiteSkin,
    Trait.WhiteSkin,
    Trait.WhiteSkin,
    Trait.WhiteSkin,
  };

  void Start() {
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
