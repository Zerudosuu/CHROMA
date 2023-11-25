using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalBlockGreen : MonoBehaviour
{
     public ObjectManagerScript block; 
    public bool isGreenAffectedByRotation = false; 
    public float GreenRotation; 

    Collider2D greenCollider; 

    void Start() { 
        greenCollider = gameObject.GetComponent<BoxCollider2D>();
    }
    void Update()
    {
        GreenRotation = block.RedRotation;
      

      if (GreenRotation == gameObject.transform.eulerAngles.z) { 
        greenCollider.enabled = true;
    } else {
        greenCollider.enabled = false; 
    }

  

    }
}
