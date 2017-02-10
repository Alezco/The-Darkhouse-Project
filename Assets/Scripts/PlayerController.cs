using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    public float speed;
    public float jumpSpeed;
    public float gravity;
    private Vector3 moveDirection = Vector3.zero;

    private bool running = false;
    private bool moving = false;
    private bool crouching = false;
    private bool left = false;

    void OnStart()
    {
        
    }

    void Update () {
        AudioSource audio = GetComponent<AudioSource>();
        CharacterController controller = GetComponent<CharacterController>();
        actualizeState(audio, controller);
        if (controller.isGrounded)
        {   
            runPlayer();
            crouchPlayer();
            //rotateHead();
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= speed;

            if (Input.GetButton("Jump"))
                moveDirection.y = jumpSpeed;               
        }
        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);
    }

    void actualizeState(AudioSource audio, CharacterController controller)
    {
        if ((Input.GetKey(KeyCode.Z) || Input.GetKey(KeyCode.Q) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.S)) && controller.isGrounded)
        {
            if (!audio.isPlaying)
                audio.Play();
        }
        else
        {
            audio.Stop();
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
                Camera.main.gameObject.transform.Rotate(0, 0, 0.1F);
                rotation = Camera.main.gameObject.transform.eulerAngles.z;
                if (rotation > 0)
                {
                    Camera.main.gameObject.transform.Rotate(0, 0, -rotation);
                    left = false;
                }
            }
            else
            {
                print(Camera.main.gameObject.transform.eulerAngles.z);
                Camera.main.gameObject.transform.Rotate(0, 0, -0.1F);
                rotation = Camera.main.gameObject.transform.eulerAngles.z;
                if (rotation < 0)
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

    void crouchPlayer()
    {
        Vector3 actualSize = transform.localScale;
        if (Input.GetKeyDown(KeyCode.LeftControl) && !crouching && !running)
        {
            speed /= 2;
            transform.localScale -= new Vector3(actualSize.x / 2, actualSize.y / 2, actualSize.z / 2);
            crouching = true;
        }
            
        if (Input.GetKeyUp(KeyCode.LeftControl) && crouching)
        {
            speed *= 2;
            transform.localScale += new Vector3(actualSize.x, actualSize.y, actualSize.z);
            crouching = false;
        }
      
    }

    void runPlayer()
    {
        if (Input.GetKeyDown(KeyCode.LeftShift) && !crouching && !running)
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
