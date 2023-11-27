using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Script4 : MonoBehaviour
{
    public bool isCollidingWithOwnColor = false;
    public float rotationZ;

    private Collider2D owncollider;

    public GameObject GreenBlock; 

    
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

         if(gameObject.transform.position.x < GreenBlock.transform.position.x && rotationZ == 90 ) {
            owncollider.enabled = false; 
        } else { 
             owncollider.enabled = true;
        }

        if(gameObject.transform.position.x > GreenBlock.transform.position.x && rotationZ == 270 || rotationZ == -90 ) { 
             owncollider.enabled = false; 
        }else { 
             owncollider.enabled = true;
        }


    }

   void OnCollisionEnter2D(Collision2D collision) { 
    float collisionRotation = collision.gameObject.transform.rotation.eulerAngles.z;
    
    if(rotationZ == 90) { 
        owncollider.enabled = false;
        Debug.Log("yeeha");
    
    } else { 
        if((collision.gameObject.layer == gameObject.layer) && (Mathf.Approximately(collisionRotation, 0f)) ) {
            isCollidingWithOwnColor = true;
            Debug.Log("Collision Detected");
        }
    }
}



    void OnCollisionExit2D(Collision2D collision) { 
        isCollidingWithOwnColor = false;
        owncollider.enabled = true; 
    }
}
