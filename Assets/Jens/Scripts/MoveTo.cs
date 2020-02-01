using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveTo : MonoBehaviour
{
    private Vector3 destination;

    void Start()
    {
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            GetComponent<NavMeshAgent>().destination = transform.position + transform.forward;
        }
        if (Input.GetKey(KeyCode.S))
        {
            GetComponent<NavMeshAgent>().destination = transform.position + -transform.forward;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 1, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, -1, 0);
        }
    }
}
