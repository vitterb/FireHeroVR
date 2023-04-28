using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grow : MonoBehaviour
{
    public Transform growFire;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 firePos = growFire.position; // position of growFire
        Vector3 fireSca = growFire.localScale; // scale of growFire

        transform.position = firePos; // set position depending on growFire
        transform.localScale = fireSca; // set scale depending on growFire
    }
}
