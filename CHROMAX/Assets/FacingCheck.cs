using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FacingCheck : MonoBehaviour
{
    public Transform object1; // Assign the first object's transform
    public Transform object2; // Assign the second object's transform

    // Update is called once per frame
    void Update()
    {
        // Calculate the direction from object1 to object2
        Vector3 direction = object2.position - object1.position;

        // Normalize the direction vector to get a unit vector
        direction.Normalize();

        // Calculate the dot product between the Y-axis and the direction vector
        float dotProduct = Vector3.Dot(direction, Vector3.up);

        // Check if the objects are facing each other along the Y-axis
        if (Mathf.Approximately(dotProduct, 1f) || Mathf.Approximately(dotProduct, -1f))
        {
            Debug.Log("Objects are facing each other along the Y-axis!");
        }
        else
        {
            Debug.Log("Objects are not facing each other along the Y-axis.");
        }
    }
}
