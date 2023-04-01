using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Enemy_Follow : MonoBehaviour
{
    public NavMeshAgent Speeder;
    public Transform Player;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Speeder.SetDestination(Player.position);
    }
}

