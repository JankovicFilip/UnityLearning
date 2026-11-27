using UnityEngine;
using UnityEngine.InputSystem;

public class Instanciranje_Zadatak_2 : MonoBehaviour
{
    public GameObject top;
    public Key space = Key.Space;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        top = GameObject.CreatePrimitive(PrimitiveType.Cube);
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current[space].wasPressedThisFrame)
        {
            Instantiate(top, transform.position, transform.rotation);
            
        }
        
    }
}
