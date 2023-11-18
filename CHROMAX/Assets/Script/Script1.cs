using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Script1 : MonoBehaviour
{
    public bool isCollidingWithOwnColor = false;
    public float rotationZ;

    private Collider2D owncollider;

    
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
        
        if(collision.gameObject.layer == gameObject.layer) {
            isCollidingWithOwnColor = true;
        }

       if ((Mathf.Approximately(collisionRotation, 0f)) && (Mathf.Approximately(rotationZ, 270f) || Mathf.Approximately(rotationZ, 90f)))
       {
             owncollider.enabled = false;
        }


    }


    void OnCollisionExit2D(Collision2D collision) { 
        isCollidingWithOwnColor = false;
        owncollider.enabled = true; 
    }
}
