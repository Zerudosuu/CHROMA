using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    [SerializeField] private Transform player;
    public float xOffset;
    public float yOffset;
    public float offsetSmoothing;
    public float ySmoothing;
    public float minY;
    public float maxY;
    public float minX;
    public float maxX;

    private Vector3 velocity = Vector3.zero;
    private bool followPlayer = true;

    void LateUpdate()
    {
        // Check if the camera should follow the player
        if (!followPlayer)
            return;

        // Get the position of the player
        Vector3 playerPosition = player.position;

        // Calculate target position with offsets
        Vector3 targetPosition = playerPosition + new Vector3(xOffset, yOffset, transform.position.z); // Maintain the camera's Z position

        // Check if the player is within the X-axis boundaries
        if (playerPosition.x >= minX && playerPosition.x <= maxX)
        {
            // Smoothly move the camera towards the target position using SmoothDamp
            Vector3 smoothedPosition = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, offsetSmoothing);

            // Clamp the camera's Y position
            smoothedPosition.y = Mathf.Clamp(smoothedPosition.y, minY, maxY);

            // Update the camera's position
            transform.position = smoothedPosition;
        }
        else
        {
            // Player is beyond X-axis boundaries, stop following
            followPlayer = false;
        }
    }
}
