using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public float fireGrow = 0.5f;
    public float waitTime = 2f;
    private Vector3 startingScale;
    public ParticleSystem Marekfire;
    public ParticleSystem Mareksmoke;
    // Start is called before the first frame update
    void Start()
    {
        Marekfire = GetComponent<ParticleSystem>();
        Mareksmoke = GetComponent<ParticleSystem>();
        
    }
    

    // Update is called once per frame
    void Update()
    {
        
        /*Marekfire.transform.localScale -= new Vector3(0.001f, 0.001f, 0.001f);*/
        if (Marekfire.transform.localScale.magnitude < 0.01f && Mareksmoke.transform.localScale.magnitude < 0.01f)
        {
            Marekfire.gameObject.SetActive(false);
        }
        else
        {
            Marekfire.gameObject.SetActive(true);
        }

        if (Marekfire.transform.localScale.magnitude <= 5f)
        {
            Marekfire.transform.localScale += new Vector3(0.0001f, 0.0001f, 0.0001f);
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
        if (other.gameObject.CompareTag("MarekExt"))
        {
            Marekfire.transform.localScale -= new Vector3(0.05f, 0.05f, 0.05f);
            Mareksmoke.transform.localScale -= new Vector3(0.01f, 0.01f, 0.01f);
        }
    }

    private IEnumerator WaitingForChange()
    {
        do
        {
            yield return new WaitForSeconds(waitTime);
            Marekfire.transform.localScale += new Vector3(0.01f, 0.01f, 0.01f);
        } while (Marekfire.transform.localScale.magnitude < 3f);

    }
    
    
}
