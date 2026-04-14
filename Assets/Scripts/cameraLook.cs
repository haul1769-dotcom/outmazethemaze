using UnityEngine;
using UnityEngine.InputSystem;


public class cameraLooK : MonoBehaviour
{

    public float mouseSensitivity = 100f;
    float xRotation = 0f;
    InputAction lookAction;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        lookAction = InputSystem.actions.FindAction("Look");

        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 lookInput = lookAction.ReadValue<Vector2>();
        float mouseY = lookInput.y * mouseSensitivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

       
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        

    }
}
