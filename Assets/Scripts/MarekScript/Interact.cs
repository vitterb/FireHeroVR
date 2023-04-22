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
        if (grab)
        {
            Vector3 cotchPos = cotch.position;
            Quaternion cotchRot = cotch.rotation;
            Vector3 cotchSca = cotch.localScale;
   
            transform.position = cotchPos;
            transform.rotation = cotchRot;
            transform.localScale = cotchSca;
            
            goal = true;
        }
    }

    private void OnCollisionEnter(Collision other)
       {
           if (other.gameObject.CompareTag("playerMarek"))
           {
               grab = true;
           }
       }
}
