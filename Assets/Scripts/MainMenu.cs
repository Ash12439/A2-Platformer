using System;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{

    public void StartGame()
    {
        SceneManager.LoadScene("Environment");
    }


    public void QuitGame()
    {
        Debug.Log("Game is Over");
        Application.Quit();
    }
}
