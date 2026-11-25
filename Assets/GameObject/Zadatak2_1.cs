using UnityEngine;
using UnityEngine.InputSystem;

public class Zadatak2_1 : MonoBehaviour
{
    public GameObject targetObject;
    //GameObject djuro;
    public bool isActive = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Keyboard.current[Key.S].wasPressedThisFrame)
        {
            isActive = !isActive;
            //targetObject.SetActive(isActive);
            Destroy(targetObject, 5);
        }
        /*if (objekt == false)
        {
            objekt = true;
            mojObjekt.SetActive(true);
        }
        else
        {
            objekt = false;
            mojObjekt.SetActive(false);
        }*/
        /*if (objekt == false)
        {
            objekt = true;
            targetObject.SetActive(true);
        }
        else
        {
            objekt = false;
            targetObject.SetActive(false);
        }*/

        
    }
}
