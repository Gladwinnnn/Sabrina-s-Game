using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{
    public void LoadGame()
    {
        SceneManager.LoadScene("Game Menu");
        Time.timeScale = 1;
    }

    public void LoadMenu()
    {
        SceneManager.LoadScene("Start Menu");
        Time.timeScale = 1;
    }

    public void Quit()
    {
        Application.Quit();
    }
}
