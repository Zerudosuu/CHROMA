using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorCollision : MonoBehaviour
{
    public string sameColorLayerName;
    private bool isColliding = false;

    public GameObject Color1; 
    public GameObject Color2;  
    public GameObject Color3;  

    public LayerMask Color1LayerMask;

    private EdgeCollider2D ColliderColor1; 
    private EdgeCollider2D ColliderColor2; 
    private EdgeCollider2D ColliderColor3; 

    private EdgeCollider2D owncollider;

    void Start()
    {
        
        Color1LayerMask = Color1.layer;
        Debug.Log(Color1.gameObject.layer);
        

        ColliderColor1 = Color1.GetComponent<EdgeCollider2D>(); 
        ColliderColor2 = Color2.GetComponent<EdgeCollider2D>(); 
        ColliderColor2 = Color3.GetComponent<EdgeCollider2D>(); 
        owncollider = GetComponent<EdgeCollider2D>();

        ColliderColor1.enabled = false; 
        ColliderColor2.enabled = false; 
        ColliderColor3.enabled = false; 
        

    }

    void Update()
    {
        // You can put any additional logic here if needed.
    }

    void OnCollisionEnter2D(Collision2D col)
    {
       
        // if (col.gameObject.layer == LayerMask.NameToLayer(sameColorLayerName))
        // {
        //     float thisRotationY = transform.eulerAngles.y;
        //     float otherRotationY = col.transform.eulerAngles.y;

        //     float yTolerance = 30f;

        //     if (Mathf.Abs(Mathf.DeltaAngle(thisRotationY, otherRotationY)) < yTolerance)
        //     {
        //         isColliding = true;
        //         Debug.Log("Yehey! Y-axes are facing each other.");
        //         Debug.Log("Colliding with the same color");
                
        //     }
        //     else
        //     {
        //         Debug.Log("Y-axes are not facing each other.");
                
        //     }
        // }
        // else if (col.gameObject.CompareTag("Ground"))
        // {
            
        // }
        // else
        // {
          
        //     Debug.Log("Colliding with a different color");
        // }
    }

    void OnCollisionStay2D(Collision2D col)
    {
       if (col.gameObject.layer == this.gameObject.layer) { 
            Debug.Log("Collided with same color");
        }else if(col.gameObject.layer == Color1.gameObject.layer) {
            owncollider.enabled = false;
            Debug.Log("Collision Detected for Color1");

        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        isColliding = false;
        Debug.Log("Collision Exit with: " + collision.collider.name);
    
    }
}
