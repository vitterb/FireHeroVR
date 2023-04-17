using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI; 
public class Cat : MonoBehaviour
{
    public enum EnemyState {Idle, Moving, Following}
    private NavMeshAgent navMeshAgent;
    private GameObject player;
    public EnemyState currentState = EnemyState.Idle;
    // Start is called before the first frame update
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        //navMeshAgent.SetDestination(player.transform.position);
        switch (currentState)
        {
            case EnemyState.Idle:
                break;
            case EnemyState.Moving:
                if (!navMeshAgent.pathPending && navMeshAgent.remainingDistance < 0.1f)
                {
                    SetRandomDestination();
                }
                break;
            case EnemyState.Following:
                navMeshAgent.SetDestination(player.transform.position);

                break;

        }
    }
    
    void SetRandomDestination()
    {
        Vector3 randomDirection = Random.insideUnitSphere * 10;
        randomDirection += transform.position;
        NavMeshHit hit;
        NavMesh.SamplePosition(randomDirection, out hit, 10f, NavMesh.AllAreas);
        navMeshAgent.SetDestination(hit.position);
    }
}
