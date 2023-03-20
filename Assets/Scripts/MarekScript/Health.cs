using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    public GameObject MarekPlayer;
    public int PlayerHealth;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (MarekPlayer.transform.localScale.y < 0.1f)
        {
            MarekPlayer.SetActive(false);
        }
    }

    private void OnParticleCollision(GameObject other)
    {
        if (other.gameObject.CompareTag("MarekFire"))
        {
            MarekPlayer.transform.localScale -= new Vector3(0.0f, 0.01f, 0.0f);
        }
    }
}