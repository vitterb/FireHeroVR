using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class FireSpawn : MonoBehaviour
{
    public ParticleSystem FirePrefab;
    public Transform[] spawnPoints;
    public float numberOfFires;
    public int spawnDelay;
    public Fire fireScript;
    
    // Start is called before the first frame update
    void Start()
    {
        fireScript = GetComponent<Fire>();
    }

    private void Update()
    {
        if (fireScript.MaxFire)
        {
            StartCoroutine(SpawnFires()); 
        }
    }

    // Update is called once per frame
    void SpawnEnemy()
    {
        int spawnIndex = Random.Range(0, spawnPoints.Length);
        Transform spawnPoint = spawnPoints[spawnIndex];
        ParticleSystem fire = Instantiate(FirePrefab, spawnPoint.position, spawnPoint.rotation);
     
    }
    IEnumerator SpawnFires()
    {
        for (int i = 0; i < numberOfFires; i++)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(spawnDelay);
        }
    }
}
