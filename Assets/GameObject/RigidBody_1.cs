using System;
using UnityEngine;

public class RigidBody_1 : MonoBehaviour
{
    Rigidbody rb;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Start()
    {
        rb.useGravity = false;
        rb.AddForce(Vector3.down * 20);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
