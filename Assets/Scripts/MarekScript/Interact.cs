using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class Interact : MonoBehaviour
{
    public Transform cotch;
    public bool goal = false;
    public bool grab = false;
    private void Start()
    {
        goal = false;
        grab = false;
    }

    private void Update()
    {
        if (grab) // if it is true
        {
            Vector3 cotchPos = cotch.position; // position of cotch
            Quaternion cotchRot = cotch.rotation; // rotation of growFire
            Vector3 cotchSca = cotch.localScale; // scale of growFire
   
            transform.position = cotchPos; // set position depending on cotchPos
            transform.rotation = cotchRot; // set rotation depending on cotchRot
            transform.localScale = cotchSca; // set scale depending on cotchSca
            
            goal = true;
        }
    }

    private void OnCollisionEnter(Collision other)
       {
           if (other.gameObject.CompareTag("playerMarek")) // collide with the game object that has tag playerMarek
           {
               grab = true; // set grab to be true
           }
       }
}
