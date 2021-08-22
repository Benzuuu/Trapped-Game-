using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Animator))]

public class Movement : MonoBehaviour
{
    public float moveSpeed = 1.0f;
    private Vector2 playerMoveInput;
    private Animator anim;

    private Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        //As movement is detected, play moving animation
        if (context.started)
        {
            anim.Play("Moving");
        }

        //Retrieve input values and transfer valuesto the animator controller
        playerMoveInput = context.ReadValue<Vector2>();
        anim.SetFloat("MoveX", playerMoveInput.x);
        anim.SetFloat("MoveY", playerMoveInput.y);

        //Determines the most recent direction faced by player before he stops
        if (playerMoveInput != Vector2.zero)
        {
            anim.SetFloat("DirX", playerMoveInput.x);
            anim.SetFloat("DirY", playerMoveInput.y);
        }
        
        //When movement is finished, play idle animation
        if (context.performed)
        {
            anim.Play("Idle");
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = playerMoveInput * moveSpeed;
    }

    public void StopPlayer()
    {
        anim.Play("Idle");
        playerMoveInput = Vector2.zero;
    }
}
