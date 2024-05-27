using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Jeremey : MonoBehaviour
{
    public NavMeshAgent bomb;

    public Transform player;

    private void Update()
    {
        bomb.destination = player.position;
    }
}
