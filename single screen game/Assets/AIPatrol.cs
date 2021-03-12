using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Events;

public class AIPatrol : MonoBehaviour
{
    [SerializeField] private UnityEvent<float> move;
    [SerializeField] private float moveDir = 1f;

    // Update is called once per frame
    void Update()
    {
        move.Invoke(moveDir)
    }
    private void OntriggerEnter2D(Collider2D other)
    {
        moveDir *= -1;
    }
}