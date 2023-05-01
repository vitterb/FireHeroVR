using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class ErikNavFleeAI : MonoBehaviour
{

    public enum EnemyState
    {
        Idle, Moving, Fleeing
    }

    private NavMeshAgent navMeshAgent;
    private GameObject player;
    public float fleeDistance = 3f;
    public EnemyState currentState = EnemyState.Idle;
    
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        player = GameObject.FindWithTag("Player");
    }
    
    void Update()
    {
        switch (currentState)
        {
            case EnemyState.Idle:
                break;
            case EnemyState.Moving:
                if (!navMeshAgent.pathPending && navMeshAgent.remainingDistance < 5f)
                {
                    SetRandomDestination();
                }
                break;
        }

        float distanceToPlayer = Vector3.Distance(transform.position, player.transform.position);
        if ((currentState == EnemyState.Idle || currentState == EnemyState.Moving) && distanceToPlayer < 5f)
        {
            currentState = EnemyState.Fleeing;
        }

        if (currentState == EnemyState.Fleeing && distanceToPlayer > fleeDistance)
        {
            currentState = EnemyState.Moving;
        }
    }

    void SetRandomDestination()
    {
        Vector3 randomDirection = Random.insideUnitSphere * 10f;
        randomDirection += transform.position;
        NavMeshHit hit;
        NavMesh.SamplePosition(randomDirection, out hit, 10f, NavMesh.AllAreas);
        navMeshAgent.SetDestination(hit.position);
    }
}
