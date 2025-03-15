using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuNew : MonoBehaviour
{
    public void PlayGame(){
        SceneManager.LoadSceneAsync("Cube");
    }
}
