using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThirdPersonMovement1 : MonoBehaviour
{
    public CharacterController controller;
    public float playerSpeed = 2.0f;


    void FixedUpdate()
    {
        //reading the input:
        float horizontalAxis = Input.GetAxis("Horizontal");
        float verticalAxis = Input.GetAxis("Vertical");
         
        //assuming we only using the single camera:
        var camera = Camera.main;
 
        //camera forward and right vectors:
        var forward = camera.transform.forward;
        var right = camera.transform.right;
 
        //project forward and right vectors on the horizontal plane (y = 0)
        forward.y = 0f;
        right.y = 0f;
        forward.Normalize();
        right.Normalize();
 
        //this is the direction in the world space we want to move:
        var desiredMoveDirection = forward * verticalAxis + right * horizontalAxis;
 
        //now we can apply the movement:
        controller.Move(desiredMoveDirection * playerSpeed * Time.deltaTime);
    }

    void Update()
    {
        // float horizontal = Input.GetAxisRaw("Horizontal");
        // float vertical = Input.GetAxisRaw("Vertical");


        // Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

        // if (direction.magnitude >= 0.1f)
        // {
        //     controller.Move(direction * playerSpeed * Time.deltaTime);
        // }

        // FixedUpdate();
    }



}
