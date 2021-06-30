using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimalData : MonoBehaviour
{
    //ABSTRACTION
    private Fish fish1;
    private Fish fish2;
    private Fish fish3;
    private Crow crow;
    private MenuData menuData;

    private string defaultFishInfo = " is a good fish!";

    // Start is called before the first frame update
    void Start()
    {
        SetScripts();

        SetAnimalNames();

        SetAnimalAges();

        SetAnimalInfos();
    }

    private void SetScripts()
    {
        fish1 = GameObject.FindGameObjectWithTag("Fish 1").GetComponent<Fish>();
        fish2 = GameObject.FindGameObjectWithTag("Fish 2").GetComponent<Fish>();
        fish3 = GameObject.FindGameObjectWithTag("Fish 3").GetComponent<Fish>();
        crow = GameObject.FindGameObjectWithTag("Crow").GetComponent<Crow>();
        menuData = GameObject.FindGameObjectWithTag("AnimalData").GetComponent<MenuData>();
    }

    private void SetAnimalNames()
    {
        fish1.SetFishName(menuData.GetFish1Name());
        fish2.SetFishName(menuData.GetFish2Name());
        fish3.SetFishName(menuData.GetFish3Name());
        crow.SetCrowName("Jim");
    }

    private void SetAnimalAges()
    {
        fish1.SetFishAge(Random.Range(1, 10));
        fish2.SetFishAge(Random.Range(1, 10));
        fish3.SetFishAge(Random.Range(1, 10));
        crow.SetCrowAge(Random.Range(1, 10));
    }

    private void SetAnimalInfos()
    {
        fish1.SetFishInfo(fish1.GetFishName() + defaultFishInfo);
        fish2.SetFishInfo(fish2.GetFishName() + defaultFishInfo);
        fish3.SetFishInfo(fish3.GetFishName() + defaultFishInfo);
        crow.SetCrowInfo(crow.GetCrowName() + " is a curious crow!");
    }
}
