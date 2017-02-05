using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    public float speed;
    public float jumpSpeed;
    public float gravity;
    private Vector3 moveDirection = Vector3.zero;
    private Vector3 moveRotation = Vector3.zero;

    private bool running = false;
    private bool moving = false;

    private bool left = false;

    void Update () {
        CharacterController controller = GetComponent<CharacterController>();

        if (controller.isGrounded)
        {
            actualizeSpeed();
            actualizeState();
            rotateHead();
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

    void actualizeState()
    {
        if ((Input.GetKeyDown(KeyCode.Z) || Input.GetKeyDown(KeyCode.S) || Input.GetKeyDown(KeyCode.Q) || Input.GetKeyDown(KeyCode.D)) && !moving)
        {
            moving = true;
        }
        if ((Input.GetKeyUp(KeyCode.Z) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.Q) || Input.GetKeyUp(KeyCode.D)) && moving)
        {
            moving = false;
        }
    }

    void rotateHead()
    {
        if (moving)
        {
            float rotation = Camera.main.gameObject.transform.eulerAngles.z;
            if (left)
            {
                print(Camera.main.gameObject.transform.eulerAngles.z);
                Camera.main.gameObject.transform.Rotate(0, 0, 0.3F);
                rotation = Camera.main.gameObject.transform.eulerAngles.z;
                if (rotation > 5)
                {
                    Camera.main.gameObject.transform.Rotate(0, 0, -rotation);
                    left = false;
                }
            }
            else
            {
                print(Camera.main.gameObject.transform.eulerAngles.z);
                Camera.main.gameObject.transform.Rotate(0, 0, -0.3F);
                rotation = Camera.main.gameObject.transform.eulerAngles.z;
                if (rotation < 355)
                {
                    Camera.main.gameObject.transform.Rotate(0, 0, -rotation);
                    left = true;
                }
            }
        }
        else
        {
            Camera.main.gameObject.transform.Rotate(0, 0, -Camera.main.gameObject.transform.eulerAngles.z);
        }
    }
}
