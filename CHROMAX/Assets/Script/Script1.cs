using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Script1 : MonoBehaviour
{
    public bool isCollidingWithOwnColor = false;
    public float rotationZ;
    private Collider2D owncollider;

   public bool istouchingwall; 

    
    void Start()
    {
        owncollider = GetComponent<EdgeCollider2D>();
    }

    void Update()
    {
         rotationZ = transform.rotation.eulerAngles.z;

        if(rotationZ == 0 || rotationZ == 360) { 
            owncollider.enabled = false;
        }else { 
             owncollider.enabled = true;
        }
     


    }

   void OnCollisionEnter2D(Collision2D collision) { 
    float collisionRotation = collision.gameObject.transform.rotation.eulerAngles.z;
  
        if((collision.gameObject.layer == gameObject.layer) && (Mathf.Approximately(collisionRotation, 0f)) ) {
            isCollidingWithOwnColor = true;
            Debug.Log("Collision Detected");
        }


        if(rotationZ == 90 || rotationZ == 270) { 
            if(collision.gameObject.CompareTag("Ground") || collision.gameObject.layer == gameObject.layer) { 
                  istouchingwall = true; 
            }
            else { 
                istouchingwall = false;
            }
        }
        
    
    
}   
   

    void OnCollisionExit2D(Collision2D collision) { 
        isCollidingWithOwnColor = false;
        owncollider.enabled = true;
         istouchingwall = false;
 
    }
}
