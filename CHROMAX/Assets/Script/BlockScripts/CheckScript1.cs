using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckScriptBlue : MonoBehaviour
{
    
    public ObjectManagerScript block; 
    public bool isYellowAffectedByRotation = false; 
    public float BlueRotation; 

    Collider2D Bluecollider; 

    void Start() { 
        Bluecollider = gameObject.GetComponent<BoxCollider2D>();
    }
    void Update()
    {
        BlueRotation = block.BlueRotation;
      

      if (BlueRotation == 90 || BlueRotation == 270 || BlueRotation == -90) { 
        Bluecollider.enabled = false;
    } else {
        Bluecollider.enabled = true; 
    }

  

    }
   


}
