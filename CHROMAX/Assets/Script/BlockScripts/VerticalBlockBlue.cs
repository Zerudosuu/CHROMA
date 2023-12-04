using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalBlockBlue : MonoBehaviour
{
    public ObjectManagerScript block; 
    public float BlueRotation; 
    public GameObject player;

 public bool istouchingwall; 
    Collider2D blueCollider; 

    void Start() { 
        blueCollider = gameObject.GetComponent<BoxCollider2D>();
    }
    void Update()
    {
        BlueRotation = block.BlueRotation;
      

if (gameObject.transform.position.x + 0.5 <= player.transform.position.x)
{
   
    if (BlueRotation == 270 || BlueRotation == 180)
    {
        blueCollider.enabled = false;
    }
    else if (BlueRotation != 270) // Check if BlueRotation is not 270
    {
        blueCollider.enabled = true;
    }
}
else if (gameObject.transform.position.x - 0.5>= player.transform.position.x)
{
    
    if (BlueRotation == 90 || BlueRotation == 180)
    {
        blueCollider.enabled = false;
    }
    else if (BlueRotation != 90) // Check if BlueRotation is not 90
    {
        blueCollider.enabled = true;
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
