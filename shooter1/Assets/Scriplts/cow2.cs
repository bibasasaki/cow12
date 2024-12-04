using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cow2 : MonoBehaviour
{
    public GameObject Destination;
public float Speed;

void Update () 

{
    transform.LookAt(Destination.transform);
    transform.position = Vector3.MoveTowards(transform.position, Destination.transform.position, Speed);
}
}
