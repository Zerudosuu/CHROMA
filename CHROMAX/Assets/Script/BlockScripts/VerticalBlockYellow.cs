using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalBlockYellow : MonoBehaviour
{
     public ObjectManagerScript block; 
    public bool isYellowAffectedByRotation = false; 
    public float YellowRotation; 

        public GameObject player;
    public bool istouchingwall; 
    Collider2D yellowCollider; 

    void Start() { 
        yellowCollider = gameObject.GetComponent<BoxCollider2D>();
   
    }
    void Update()
    {
        YellowRotation = block.YellowRotation;
      

    if (gameObject.transform.position.x + 0.5 <= player.transform.position.x)
    {
   
    if (YellowRotation == 270 || YellowRotation == 180)
    {
        yellowCollider.enabled = false;
    }
    else if (YellowRotation == 90) { 
        yellowCollider.enabled = true;
    }
    }
    else if (gameObject.transform.position.x - 0.5>= player.transform.position.x)
    {
  
    if (YellowRotation == 90 || YellowRotation == 180)
    {
        yellowCollider.enabled = false;
    }
    else if (YellowRotation == 270) // Check if YellowRotation is not 90
    {
        yellowCollider.enabled = true;
    }
    }
  

    }


    
    void OnCollisionEnter2D(Collision2D collision) { 
     if(collision.gameObject.CompareTag("Yellow")) { 
        istouchingwall = true;
     }
    }
    void OnCollisionStay2D(Collision2D collision) { 
      istouchingwall = true;
    }

    void OnCollisionExit2D(Collision2D collision) { 
        Debug.Log("OnCollisionEnter no ");
         istouchingwall = false;
       
    } 
}
