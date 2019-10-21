using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(CharacterController))]
[AddComponentMenu("Control Script/FPS Input")]
public class FBSInput : MonoBehaviour
{
    CharacterController characterController;

    public float speed = 12.0f;
    public float jumpSpeed = 25.0f;
    public float gravity = 20.0f;
    public bool hasBoot = false;
    private bool hasSpring = false;
    private Vector3 moveDirection = Vector3.zero;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
        hasBoot = false;
        hasSpring = false;
    }

    void Update()
    {
        if (Input.GetKey("f") && hasBoot)
        {
            speed = 18.0f;
        }
        else if (Input.GetKey("r"))
        {
            speed = 1.5f;
        }
        else if (Input.GetKey("c"))
        {
            speed = 50.0f;
        }

        else
        {
            speed = 12.0f;
        }
        if (characterController.isGrounded)
        {
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
            moveDirection *= speed;
            moveDirection = transform.TransformDirection(moveDirection);

            if (Input.GetButton("Jump") && hasSpring)
            {
                moveDirection.y = jumpSpeed;
            }
        }

        moveDirection.y -= gravity * Time.deltaTime;

        characterController.Move(moveDirection * Time.deltaTime);
    }

    public void gotBoot()
    {
        hasBoot = true;
    }

    public void gotSpring()
    {
        hasSpring = true;
    }
}
