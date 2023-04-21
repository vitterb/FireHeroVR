using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    public GameObject HealthRestart;

    public Interact goal;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!HealthRestart.activeSelf)
        {
            Restart();
        }
    }
    private void Restart()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

   
}
