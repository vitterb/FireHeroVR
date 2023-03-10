using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public ParticleSystem fire;
    // Start is called before the first frame update
    void Start()
    {
        
        fire = gameObject.GetComponent<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        fire.transform.localScale -= new Vector3(0.001f, 0.001f, 0.001f);
        if (fire.transform.localScale.magnitude < 0.001f)
        {
            fire.gameObject.SetActive(false);
        }
        else
        {
            fire.gameObject.SetActive(true);
        }
        
    }
}
