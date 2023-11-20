using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlatform : MonoBehaviour
{
    public GameObject[] platformPrefabs;
    public int spawnCount = 300; 

    void Start()
    {
        if (platformPrefabs.Length == 0)
        {
            Debug.LogWarning("No platform prefabs assigned.");
            return;
        }

        for (int i = 0; i < spawnCount; i++)
        {
            Vector3 spawnPosition = new Vector3();
            spawnPosition.y = Random.Range(.5f, 2f) * i; // Vary the y position based on the index
            spawnPosition.x = Random.Range(-5f, 5f);

            // Randomly select a prefab from the platformPrefabs array
            int randomIndex = Random.Range(0, platformPrefabs.Length);
            GameObject prefabToSpawn = platformPrefabs[randomIndex];

            // Instantiate the selected prefab at the random position
            Instantiate(prefabToSpawn, spawnPosition, Quaternion.identity);
        }
    }

    void Update() { 
        
    }
}
