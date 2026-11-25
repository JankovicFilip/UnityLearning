using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class CubeMovement : MonoBehaviour
{
    /*public object currentObject;
    public float x;
    public float y;
    public float z;*/

    private float moveSpeed = 40f;
    private float sprintSpeed = 100f;
    private float jumpSpeed = 15f;
    private bool moveBack;
    private bool moveForward;
    private bool moveLeft;
    private bool moveRight;
    public float crouchSpeed = 10f;
    public bool fly;
    public bool sprint;
    public bool crouch;
    public bool jump;
    public bool jumpRelease;

    public Key left = Key.A;
    
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var keyboard = Keyboard.current;
        moveBack = keyboard != null && keyboard[Key.S].isPressed;
        moveForward = keyboard != null && keyboard[Key.W].isPressed;
        moveLeft = keyboard != null && keyboard[Key.A].isPressed;
        moveRight = keyboard != null && keyboard[Key.D].isPressed;
        fly = keyboard != null && keyboard[Key.Space].isPressed;
        sprint = keyboard != null && keyboard[Key.LeftShift].isPressed;
        crouch = keyboard != null && keyboard[Key.LeftCtrl].isPressed;
        jump = keyboard != null && keyboard[Key.Space].wasPressedThisFrame;
        jumpRelease =  keyboard != null && keyboard[Key.Space].wasReleasedThisFrame;







    }

    void FixedUpdate()
    {
        if (moveBack)
        {
            transform.position += -transform.forward * (moveSpeed * Time.deltaTime);
        }
        if(moveForward){
            transform.position += transform.forward * (moveSpeed * Time.deltaTime);}

        if (moveLeft)
        {
            transform.position += -transform.right * (moveSpeed * Time.deltaTime);
        }
        if (moveRight)
        {
            transform.position += transform.right * (moveSpeed * Time.deltaTime);
        }

        /*if (fly)
        {
            //transform.position = new Vector3(0,1,2);
            transform.position += transform.up * (moveSpeed * Time.deltaTime);
        }*/

        if (sprint && moveForward)
        {
                transform.position += transform.forward * (sprintSpeed * Time.deltaTime);
        }

        if (sprint && moveLeft)
        {
            transform.position += -transform.right * (sprintSpeed * Time.deltaTime);
        }
        if (sprint && moveRight)
        {
            transform.position += transform.right * (sprintSpeed * Time.deltaTime);
        }
        if (crouch && moveForward)
        {
            transform.position -= transform.forward * (crouchSpeed * Time.deltaTime);
        }

        if (crouch && moveLeft)
        {
            transform.position -= -transform.right * (crouchSpeed * Time.deltaTime);
        }
        if (crouch && moveRight)
        {
            transform.position -= transform.right * (crouchSpeed * Time.deltaTime);
        }

        if (crouch && moveBack)
        {
            transform.position -= -transform.forward * (crouchSpeed * Time.deltaTime);
        }
        if(jump && moveForward)
        {
            transform.position += transform.up * (jumpSpeed + Time.deltaTime);
        }
        else if(jumpRelease && moveForward){
            transform.position += -transform.up * (jumpSpeed + Time.deltaTime);}
            
//
        
        
        
    }
}
