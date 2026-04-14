using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerMovement : MonoBehaviour
{
    InputAction moveAction;
    public float moveSpeed = 5f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
     moveAction = InputSystem.actions.FindAction("Move");


    }

    // Update is called once per frame
    void Update()
    {
        
     Vector2 moveInput = moveAction.ReadValue<Vector2>();
     Vector3 movement = new Vector3(moveInput.x, 0f, moveInput.y) * moveSpeed * Time.deltaTime;
     transform.Translate(movement);



    }
}
