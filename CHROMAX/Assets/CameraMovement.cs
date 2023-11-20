using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    [SerializeField] private Transform player;
    public float xOffset;
    public float yOffset;
    public float offsetSmoothing;

    private Vector3 velocity = Vector3.zero;

    void Start()
    {
        // Set the initial camera position including the desired Z offset
        transform.position = new Vector3(transform.position.x, transform.position.y, -20f);
    }

    void LateUpdate()
    {
        // Get the position of the player
        Vector3 playerPosition = player.position;

        // Calculate target position with offsets
        Vector3 targetPosition = playerPosition + new Vector3(xOffset, yOffset, -10f); // Set Z to -10

        // Smoothly move the camera towards the target position using SmoothDamp
        Vector3 smoothedPosition = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, offsetSmoothing);

        // Update the camera's position
        transform.position = smoothedPosition;
    }
}
