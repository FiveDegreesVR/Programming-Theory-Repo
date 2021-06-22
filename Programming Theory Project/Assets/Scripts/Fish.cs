using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fish : Animal
{
    //ABSTRACTION
    private int fishAge { get; set; }
    private string fishInfo { get; set; }
    private string fishName { get; set; }

    //POLYMORPHISM
    public override void DisplayInfo() 
    {
        title.text = "Fish: " + fishName;
        animalText.text = "Fish Age: " + fishAge + "\nFish Info: " + fishInfo;
    }
}
