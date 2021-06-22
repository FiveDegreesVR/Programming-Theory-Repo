using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//INHERITANCE
public abstract class Animal : MonoBehaviour
{
    public Text title;
    public Text animalText;

    public abstract void DisplayInfo();

    public void OnMouseDown()
    {
        DisplayInfo();
    }
}
