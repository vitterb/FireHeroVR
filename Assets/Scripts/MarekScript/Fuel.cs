using System.Collections;
using System.Collections.Generic;
using Unity.XR.Oculus.Input;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;
public class Fuel : MonoBehaviour
{
    public GameObject fuel;
    public ParticleSystem Ext;
    public InputActionProperty ybutton;
    public bool full;
    public bool ok;
    // Start is called before the first frame update
    void Start()
    {
        
        full = true;
        Ext.gameObject.SetActive(true);
        fuel.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        ok = true;
        if (full && ok)
        {
            Ext.gameObject.SetActive(true);
            fuel.transform.localScale -= new Vector3(0.0f, 0.0f, 0.001f);
        }
        if (ybutton.action.IsPressed() && full)
        {
            ok = false;
            Ext.gameObject.SetActive(false);
            fuel.transform.localScale -= new Vector3(0.0f, 0.0f, 0.0f);
        }
        if (fuel.transform.localScale.z < 0.1f)
        {
            full = false;
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
