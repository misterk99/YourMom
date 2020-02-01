﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPCMovement : MonoBehaviour
{
    [SerializeField]
    NavMeshAgent agent;
    [SerializeField]
    Vector3 destination;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        if (agent == null || NPCManager.min == null || NPCManager.max == null)
            return;
        RecalculatePath();

    }

    // Update is called once per frame
    void Update()
    {
        if (agent == null || NPCManager.min == null || NPCManager.max == null)
            return;

        if (Vector3.Distance(transform.position,agent.destination) <= 1.0f)
        {
            Debug.Log("Nice");
            RecalculatePath();
        }

        if(agent.destination != Vector3.zero)
        {
            destination = agent.destination;
        }

    }

    private void RecalculatePath()
    {
        Vector3 randomPosition = new Vector3(Random.Range(NPCManager.min.position.x, NPCManager.max.position.x), Random.Range(NPCManager.min.position.y, NPCManager.max.position.y), Random.Range(NPCManager.min.position.z, NPCManager.max.position.z));
        NavMeshPath path = new NavMeshPath();
        NavMesh.CalculatePath(transform.position, randomPosition, NavMesh.AllAreas, path);
        if (path.status == NavMeshPathStatus.PathComplete)
        {
            agent.SetPath(path);
        }
        else
        {
            RecalculatePath();
        }
    }
}
