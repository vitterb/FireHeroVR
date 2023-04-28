using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
public class Fire : MonoBehaviour
{
    public Transform[] spawnPoints; // array for spawning
    public float fireGrow = 0.0001f; // number that determines the growth of the fire 
    private Vector3 startingScale;
    public ParticleSystem Marekfire;
    public ParticleSystem Marekfire1;
    public bool MaxFire = false;
    public int numberFire; //additional fires counter
    public int numberOfFires = 2; // number of fires to spawn
    // Start is called before the first frame update
    void Start()
    {
        numberFire = 1; // set to number 1;
        Marekfire = GetComponent<ParticleSystem>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if (Marekfire.transform.localScale.magnitude < 0.5f) // check the magnitude, if less then 0.5
        {
            Marekfire.gameObject.SetActive(false); // set particle to false
        }
        else // if magnitude is not less than 0.5
        {
            Marekfire.gameObject.SetActive(true); // set particle to true, visible
        }

        if (!MaxFire && Marekfire.transform.localScale.magnitude < 3f) // check for fire to grow 
        {
            Marekfire.transform.localScale += new Vector3(fireGrow, fireGrow, fireGrow);
        }
        else if(Marekfire.transform.localScale.magnitude > 2f) // if the fire has reached a certain size, then spread 
        {
            if (numberFire > 0) // how many times
            {
                for (int i = 0; i < numberOfFires; i++) // how many fires
                {
                    int spawnIndex = Random.Range(0, spawnPoints.Length);// random spawn between spawning points 
                    Transform spawnPoint = spawnPoints[spawnIndex]; // get the spawning point
                    ParticleSystem fire = Instantiate(Marekfire1, spawnPoint.position, spawnPoint.rotation); // duplicate fires between those points
                    numberFire = -1; // change the number of times it's supposed to happen
                }
            }
        }
        else 
        {
            Marekfire.transform.localScale += new Vector3(fireGrow, fireGrow, fireGrow);
            MaxFire = false;
        }
    }
    private void OnParticleCollision(GameObject other)
    {
        if (other.gameObject.CompareTag("MarekExt")) // find a particle, which has tag MarekExt
        {
            Marekfire.transform.localScale -= new Vector3(0.05f, 0.05f, 0.05f); // scale down the scale
        }
    }
}
