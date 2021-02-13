using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void RestartLevel()
    {
        SceneManager.LoadScene("MiniGame");
    }
    public void Quit()
    {
        Application.Quit();
    }

    public void Continue()
    {
        SceneManager.LoadScene("EndGame");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("IntroScene");
    }
}
