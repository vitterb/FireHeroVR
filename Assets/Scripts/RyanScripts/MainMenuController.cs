using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void StartBtn()
    {
        SceneManager.LoadScene("AlphaScene");
    }
    public void QuitBtn()
    {
        Application.Quit();
        Debug.Log("QuitGame");
    }
    public void MainMenuBtn()
    {
        SceneManager.LoadScene("RyanMainMenu");
    }
    public void RestartBtn()
    {
        SceneManager.LoadScene("AlphaScene");
    }
}
