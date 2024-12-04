using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class cow2 : MonoBehaviour
{

    private NavMeshAgent agent;
    public GameObject Destination;
    public float Speed;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.SetDestination(Destination.transform.position);
    }

    void Update () 

    {
        agent.SetDestination(Destination.transform.position);
        

    // transform.LookAt(Destination.transform);
    // transform.position = Vector3.MoveTowards(transform.position, Destination.transform.position, Speed);
    }


}
