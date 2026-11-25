using UnityEngine;
using UnityEngine.InputSystem;

public class MovementTwo : MonoBehaviour
{
    public float moveSpeed = 1f;
    public float sprintSpeed = 2f;
    public float crouchSpeed = 0.5f;
    
    public Key left = Key.A;
    public Key right =  Key.D;

    public Key forward =  Key.W;
    public Key back =  Key.S;

    public Key sprint = Key.LeftShift;
     public Key crouch = Key.LeftCtrl;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current[right].isPressed)
        {
            gameObject.transform.position += new Vector3(moveSpeed, 0, 0);
        }

        if (Keyboard.current[left].isPressed)
        {
            gameObject.transform.position += new Vector3(-moveSpeed, 0, 0);
        }

        if (Keyboard.current[forward].isPressed)
        {
            gameObject.transform.position += new Vector3(0, 0, moveSpeed);
        }

        if (Keyboard.current[back].isPressed)
        {
            gameObject.transform.position += new Vector3(0, 0, -moveSpeed);
        }

        
        if (Keyboard.current[sprint].isPressed && Keyboard.current[back].isPressed)
        {
            gameObject.transform.position += new Vector3(0, 0, -sprintSpeed);
        }
        
        if (Keyboard.current[sprint].isPressed && Keyboard.current[forward].isPressed)
        {
            gameObject.transform.position += new Vector3(0, 0, sprintSpeed);
        }
        
        if (Keyboard.current[sprint].isPressed && Keyboard.current[left].isPressed)
        {
            gameObject.transform.position += new Vector3(-sprintSpeed, 0, 0);
        }
        
        if (Keyboard.current[sprint].isPressed && Keyboard.current[right].isPressed)
        {
            gameObject.transform.position += new Vector3(sprintSpeed, 0, 0);
        }
        
        if (Keyboard.current[crouch].isPressed && Keyboard.current[back].isPressed)
        {
            //moveSpeed = crouchSpeed;
            gameObject.transform.position += new Vector3(0, 0, -crouchSpeed);
        }
        
        if (Keyboard.current[crouch].isPressed && Keyboard.current[forward].isPressed)
        {
            gameObject.transform.position += new Vector3(0, 0, crouchSpeed);
        }
        
        if (Keyboard.current[crouch].isPressed && Keyboard.current[left].isPressed)
        {
            gameObject.transform.position += new Vector3(-crouchSpeed, 0, 0);
        }
        
        if (Keyboard.current[crouch].isPressed && Keyboard.current[right].isPressed)
        {
            gameObject.transform.position += new Vector3(crouchSpeed, 0, 0);
        }
    }
}
