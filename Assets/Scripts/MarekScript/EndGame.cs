using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    public GameObject HealthRestart;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!HealthRestart.activeSelf) //if game object is not active, start the function or method
        {
            Restart(); 
        }
        
    }
    private void Restart()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name); // load the scene for restarting the game
        }

   
}
