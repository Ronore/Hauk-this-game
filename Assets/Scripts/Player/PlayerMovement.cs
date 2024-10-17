using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody rigidBody;

    private float walkSpeed = 10.0f;
    Vector2 moveInput;
    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        Vector3 playerVelocity = new Vector3(moveInput.x * walkSpeed, rigidBody.velocity.y, moveInput.y * walkSpeed);
        rigidBody.velocity = this.transform.TransformDirection(playerVelocity);
    }

    public void OnMove(InputValue value)
    {
         moveInput = value.Get<Vector2>();
    }
}
