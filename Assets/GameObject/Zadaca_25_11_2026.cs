using UnityEngine;
using UnityEngine.InputSystem;

public class Zadaca_25_11_2026 : MonoBehaviour
{
    public float x=1;
    public float y=1;
    public float z=1;
    public GameObject sfera;
    
    public Key left = Key.A;
    public Key right =  Key.D;

    public Key forward =  Key.W;
    public Key back =  Key.S;
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    { 
        sfera = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sfera.transform.position = new Vector3(x, y, z);

    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current[right].wasPressedThisFrame)
        {
            if (sfera.transform.position.x < 5)
            {
                sfera.transform.position += new Vector3(1, 0, 0);
            }
        }
        
        if (Keyboard.current[left].wasPressedThisFrame)
        {
            if (sfera.transform.position.x > -5)
            {
                sfera.transform.position += new Vector3(-1, 0, 0);
            }
        }

        if (Keyboard.current[forward].wasPressedThisFrame)
        {
            if (sfera.transform.position.z < 5)
            {
                sfera.transform.position += new Vector3(0, 0, 1);
            }
        }

        if (Keyboard.current[back].wasPressedThisFrame)
        {
            if (sfera.transform.position.z > -5)
            {
                sfera.transform.position += new Vector3(0, 0, -1);
            }
        }


        
        
        
    }
}
