using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckScriptYellow : MonoBehaviour
{
    // Start is called before the first frame update
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
      

      if (YellowRotation == 90 || YellowRotation == 270 || YellowRotation == -90) { 
        yellowCollider.enabled = false;
    } else {
        yellowCollider.enabled = true; 
    }

  

    }
   


}
