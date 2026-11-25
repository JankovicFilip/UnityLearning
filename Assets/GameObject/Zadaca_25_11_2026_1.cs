using UnityEngine;
using UnityEngine.InputSystem;

public class Zadaca_25_11_2026_1 : MonoBehaviour
{
    public float x = 1f;
    public float y = 1f;
    public float z = 1f;
  
   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
        for (int i = 0; i <= 10 ; i++)
        {
            GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube.transform.position = Vector3.right * i * 1.5f;
            cube.transform.localScale = new Vector3(x, y, z);
            x+=0.3f;
            y+=0.3f;
            z+=0.3f;
            cube.AddComponent<MovementTwo>();
            cube.transform.name = "Cube" + i;
        }
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
