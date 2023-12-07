using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class PlatformScript : MonoBehaviour
{
   public float jumpForce = 10f; 
   public float distanceBelowCamera = 5f;

   private Camera maincamera;

   void Start() { 
      maincamera = Camera.main;
   }

   private void OnCollisionEnter2D(Collision2D collision) { 
    if(collision.relativeVelocity.y <= 0f) { 
        Rigidbody2D rb = collision.gameObject.GetComponent<Rigidbody2D>();

        if(rb != null) {
            Vector2 velocity = rb.velocity;
            velocity.y = jumpForce; 
            rb.velocity = velocity;
         } 
    }
   }

   void Update() { 

       float destroyY = maincamera.transform.position.y - distanceBelowCamera;
       
      if(transform.position.y < destroyY) { 
        gameObject.SetActive(false);
      }
   }
}
