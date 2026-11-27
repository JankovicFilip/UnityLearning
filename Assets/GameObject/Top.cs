using UnityEngine;
using UnityEngine.InputSystem;

public class Top : MonoBehaviour
{
    public GameObject kugla;
    public Key shoot = Key.Space;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current[shoot].wasPressedThisFrame)
        {
            Instantiate(kugla, transform.position, transform.rotation);
        }
    }
}
