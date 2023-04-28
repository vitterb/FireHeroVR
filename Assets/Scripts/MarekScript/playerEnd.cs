using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class playerEnd : MonoBehaviour
{
    public Interact goal; // interacting with a script in unity
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("end") && goal.goal) // if the player collide with the game object that has tag "end" and the goal is true
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name); // go to the next scene
        }
    }
}
