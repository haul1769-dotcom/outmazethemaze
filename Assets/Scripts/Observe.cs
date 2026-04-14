using UnityEngine;
using UnityEngine.InputSystem;


public class mouseLook : MonoBehaviour
{

    public float mouseSensitivity = 100f;
    float yRotation = 0f;
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
        float mouseX = lookInput.x * mouseSensitivity * Time.deltaTime;
       

        yRotation += mouseX;
        yRotation = Mathf.Clamp(yRotation, -360f, 360f);

        transform.localRotation = Quaternion.Euler(0f, yRotation, 0f);
        

    }
}
