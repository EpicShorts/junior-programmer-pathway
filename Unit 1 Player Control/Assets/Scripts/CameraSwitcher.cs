using UnityEngine;
using UnityEngine.InputSystem;

public class CameraSwitcher : MonoBehaviour
{
    public GameObject mainCamera;
    public GameObject carCamera;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            // when space is pressed
            mainCamera.SetActive(!mainCamera.activeSelf);
            carCamera.SetActive(!carCamera.activeSelf);
        }
    }

    
}
