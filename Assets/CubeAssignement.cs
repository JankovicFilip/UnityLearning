using UnityEngine;

public class CubeAssignement : MonoBehaviour
{
    public float minSize = 0.1f;
    public float maxSize = 10f;
    public float rotationSpeed = 30f;

    public float speedOfGrowth = 20f;
    public float startingSize = 1f;
    public bool enlargement = true;
    
    
    
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.localScale = new Vector3(startingSize, startingSize, startingSize);
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (enlargement)
        {
            startingSize += speedOfGrowth * Time.deltaTime;
            if (startingSize >= maxSize)
            {
                startingSize = maxSize;
                enlargement = false;
            }
        }
        else
        {
            startingSize -= speedOfGrowth * Time.deltaTime;
            if (startingSize <= minSize)
            {
                startingSize = minSize;
                enlargement = true;
            }
        }
        transform.localScale = new Vector3(startingSize, startingSize, startingSize);
        transform.Rotate(rotationSpeed * Time.deltaTime,rotationSpeed * Time.deltaTime,rotationSpeed * Time.deltaTime);
        
    }
}
