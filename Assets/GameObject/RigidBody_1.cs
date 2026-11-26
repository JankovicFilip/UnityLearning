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
        /*rb.useGravity = false;
        rb.AddForce(Vector3.down);
        rb.AddExplosionForce(2000,transform.position,2);
        */
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    
    // “other” refers to the collider on the GameObject inside this trigger
    void OnTriggerEnter (Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            Debug.Log (other.gameObject.name);
        }
        Debug.Log ("A collider has entered the DoorObject trigger");
    }

    void OnTriggerStay (Collider other)
    {
        Debug.Log ("A collider is inside the DoorObject trigger");
    }
    
    void OnTriggerExit (Collider other)
    {
        Debug.Log ("A collider has exited the DoorObject trigger");
    }
    
    
    
    // “other” refers to the collider that is touching this collider
    void OnCollisionEnter (Collision other)
    {
        Debug.Log ("A collider has made contact with the DoorObject Collider");
    }

    void OnCollisionStay (Collision other)
    {
        Debug.Log ("A collider is in contact with the DoorObject Collider");
    }
    
    void OnCollisionExit (Collision other)
    {
        Debug.Log ("A collider has ceased contact with the DoorObject Collider");
    }
}
