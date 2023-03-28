using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class FireSpread : MonoBehaviour
{
   // The size at which the particle will spawn between empty points
    public GameObject[] emptyPoints; // An array of empty objects where the particle can spawn
    public Fire fireScript;
    // Start is called before the first frame update
    void Start()
    {
        fireScript = GetComponent<Fire>();
    }

    // Update is called once per frame
    void Update()
    {
        //if (fireScript.MaxFire && fireScript.numberOfFires > 0)
        //{
        //    StartCoroutine(SpawnParticle());
        //}
    }
    
    private IEnumerator SpawnParticle()
    {
        yield return new WaitForSeconds(20f);
        fireScript.MaxFire = false;
        GameObject emptyPoint = emptyPoints[Random.Range(0, emptyPoints.Length)];
        transform.position = emptyPoint.transform.position; // Set the particle's position to a random empty point
        yield return new WaitForSeconds(20f);
        fireScript.MaxFire = true;
        yield return new WaitForSeconds(20f);
    }
    /*void SpawnEnemy()
    {
        int spawnIndex = Random.Range(0, spawnPoints.Length);
        Transform spawnPoint = spawnPoints[spawnIndex];

        GameObject enemy = Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);

        NavMeshAgent navMeshAgent = enemy.GetComponent<NavMeshAgent>();
        navMeshAgent.Warp(spawnPoint.position);


    }*/
}
