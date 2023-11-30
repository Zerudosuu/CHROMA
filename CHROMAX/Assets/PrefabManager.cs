using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabManager : MonoBehaviour
{
    public ObjectManagerScript objectManager; // Reference to your ObjectManagerScript

    // Reference to the instantiated prefab and its associated ObjectManagerScript
    private Dictionary<GameObject, ObjectManagerScript> prefabObjectMap = new Dictionary<GameObject, ObjectManagerScript>();

    // Update is called once per frame
    void Update()
    {
        // Iterate through each prefab and update collider state based on ObjectManagerScript values
        foreach (var pair in prefabObjectMap)
        {
            GameObject prefab = pair.Key;
            ObjectManagerScript prefabObjectManager = pair.Value;

            if (prefabObjectManager != null)
            {
                Collider2D prefabCollider = prefab.GetComponent<Collider2D>();
                if (prefabObjectManager.blockcheck.rotationValueRed == 90 || prefabObjectManager.blockcheck.rotationValueRed == 270 || prefabObjectManager.blockcheck.rotationValueRed == -90)
                {
                    prefabCollider.enabled = false;
                }
                else
                {
                    prefabCollider.enabled = true;
                }
            }
        }
    }

    // Function to manage prefab behavior when instantiated
    public void ManagePrefab(GameObject prefab)
    {
        ObjectManagerScript prefabObjectManager = prefab.GetComponent<ObjectManagerScript>();
        if (prefabObjectManager != null && !prefabObjectMap.ContainsKey(prefab))
        {
            prefabObjectMap.Add(prefab, prefabObjectManager);
        }
    }
}
