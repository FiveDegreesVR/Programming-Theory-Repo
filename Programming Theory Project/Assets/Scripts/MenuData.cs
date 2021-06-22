using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuData : MonoBehaviour
{
    private Scene m_scene;
    private string fish1Name { get; set; }
    private string fish2Name { get; set; }
    private string fish3Name { get; set; }
    [SerializeField] private InputField fish1Input;
    [SerializeField] private InputField fish2Input;
    [SerializeField] private InputField fish3Input;

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    private void Start()
    {
        m_scene = SceneManager.GetActiveScene();
    }

    private void Update()
    {
        if (m_scene.buildIndex == 0)
        {
            fish1Name = fish1Input.text;
            fish2Name = fish2Input.text;
            fish3Name = fish3Input.text;
        }
    }
}
