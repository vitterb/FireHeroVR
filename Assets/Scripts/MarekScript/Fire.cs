using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
public class Fire : MonoBehaviour
{
    public int FireDamage = 1;
    public Transform[] spawnPoints;
    public float fireGrow = 0.0001f;
    public float waitTime = 2f;
    private Vector3 startingScale;
    public ParticleSystem Marekfire;
    public ParticleSystem Marekfire1;
    public ParticleSystem Mareksmoke;
    public bool MaxFire = false;
    public int numberFire;
    public int numberOfFires = 2; 
    // Start is called before the first frame update
    void Start()
    {
        numberFire = 1;
        Marekfire = GetComponent<ParticleSystem>();
        Mareksmoke = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        
        /*Marekfire.transform.localScale -= new Vector3(0.001f, 0.001f, 0.001f);*/
        if (Marekfire.transform.localScale.magnitude < 0.1f && Mareksmoke.transform.localScale.magnitude < 0.01f)
        {
            Marekfire.gameObject.SetActive(false);
        }
        else
        {
            Marekfire.gameObject.SetActive(true);
        }

        if (!MaxFire && Marekfire.transform.localScale.magnitude < 5f)
        {
            Marekfire.transform.localScale += new Vector3(fireGrow, fireGrow, fireGrow);
        }
        else if(Marekfire.transform.localScale.magnitude > 4f)
        {
            if (numberFire > 0)
            {
                for (int i = 0; i < numberOfFires; i++)
                {
                    int spawnIndex = Random.Range(0, spawnPoints.Length);
                    Transform spawnPoint = spawnPoints[spawnIndex];
                    ParticleSystem fire = Instantiate(Marekfire1, spawnPoint.position, spawnPoint.rotation);
                    numberFire = -1;
                }
            }
        }
        else
        {
            Marekfire.transform.localScale += new Vector3(0.0001f, 0.0001f, 0.0001f);
            MaxFire = false;
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
