using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Fire2 : MonoBehaviour
{
    public float fireGrow = 0.0001f;
    private Vector3 startingScale;
    public ParticleSystem Marekfire;
    public bool MaxFire = false;
    // Start is called before the first frame update
    void Start()
    {
        Marekfire = GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Marekfire.transform.localScale.magnitude < 0.5f) // check the magnitude, if less then 0.5
        {
            Marekfire.gameObject.SetActive(false);// set particle to false
        }
        else // if magnitude is not less than 0.5
        {
            Marekfire.gameObject.SetActive(true); // set particle to true, visible
        }

        if (!MaxFire && Marekfire.transform.localScale.magnitude < 3f) // check for fire to grow 
        {
            Marekfire.transform.localScale += new Vector3(fireGrow, fireGrow, fireGrow);
        }
        else if(Marekfire.transform.localScale.magnitude > 2f) // if the fire has reached a certain size, then stop
        {
            MaxFire = true;
        }
        else
        {
            Marekfire.transform.localScale += new Vector3(fireGrow, fireGrow, fireGrow);
            MaxFire = false;
        }
    }
    
    private void OnParticleCollision(GameObject other)
    {
        if (other.gameObject.CompareTag("MarekExt"))// find a particle, which has tag MarekExt
        {
            Marekfire.transform.localScale -= new Vector3(0.05f, 0.05f, 0.05f); // scale down the scale
        }
    }
}
