using UnityEngine;

public class Zadatal2_2 : MonoBehaviour
{
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        for (int i = 0; i <= 4 ; i++)
        {
            GameObject cubes = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cubes.transform.position = Vector3.left * i * 2;
            cubes.AddComponent<MovementTwo>();
            cubes.transform.name = "Cube" + i;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
