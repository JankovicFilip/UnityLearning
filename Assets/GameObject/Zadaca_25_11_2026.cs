using UnityEngine;
using UnityEngine.InputSystem;

public class Zadaca_25_11_2026 : MonoBehaviour
{
    public float x=1;
    public float y=1;
    public float z=1;
    public float moveSpeed = 1f;
    
    public Key left = Key.A;
    public Key right =  Key.D;

    public Key forward =  Key.W;
    public Key back =  Key.S;
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameObject sfera = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sfera.transform.position = new Vector3(x, y, z);
        

    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current[right].isPressed)
        {
            gameObject.transform.position += new Vector3(0, 0, moveSpeed);
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


        
        
        
    }
}
