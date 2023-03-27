using UnityEngine;
using UnityEngine.SceneManagement;

namespace RyanScripts
{
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
    }
}
