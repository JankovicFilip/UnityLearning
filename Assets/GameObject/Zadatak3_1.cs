using UnityEngine;
using Random = UnityEngine.Random;

public class Zadatak3_1 : MonoBehaviour
{
    public int[] numbers;

    public int creationNumber = 5;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        /*for (int i = 0; i < numbers.Length; i++)
        {
            Debug.Log(numbers[i].ToString());
        }*/

        for (int i = 0; i < creationNumber; i++)
        {
            RandomEnemyGenerator();

        }
    }

    void RandomEnemyGenerator()
    {
        int random = Random.Range(0,numbers.Length);
        Debug.Log(numbers[random].ToString());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
