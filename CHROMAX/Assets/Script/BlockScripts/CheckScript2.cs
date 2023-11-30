using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckScriptGreen : MonoBehaviour
{
    // Start is called before the first frame update
     public ObjectManagerScript block; 
    public float GreenRotation; 

    Collider2D GreenCollider; 

    void Start() { 
        GreenCollider = gameObject.GetComponent<BoxCollider2D>();
    }
    void Update()
    {
        GreenRotation = block.GreenRotation;
      

      if (GreenRotation == 90 || GreenRotation == 270 || GreenRotation == -90) { 
        GreenCollider.enabled = false;
    } else {
        GreenCollider.enabled = true; 
    }

  

    }
   


}
