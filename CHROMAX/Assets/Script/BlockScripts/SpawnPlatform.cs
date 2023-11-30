using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPlatform : MonoBehaviour
{
    public GameObject[] platformPrefabs;
    public int spawnCount = 300; 
    public float maxHeight = 50f; 
    public float minDistanceBetweenPlatforms = 1.0f;

    private List<Vector3> spawnedPositions = new List<Vector3>();

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
            spawnPosition.y = Random.Range(.5f, 2f) * i; 
            spawnPosition.x = Random.Range(-5f, 5f);

            if (!IsOverlapping(spawnPosition) && spawnPosition.y <= maxHeight)
            {
                int randomIndex = Random.Range(0, platformPrefabs.Length);
                GameObject prefabToSpawn = platformPrefabs[randomIndex];

                GameObject spawnedPrefab = Instantiate(prefabToSpawn, spawnPosition, Quaternion.identity);

                // Access the PlatformMovementScript component of the spawned platform
                PlatformMovementScript movementScript = spawnedPrefab.GetComponent<PlatformMovementScript>();

                if (movementScript != null)
                {
                    // Modify the properties of the PlatformMovementScript for randomness
                    movementScript.speed = Random.Range(1.0f, 3.0f); // Example: Randomize speed
                    // You can add more randomizations here for different properties
                }

                spawnedPositions.Add(spawnPosition); 
            }
        }
    }

    bool IsOverlapping(Vector3 position)
    {
        foreach (Vector3 spawnedPos in spawnedPositions)
        {
            if (Vector3.Distance(position, spawnedPos) < minDistanceBetweenPlatforms)
            {
                return true;
            }
        }
        return false;
    }

    void Update() { }
}
