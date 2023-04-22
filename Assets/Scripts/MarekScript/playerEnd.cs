using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class playerEnd : MonoBehaviour
{
    public Interact goal;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("end") && goal.goal)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
