using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerController : MonoBehaviour
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
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");


        // Moving the vehicle forward
        transform.Translate(Vector3.forward*Time.deltaTime * speed * forwardInput);
        // Rotates the car 
        transform.Rotate(Vector3.up*Time.deltaTime * turnSpeed * horizontalInput);
    }
}
