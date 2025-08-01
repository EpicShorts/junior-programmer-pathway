using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControllerPlayer2 : MonoBehaviour
{
    private float speed = 5.0f;
    private float turnSpeed = 45f;
    private float horizontalInput;
    private float forwardInput;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // Get user input
        // this system is using the old Input Manager
        //horizontalInput = Input.GetAxis("Horizontal");
        //forwardInput = Input.GetAxis("Vertical");


        // Moving the vehicle forward
        //transform.Translate(Vector3.forward*Time.deltaTime * speed * forwardInput);
        // Rotates the car 
        //transform.Rotate(Vector3.up*Time.deltaTime * turnSpeed * horizontalInput);

        // Arrow keys new system (easy mode)
        if (Keyboard.current.upArrowKey.isPressed)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed * 1);
        }
        else if (Keyboard.current.downArrowKey.isPressed)
        {
            transform.Translate(Vector3.forward * Time.deltaTime * speed * -1);
        }

        if (Keyboard.current.rightArrowKey.isPressed)
        {
            transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * 1);
        }
        else if (Keyboard.current.leftArrowKey.isPressed)
        {
            transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * -1);
        }

    }
}
