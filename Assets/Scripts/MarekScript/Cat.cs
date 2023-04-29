using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI; 
public class Cat : MonoBehaviour
{
    public enum CatState {Idle, Moving, Following}
    private NavMeshAgent navMeshAgent;
    public CatState currentState = CatState.Moving;
    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        switch (currentState)
        {
            case CatState.Idle:
                break;
            case CatState.Moving:
                if (!navMeshAgent.pathPending && navMeshAgent.remainingDistance < 0.1f) //check for current destination and 
                {
                    SetRandomDestination(); // start function for random direction
                }
                break;
            case CatState.Following:
                break;
        }
    }
    
    void SetRandomDestination()
    {
        Vector3 randomDirection = Random.insideUnitSphere * 10; //generate random direction, range 10
        randomDirection += transform.position; //random direction move according to the cat's current position  
        NavMeshHit hit; // final goal for Cat
        NavMesh.SamplePosition(randomDirection, out hit, 10f, NavMesh.AllAreas); //find position within 10f in NavMeshArea, random position
        navMeshAgent.SetDestination(hit.position); //hit the position
    }
}
