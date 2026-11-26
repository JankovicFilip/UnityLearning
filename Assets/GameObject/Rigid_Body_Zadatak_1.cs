using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class Rigid_Body_Zadatak_1 : MonoBehaviour
{
    public Rigidbody rb;
    public Key unlock = Key.U;
    public Key lockIn = Key.F;
    public Key toggle = Key.Space;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();

    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb.useGravity = false;
        rb.constraints = RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezeRotationZ;
        rb.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezePositionX | RigidbodyConstraints.FreezePositionY;
        rb.AddExplosionForce(200,transform.position,1000);


    }

    // Update is called once per frame
    void Update()
    {
        rb.AddExplosionForce(200,transform.position,1000);

        //gameObject.transform.Rotate(Vector3.right, 15f);
        
        rb.AddForce(Vector3.right);

        if (Keyboard.current[unlock].wasPressedThisFrame)
        {
            rb.constraints = RigidbodyConstraints.None;
            
        }

        if (Keyboard.current[lockIn].wasPressedThisFrame)
        {
            rb.constraints = RigidbodyConstraints.FreezeAll;
        }

        if (Keyboard.current[toggle].wasPressedThisFrame)
        {
            if (!rb.useGravity)
            {
                rb.useGravity = true;
            }
            else
            {
                rb.useGravity = false;
            }

        }
    }
}
