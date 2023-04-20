using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grow : MonoBehaviour
{
    public ParticleSystem growFire;

    public float growNumber = 0.001f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        growFire.transform.localScale += new Vector3(growNumber, growNumber, growNumber);
    }
}
