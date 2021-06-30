using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//INHERITANCE
public class Fish : Animal
{
    //ABSTRACTION
    private int fishAge;
    private string fishInfo;
    private string fishName;

    //POLYMORPHISM
    public override void DisplayInfo() 
    {
        title.text = "Fish: " + fishName;
        animalText.text = "Fish Age: " + fishAge + "\nFish Info: " + fishInfo;
    }

    //ENCAPSULATION
    //getters
    public int GetFishAge()
    {
        return fishAge;
    }
    public string GetFishName()
    {
        return fishName;
    }
    public string GetFishInfo()
    {
        return fishInfo;
    }
    
    //setters
    public void SetFishAge(int fishAge)
    {
        this.fishAge = fishAge;
    }
    public void SetFishName(string fishName)
    {
        this.fishName = fishName;
    }
    public void SetFishInfo(string fishInfo)
    {
        this.fishInfo = fishInfo;
    }
}
