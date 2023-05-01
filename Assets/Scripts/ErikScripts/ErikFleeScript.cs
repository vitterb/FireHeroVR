using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ErikFleeScript : MonoBehaviour
{
    public Transform player;
    public Transform house;
    public float fleeDistance = 5f;
    public float moveSpeed = 5f;
    public float avoidDistance = 2f;

    private Vector3 moveDirection;

    void Update()
    {
        float distanceToPlayer = Vector3.Distance(transform.position, player.position);

        if (distanceToPlayer < fleeDistance)
        {
            moveDirection = transform.position - player.position;
            transform.position += moveDirection.normalized * moveSpeed * Time.deltaTime;
        }

        float distanceToAvoidObject = Vector3.Distance(transform.position, house.position);

        if (distanceToAvoidObject < avoidDistance)
        {
            moveDirection = transform.position - house.position;
            transform.position += moveDirection.normalized * moveSpeed * Time.deltaTime;
        }
    }
}
