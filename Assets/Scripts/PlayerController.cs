using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    public float speed;
    public float jumpSpeed;
    public float gravity;
    private Vector3 moveDirection = Vector3.zero;

    private bool running = false;

    void Update () {
        CharacterController controller = GetComponent<CharacterController>();
        if (controller.isGrounded)
        {
            actualizeSpeed();
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;
            if (Input.GetButton("Jump"))
                moveDirection.y = jumpSpeed;
        }
        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);
    }

    void actualizeSpeed()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift) && !running)
        {
            speed *= 2;
            running = true;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift) && running)
        {
            speed /= 2;
            running = false;
        }
    }
}
