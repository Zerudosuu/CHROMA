using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalBlockGreen : MonoBehaviour
{
     public ObjectManagerScript block; 

     
    public bool isGreenAffectedByRotation = false; 
    public float GreenRotation; 

        public GameObject player;

     public bool istouchingwall; 
    Collider2D greenCollider; 

    void Start() { 
        greenCollider = gameObject.GetComponent<BoxCollider2D>();
    }
    void Update()
    {
        GreenRotation = block.GreenRotation;
      

if (gameObject.transform.position.x + 0.5 <= player.transform.position.x)
{
   
    if (GreenRotation == 270 || GreenRotation == 180)
    {
        greenCollider.enabled = false;
    }
    else if (GreenRotation != 270) 
    {
        greenCollider.enabled = true;
    }
}
else if (gameObject.transform.position.x - 0.5>= player.transform.position.x)
{
 
    if (GreenRotation == 90 || GreenRotation == 180)
    {
        greenCollider.enabled = false;
    }
    else if (GreenRotation != 90) 
    {
        greenCollider.enabled = true;
    }
}

    }

      void OnCollisionEnter2D(Collision2D collision) { 
          Debug.Log("OnCollisionEnter yes");
           istouchingwall = true;
    }
    void OnCollisionStay2D(Collision2D collision) { 
      istouchingwall = true;
    }

    void OnCollisionExit2D(Collision2D collision) { 
        Debug.Log("OnCollisionEnter no ");
         istouchingwall = false;
       
    } 
}
