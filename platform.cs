using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platform : MonoBehaviour
{
    public float elevatorSpeed = 2f;
    private bool isRunning = false;
    private bool isRunningBack = false;
    private Vector3 StartPosition;
    public Vector3 EndPosition;

    void Start()
    {
        StartPosition = transform.position;
    }

    void Update()
    {

        if (isRunning)
        {
            float step = elevatorSpeed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, EndPosition, step);
            if (transform.position == EndPosition)
            {
                isRunning = false;
            }
        }
        if (isRunningBack)
        {
            float step = elevatorSpeed * Time.deltaTime;
            transform.position = Vector3.MoveTowards(transform.position, StartPosition, step);
            if (transform.position == StartPosition)
            {
                isRunningBack = false;
            }
        }
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if (transform.position == StartPosition)
            {
                isRunning = true;
            }
            if (transform.position == EndPosition)
            {
                isRunningBack = true;
            }
        }
    }
}