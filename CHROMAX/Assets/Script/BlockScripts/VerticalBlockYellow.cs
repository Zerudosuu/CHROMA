using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalBlockYellow : MonoBehaviour
{
     public ObjectManagerScript block; 
    public bool isYellowAffectedByRotation = false; 
    public float YellowRotation; 

    Collider2D yellowCollider; 

    void Start() { 
        yellowCollider = gameObject.GetComponent<BoxCollider2D>();
    }
    void Update()
    {
        YellowRotation = block.YellowRotation;
      

      if (YellowRotation == gameObject.transform.eulerAngles.z) { 
        yellowCollider.enabled = true;
    } else {
        yellowCollider.enabled = false; 
    }

  

    }
}
