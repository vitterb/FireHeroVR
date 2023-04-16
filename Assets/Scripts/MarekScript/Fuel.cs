using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fuel : MonoBehaviour
{
    public GameObject fuel;

    public ParticleSystem Ext;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        fuel.transform.localScale -= new Vector3(0.0f, 0.0001f, 0.0f);
        if (fuel.transform.localScale.y < 0.1f)
        {
            fuel.SetActive(false);
            Ext.gameObject.SetActive(false);
        }
    }
}
