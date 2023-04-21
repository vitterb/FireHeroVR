using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class Fuel : MonoBehaviour
{
    public GameObject fuel;
    public ParticleSystem Ext;
    public XRController controller;
    // Start is called before the first frame update
    void Start()
    {
        controller = GameObject.Find("LeftHand Controller").GetComponent<XRController>();
        Ext.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (fuel.transform.localScale.y < 0.1f)
        {
            fuel.SetActive(false);
            Ext.gameObject.SetActive(false);
        }
        if (controller.inputDevice.TryGetFeatureValue(CommonUsages.primaryButton, out bool primaryButtonValue) && primaryButtonValue)
        {
            fuel.transform.localScale -= new Vector3(0.0f, 0.0001f, 0.0f);
            Ext.gameObject.SetActive(true);
        }
    }
}
