using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crow : Animal
{
    //ABSTRACTION
    private int crowAge { get; set; }
    private string crowInfo { get; set; }
    private string crowName { get; set; }

    //POLYMORPHISM
    public override void DisplayInfo()
    {
        title.text = "Crow: " + crowName;
        animalText.text = "Crow Age: " + crowAge + "\nCrow Info: " + crowInfo;
    }
}
