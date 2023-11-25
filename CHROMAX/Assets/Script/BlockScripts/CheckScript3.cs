using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckScriptRed: MonoBehaviour
{
    // Start is called before the first frame update
     public ObjectManagerScript block; 
    public bool isRedAffectedbyRotation = false; 
    public float RedRotation; 

    Collider2D RedCollider; 

    void Start() { 
        RedCollider = gameObject.GetComponent<BoxCollider2D>();
    }
    void Update()
    {
        RedRotation = block.RedRotation;
      

      if (RedRotation == 90 || RedRotation == 270 || RedRotation == -90) { 
        RedCollider.enabled = false;
    } else {
        RedCollider.enabled = true; 
    }

  

    }
   


}
