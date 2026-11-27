using System;
using UnityEngine;

public class Kugla : MonoBehaviour
{
    public Vector3 smjer = new Vector3();
    public float snaga = 2000;
    Rigidbody rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Start()
    {
        rb.AddForce(transform.forward * snaga);
        
    }

    // Update is called once per frame
    
}
