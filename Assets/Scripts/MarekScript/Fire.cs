using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public ParticleSystem Marekfire;

    public ParticleSystem extinguisher;
    // Start is called before the first frame update
    void Start()
    {
        extinguisher = GetComponent<ParticleSystem>();
        Marekfire = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        /*Marekfire.transform.localScale -= new Vector3(0.001f, 0.001f, 0.001f);*/
        if (Marekfire.transform.localScale.magnitude < 0.001f)
        {
            Marekfire.gameObject.SetActive(false);
        }
        else
        {
            Marekfire.gameObject.SetActive(true);
        }
        
    }

    /*private void OnParticleCollision(GameObject other)
    {
        ParticleSystem extinguisher = other.GetComponent<ParticleSystem>();
        if (other.gameObject.CompareTag("MarekFire"))
        {
            Debug.Log("Particle collided with " + other.name == "Firegoesdown");
            if (extinguisher != null)
            {
                // interact with the other particle system
                Marekfire.transform.localScale -= new Vector3(0.001f, 0.001f, 0.001f);
            }
        }
    }*/
    private void OnParticleCollision(GameObject other)
    {
        if (other.gameObject.CompareTag("MarekFire"))
        {
            Marekfire.gameObject.SetActive(false);
        }
    }
    
}
