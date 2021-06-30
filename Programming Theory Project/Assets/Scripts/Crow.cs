using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//INHERITANCE
public class Crow : Animal
{
    //ABSTRACTION
    private int crowAge;
    private string crowInfo;
    private string crowName;

    //POLYMORPHISM
    public override void DisplayInfo()
    {
        title.text = "Crow: " + crowName;
        animalText.text = "Crow Age: " + crowAge + "\nCrow Info: " + crowInfo;
    }

    //ENCAPSULATION
    //getters
    public int GetCrowAge()
    {
        return crowAge;
    }
    public string GetCrowName()
    {
        return crowName;
    }
    public string GetCrowInfo()
    {
        return crowInfo;
    }

    //setters
    public void SetCrowAge(int crowAge)
    {
        this.crowAge = crowAge;
    }
    public void SetCrowName(string crowName)
    {
        this.crowName = crowName;
    }
    public void SetCrowInfo(string crowInfo)
    {
        this.crowInfo = crowInfo;
    }
}
