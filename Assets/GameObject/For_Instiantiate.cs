using Unity.Burst.CompilerServices;
using UnityEngine;
using UnityEngine.InputSystem;

public class For_Instiantiate : MonoBehaviour
{
    public GameObject prvaPloca;
    public GameObject plocica;



    public Key instantiateObject = Key.R;
    public Key movePrvaPloca = Key.S;


    void PostaviPlocice()
    {
        for (int i = 0; i < 15; i++)
        {
            Vector3 pos = new Vector3(i*1, 1, 0);
            GameObject tempPloca = Instantiate(plocica,pos, Quaternion.identity);
            if (i == 0)
            {
                prvaPloca = tempPloca;
            }
            
        }
        
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        PostaviPlocice();
        /*Instantiate(prvaPloca, new Vect3(-3, -3, 0), Quaternion.identity);
        prvaPloca.transform.localScale = new Vector3(0.5f, 7, 3);

        plocica.transform.SetLocalPositionAndRotation(new Vector3(11,22,11), Quaternion.identity);
        for (int i = 0; i < 15; i++)
        {
            Instantiate(plocica, new Vector3(i*3f,0,0), Quaternion.identity);
            plocica.transform.localScale = new Vector3(0.5f, 7, 3);
        }*/
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current[movePrvaPloca].wasPressedThisFrame)
        {
            prvaPloca.GetComponent<Rigidbody>().AddForce(Vector3.right * 1500);
                
        }

        if (Keyboard.current[instantiateObject].wasPressedThisFrame)
        {
            PostaviPlocice();
            
        }
        
    }
}
