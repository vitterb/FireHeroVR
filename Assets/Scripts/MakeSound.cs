using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeSound : MonoBehaviour
{
    public AudioSource Audiosource;

    private void OnTriggerEnter(Collider other)
    {
        if (!Audiosource.isPlaying)
        {
            Audiosource.Play();
        }
    }
}
