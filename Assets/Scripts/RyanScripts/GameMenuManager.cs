using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameMenuManager : MonoBehaviour
{
    public GameObject menu;
    public InputActionProperty showButton;
    public Transform head;
    public float spawnDistance = 2;
    public float alpha = 0.5f;
    private object currentMat;
    public GameObject Panel;
    
    
    void Start()
    {

    }

   
    void Update()
    {
        if (showButton.action.WasPerformedThisFrame())
        {
            menu.SetActive(!menu.activeSelf);

            menu.transform.position = head.position + new Vector3(head.forward.x, 0, head.forward.z).normalized * spawnDistance;
        }
        menu.transform.LookAt(new Vector3(head.position.x, menu.transform.position.y, head.position.z));
        menu.transform.forward *= -1;
    }
    public void ChangeAlphaOnValueChange(Slider slider)
    {
        ChangeAlpha(currentMat, slider.value);
    }

    private void ChangeAlpha(object currentMat, object value)
    {
        throw new NotImplementedException();
    }
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
    public void SettingsBtn()
    {
        if (GetComponent<Button>())
        {
            Panel.gameObject.SetActive(true);
        }
        else
        {
            Panel.gameObject.SetActive(false);
        }
    } 
    private void Awake()
    {
        if (PlayerPrefs.HasKey("Volume")){
            SetVolume(PlayerPrefs.GetFloat("Volume"));
            volumeSlider.value = PlayerPrefs.GetFloat("Volume");
        }
    }

    [SerializeField] private Slider volumeSlider;

    public void SetVolume(float volume)
    {
        AudioListener.volume = volume;
        PlayerPrefs.SetFloat("Volume", volume);
    }
    

}

