using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuData : MonoBehaviour
{
    public static MenuData Instance;

    public string fish1Name;
    public string fish2Name;
    public string fish3Name;
    [SerializeField] private InputField fish1Input;
    [SerializeField] private InputField fish2Input;
    [SerializeField] private InputField fish3Input;

    private void Awake()
    {
        if (Instance != null) //creates singleton: only one instance can exist
        {
            Destroy(gameObject);
            return;
        }
        Instance = this; // declares this is the current instance of main manager object, can call MainManager.instance from any script
        DontDestroyOnLoad(gameObject);
    }


    private void SetFishNames()
    {
        fish1Name = fish1Input.text;
        fish2Name = fish2Input.text;
        fish3Name = fish3Input.text;
    }

    public void LoadMainScene()
    {
        SetFishNames();
        SceneManager.LoadScene(1);
    }
}
