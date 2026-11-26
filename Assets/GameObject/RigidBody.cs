using UnityEngine;
using UnityEngine.InputSystem;

public class RigidBody : MonoBehaviour
{
    Rigidbody rb;
    
    public float masa = 10f;
    public float force = 0.1f;
    
    public Key toggleKinematic = Key.K;
    public Key toggleGravity = Key.G;
    
    public Key left = Key.A;
    public Key right =  Key.D;
    public Key forward =  Key.W;
    public Key back =  Key.S;

    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = transform.GetComponent<Rigidbody>();
        rb.mass = masa;
        var toggleGravityStart = rb.useGravity;
        toggleGravityStart = false;
        rb.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current[toggleKinematic].wasPressedThisFrame)
        {
            rb.isKinematic = !rb.isKinematic;
        }
        if (Keyboard.current[toggleGravity].wasPressedThisFrame)
        {
            rb.useGravity = !rb.useGravity;
        }
        
        if (Keyboard.current[right].isPressed)
        {
            gameObject.transform.position += new Vector3(force, 0, 0);
        }

        if (Keyboard.current[left].isPressed)
        {
            gameObject.transform.position += new Vector3(-force, 0, 0);
        }

        if (Keyboard.current[forward].isPressed)
        {
            gameObject.transform.position += new Vector3(0, 0, force);
        }

        if (Keyboard.current[back].isPressed)
        {
            gameObject.transform.position += new Vector3(0, 0, -force);
        }
    }
}
