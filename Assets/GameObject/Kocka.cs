using UnityEngine;

public class Kocka : MonoBehaviour
{
    public int counter;

    void OnTriggerEnter(Collider other)
    {
        counter++;
        Debug.Log(counter);
        Destroy(other.gameObject);
    }

    
}
