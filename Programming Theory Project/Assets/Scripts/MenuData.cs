using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuData : MonoBehaviour
{
    public static MenuData Instance;

    private string fish1Name;
    private string fish2Name;
    private string fish3Name;
    private Button startButton;
    private InputField fish1Input;
    private InputField fish2Input;
    private InputField fish3Input;

    private void Awake()
    {
        if (Instance != null) //creates singleton: only one instance can exist
        {
            Destroy(gameObject);
            return;
        }
        Instance = this; 
        DontDestroyOnLoad(gameObject);

        startButton = GameObject.FindGameObjectWithTag("Start button").GetComponent<Button>();
        startButton.onClick.AddListener(LoadMainScene);

        SetInputFields();
    }


    private void SetFishNames()
    {
        fish1Name = fish1Input.text;
        fish2Name = fish2Input.text;
        fish3Name = fish3Input.text;
    }

    private void SetInputFields()
    {
        fish1Input = GameObject.FindGameObjectWithTag("Fish 1 Input").GetComponent<InputField>();
        fish2Input = GameObject.FindGameObjectWithTag("Fish 2 Input").GetComponent<InputField>();
        fish3Input = GameObject.FindGameObjectWithTag("Fish 3 Input").GetComponent<InputField>();
    }

    public void LoadMainScene()
    {
        SetInputFields();
        SetFishNames();
        SceneManager.LoadScene(1);
    }

    //getters
    public string GetFish1Name()
    {
        return fish1Name;
    }
    public string GetFish2Name()
    {
        return fish2Name;
    }
    public string GetFish3Name()
    {
        return fish3Name;
    }

    //setters
    public void SetFish1Name(string fish1Name)
    {
        this.fish1Name = fish1Name;
    }
    public void SetFish2Name(string fish2Name)
    {
        this.fish2Name = fish2Name;
    }
    public void SetFish3Name(string fish3Name)
    {
        this.fish3Name = fish3Name;
    }
}
