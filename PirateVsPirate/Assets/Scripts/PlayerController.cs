using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [field: SerializeField] public InputReader InputReader { get; private set; }
    [field: SerializeField] public Rigidbody Rigidbody { get; private set; }

    private void Update()
    {
        Movement();
        Aiming();
    }

    private void Aiming()
    {
    }

    private void Movement()
    {
        Vector3 movement = new Vector3(InputReader.MovementValue.x, 0, InputReader.MovementValue.y);
        Rigidbody.MovePosition(movement);
    }
}
