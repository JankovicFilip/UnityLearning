using UnityEngine;
using UnityEngine.InputSystem;

public class Instanciranje_Zadatak_1 : MonoBehaviour
{
    public GameObject prefab;

    public Key instanciranjeSferi = Key.S;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current[instanciranjeSferi].isPressed)
        {
            for(int i = 0; i < 10; i++) 
            {
                //int random = Random.Range(0, prefab.Length); 
                Instantiate(prefab,
                    new Vector3(Random.Range(0,
                            15),
                        Random.Range(0,
                            20),
                        Random.Range(0,
                            11)),
                    Quaternion.identity);
            
            }
        }
    }
    
}
