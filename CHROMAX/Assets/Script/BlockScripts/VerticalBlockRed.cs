using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class VerticalBlockRed : MonoBehaviour
{
   public ObjectManagerScript block; 
   
    public bool isRedAffectedByRotation = false; 
    public float RedRotation; 

    public GameObject player;
    Collider2D redCollider; 

    void Start() { 
        redCollider = gameObject.GetComponent<BoxCollider2D>();
    }
    void Update()
    {
        RedRotation = block.RedRotation;
      

       if (player.transform.position.x  <= gameObject.transform.position.x && RedRotation == 90)
        {
            redCollider.enabled = false;
        }
        else if (player.transform.position.x  >= gameObject.transform.position.x && (RedRotation == 270 || RedRotation == -90))
        {
            redCollider.enabled = false;
        }
        else
        {
            redCollider.enabled = true;
        }


    }

  
   
}
