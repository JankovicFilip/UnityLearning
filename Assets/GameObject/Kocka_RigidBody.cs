using UnityEngine;
using UnityEngine.InputSystem;

public class Kocka_RigidBody : MonoBehaviour
{
    public Rigidbody rb;
    public Key r = Key.R;
    
    
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //rb.AddForce(transform.forward * snaga);

    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current[r].wasPressedThisFrame)
        {
            Destroy(gameObject);
            
        }
    }
}
