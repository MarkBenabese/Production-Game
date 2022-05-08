using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("DeclanScene2");
    }

    public void Settings()
    {
        
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
