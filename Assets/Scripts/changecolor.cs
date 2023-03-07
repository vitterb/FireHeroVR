using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changecolor : MonoBehaviour
{
    public Material Activecolor;
    public Material BaseMaterial;
    public GameObject[] otherbuttons;

    public void pushactive(GameObject thisgameobject)
    {
        thisgameobject.GetComponent<Renderer>().material = Activecolor;
    }

    public void unactivate()
    {
        foreach (var button in otherbuttons)
        {
            button.transform.GetChild(0).GetComponent<Renderer>().material = BaseMaterial;
        }      
    }
}
