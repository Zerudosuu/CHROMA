using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalBlockRed : MonoBehaviour
{
   public ObjectManagerScript block; 
    public bool isRedAffectedByRotation = false; 
    public float RedRotation; 

    Collider2D redCollider; 

    void Start() { 
        redCollider = gameObject.GetComponent<BoxCollider2D>();
    }
    void Update()
    {
        RedRotation = block.RedRotation;
      

      if (RedRotation == gameObject.transform.eulerAngles.z) { 
        redCollider.enabled = true;
    } else {
        redCollider.enabled = false; 
    }

  

    }
   
}
