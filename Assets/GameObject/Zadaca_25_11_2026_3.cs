using UnityEngine;
using UnityEngine.InputSystem;


public class Zadaca_25_11_2026_3 : MonoBehaviour
{
    public GameObject cube;

    public Key scaleUp =  Key.W;
    public Key scaleDown =  Key.S;
    public Key shutDown = Key.R;
    
    public float x = 1;
    public float y = 1;
    public float z = 1;
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cube = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        cube.transform.localScale = new Vector3(x,y,z);
        cube.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if (Keyboard.current[scaleUp].wasPressedThisFrame)
        {
            if (cube.transform.localScale.z < 5)
            {
                cube.transform.localScale += new Vector3(0, 0, 0.5f);
                if (cube.transform.localScale.z >= 5)
                {
                    cube.SetActive(false);
                }
            }
        }

        if (Keyboard.current[scaleDown].wasPressedThisFrame)
        {
            if (cube.transform.localScale.z > 0.5f)
            {
                cube.transform.localScale += new Vector3(0, 0, -0.5f);
                if (cube.transform.localScale.z <= 0.5f)
                {
                    cube.SetActive(false);
                }
            }
        }

        if (Keyboard.current[shutDown].wasPressedThisFrame)
        {
            if (Keyboard.current[scaleUp].wasPressedThisFrame)
            {
                cube.SetActive(false);    
            }
            else if (Keyboard.current[shutDown].wasPressedThisFrame)
            {
                cube.SetActive(!cube.activeSelf);
            }

        }

    }
}
