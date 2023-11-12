using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorCollision : MonoBehaviour
{
    public string sameColorLayerName; // Set this in the Inspector
    private bool isColliding = false;

    
    void Update()
    {
        if (isColliding)
        {
            Debug.Log("Object is currently colliding");
        }
         
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        //  Debug.Log(transform.name+" " +transform.rotation.y);
        if (col.gameObject.layer == LayerMask.NameToLayer(sameColorLayerName))
        {
              // Access the y-axis positions of both colliders
            float thisY = transform.position.y;
            float otherY = col.transform.position.y;

        // Check if the y-axes are facing each other (within some tolerance)
            float yTolerance = 0.1f; // Tolerance for facing each other

            if (!(Mathf.Abs(thisY - otherY) < yTolerance))
        {
            Debug.Log("Yehey! Y-axes are not facing each other." + LayerMask.NameToLayer(sameColorLayerName) + "and" + sameColorLayerName);
        }
            isColliding = true;
            Debug.Log("Colliding with the same color");
        }
        else
        {
            Debug.Log("Colliding with a different color");
        }
    }

    void OnCollisionStay(Collision collision)
    {
        Debug.Log("Colliding with: " + collision.collider.name);
    }

    void OnCollisionExit(Collision collision)
    {
        isColliding = false;
        Debug.Log("Collision Exit with: " + collision.collider.name);
    }
}