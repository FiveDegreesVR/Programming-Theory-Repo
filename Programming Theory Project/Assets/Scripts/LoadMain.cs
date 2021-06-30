using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadMain : MonoBehaviour
{
    public static MenuData Instance;
    [SerializeField] private Button startButton;
    [SerializeField] private InputField fish1Input;
    [SerializeField] private InputField fish2Input;
    [SerializeField] private InputField fish3Input;

    // Start is called before the first frame update
    void Awake()
    {
        Instance = GameObject.FindGameObjectWithTag("AnimalData").GetComponent<MenuData>();

        startButton = GameObject.FindGameObjectWithTag("Start button").GetComponent<Button>();
        startButton.onClick.AddListener(LoadGameScene);
    }

    void LoadGameScene()
    {
        Instance.SetFish1Name(fish1Input.text);
        Instance.SetFish2Name(fish2Input.text);
        Instance.SetFish3Name(fish3Input.text);
        Instance.LoadMainScene();
    }
}
