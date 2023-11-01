using UnityEngine;

public class RotateSprite : MonoBehaviour
{
    public float rotationSpeed = 200.0f; // Adjust the rotation speed as needed
    public bool canRotate = true; // To enable/disable rotation

    void Update()
    {
        if (canRotate)
        {
            // Rotate clockwise by 90 degrees when 'O' is pressed
            if (Input.GetKeyDown(KeyCode.O))
            {
                RotateClockwise();
            }

            // Rotate counterclockwise by 90 degrees when 'P' is pressed
            if (Input.GetKeyDown(KeyCode.P))
            {
                RotateCounterClockwise();
            }
        }
    }

    void RotateClockwise()
    {
        transform.Rotate(0, 0, -90);
    }

    void RotateCounterClockwise()
    {
        transform.Rotate(0, 0, 90);
    }
}
