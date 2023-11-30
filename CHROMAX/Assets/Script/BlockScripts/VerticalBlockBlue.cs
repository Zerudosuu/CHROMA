using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalBlockBlue : MonoBehaviour
{
    public ObjectManagerScript block; 
    public bool isBlueAffectedByRotation = false; 
    public float BlueRotation; 

    Collider2D blueCollider; 

    void Start() { 
        blueCollider = gameObject.GetComponent<BoxCollider2D>();
    }
    void Update()
    {
        BlueRotation = block.BlueRotation;
      

      if (BlueRotation == gameObject.transform.eulerAngles.z) { 
        blueCollider.enabled = true;
    } else {
        blueCollider.enabled = false; 
    }

  

    }
}
