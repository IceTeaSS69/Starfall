using System.Data;
using NUnit.Framework.Internal;
using UnityEngine;

public class CoinScript : MonoBehaviour
{
  
    public GameObject circlePrefab; 
    public int numberOfCircles = 18; 
    public float spawnRadius = 18f;
    public float spawnInterval = 4f; 
    private float nextSpawnTime;
    

    void Start()
    {
        nextSpawnTime = Time.time;
               
    }

    void Update()
    {
        if (Time.time >= nextSpawnTime)
        {
            SpawnCircles();
            nextSpawnTime = Time.time + spawnInterval;
        }
      
    }

   

    void SpawnCircles()
    {
        for (int i = 0; i < numberOfCircles; i++)
        {
            
            Vector2 randomPos = Random.insideUnitCircle * spawnRadius;
            
            Vector3 spawnPosition = transform.position + (Vector3)randomPos;

           
            Instantiate(circlePrefab, spawnPosition, Quaternion.identity);
        }

    }
}
