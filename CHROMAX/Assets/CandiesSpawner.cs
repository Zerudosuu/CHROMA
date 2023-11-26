using System.Collections;
using UnityEngine;

public class ObjectDropperAboveCamera : MonoBehaviour
{
    public GameObject[] objectsToDrop; // Array of object prefabs to drop
    public float dropHeight = 20f; // Height above the camera to drop objects from
    public float minDropInterval = 2f; // Minimum time between drops
    public float maxDropInterval = 5f; // Maximum time between drops
    public float minXPosition = -5f; // Minimum X position
    public float maxXPosition = 5f; // Maximum X position

    private Camera mainCamera;

    void Start()
    {
        mainCamera = Camera.main;
        StartCoroutine(DropObjects());
    }

    IEnumerator DropObjects()
    {
        while (true)
        {
            // Get random position above the camera
            Vector3 dropPosition = GetRandomDropPosition();

            // Get a random object from the objectsToDrop array
            int randomIndex = Random.Range(0, objectsToDrop.Length);
            GameObject objectPrefab = objectsToDrop[randomIndex];

            // Instantiate the selected object at the calculated position
            GameObject droppedObject = Instantiate(objectPrefab, dropPosition, Quaternion.identity);

            // Wait for a random interval before dropping the next object
            yield return new WaitForSeconds(Random.Range(minDropInterval, maxDropInterval));
        }
    }

    Vector3 GetRandomDropPosition()
    {
        // Get current camera position
        Vector3 cameraPosition = mainCamera.transform.position;

        // Calculate random position above the camera within dropHeight
        Vector3 dropOffset = Vector3.up * dropHeight;
        Vector3 randomDropPosition = cameraPosition + dropOffset;

        // Randomize X position within minXPosition and maxXPosition
        randomDropPosition.x = Random.Range(minXPosition, maxXPosition);

        return randomDropPosition;
    }
}
