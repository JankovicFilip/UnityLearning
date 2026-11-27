using UnityEngine;

public class Kocka : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        Collider.
        Destroy(other.gameObject);
    }

    
}
