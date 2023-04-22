using System.Collections;
using System.Collections.Generic;
using Unity.XR.Oculus.Input;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class Fuel : MonoBehaviour
{
    public OculusTouchController button; 
    public GameObject fuel;
    public ParticleSystem Ext;

    public bool full;
    // Start is called before the first frame update
    void Start()
    {
        full = true;
        Ext.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Ext.gameObject.SetActive(false);
        if (button.primaryButton.isPressed && full)
        {
            Ext.gameObject.SetActive(true);
            fuel.transform.localScale -= new Vector3(0.0f, 0.0001f, 0.0f);
            if (fuel.transform.localScale.y < 0.1f)
            {
                full = false;
            }
        }
        if (!full)
        {
            fuel.SetActive(false);
            Ext.gameObject.SetActive(false);
        }
        /*fuel.transform.localScale -= new Vector3(0.0f, 0.0001f, 0.0f);
        
        if (fuel.transform.localScale.y < 0.1f)
        {
            fuel.SetActive(false);
            Ext.gameObject.SetActive(false);
        }*/
    }
}
