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
        Vector3 firePos = growFire.position;
        // Quaternion fireRot = growFire.rotation;
        Vector3 fireSca = growFire.localScale;

        transform.position = firePos;
        // transform.rotation = fireRot;
        transform.localScale = fireSca;
    }
}
