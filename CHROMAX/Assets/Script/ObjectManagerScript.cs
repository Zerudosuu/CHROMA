using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectManagerScript : MonoBehaviour
{
    public BlockChecking BlockCheckingScript;
    void Start()
    {
        
    }
   
    void Update()
    {
        bool hasCollided = BlockCheckingScript.HasCollided();

       if(hasCollided) { 
        gameObject.GetComponent<BoxCollider2D>().enabled = true;
       }else 
          gameObject.GetComponent<BoxCollider2D>().enabled = true;
   
    }
}
