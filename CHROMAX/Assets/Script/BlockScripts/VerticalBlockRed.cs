using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class VerticalBlockRed : MonoBehaviour
{
   public ObjectManagerScript block; 
    public float RedRotation; 
    public GameObject player;
    Collider2D redCollider; 
public  float collisionMargin = 0.1f;

public bool istouchingwall; 

    void Start() { 
        redCollider = gameObject.GetComponent<BoxCollider2D>();

    }
   void Update()
{
    RedRotation = block.RedRotation;


if (gameObject.transform.position.x + 0.5 <= player.transform.position.x)
{
    
    if (RedRotation == 270 || RedRotation == 180)
    {
        redCollider.enabled = false;
    }
    else if (RedRotation  == 90) 
    {
        redCollider.enabled = true;
    }
}
else if (gameObject.transform.position.x - 0.5>= player.transform.position.x)
{
   
    if (RedRotation == 90 || RedRotation == 180)
    {
        redCollider.enabled = false;
    }
    else if (RedRotation == 270) 
    {
        redCollider.enabled = true;
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