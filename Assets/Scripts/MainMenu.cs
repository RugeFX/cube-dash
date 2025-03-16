using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Button PlayButton;
    public Button QuitButton;

    private void HandlePlay()
    {
        SceneManager.LoadScene("Cube");
    }

    private void HandleQuit()
    {
        Application.Quit();
    }

    // Start is called before the first frame update
    void Start()
    {
        PlayButton.onClick.AddListener(HandlePlay);
        QuitButton.onClick.AddListener(HandleQuit);
    }
}
