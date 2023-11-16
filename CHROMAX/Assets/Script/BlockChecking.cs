using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockChecking : MonoBehaviour
{

        private bool isCollided = false; 
   

        public bool HasCollided() { 
            return isCollided;
        }


        private void OnCollisionEnter2D(Collision2D collision) { 
            if(collision.gameObject.CompareTag(gameObject.tag) || collision.gameObject.CompareTag("Ground")) { 
                isCollided = true; 
                Debug.Log("Same color");
            }
            else if(!collision.gameObject.CompareTag(gameObject.tag)) {

                isCollided = false; 
                gameObject.GetComponent<PolygonCollider2D>().enabled = false; 

             }
        }


 /*
    public GameObject OwnColor; 
    public GameObject OwnObject; 

    private PolygonCollider2D OwnerColliderPolygon; 



    public GameObject Color1;
    public GameObject Color1Obj; 
    private PolygonCollider2D Color1ObjColliderPolygon;

    public GameObject Color2;
    public GameObject Color2Obj; 
    private PolygonCollider2D Color2ObjColliderPolygon;

    public GameObject Color3;
    public GameObject Color3Obj; 

    private PolygonCollider2D Color3ObjColliderPolygon;


    //BLOCKS COLLIDER
    BoxCollider2D Owncollider; 
    BoxCollider2D ColliderColor1; 
    BoxCollider2D ColliderColor2; 
    BoxCollider2D ColliderColor3; 
 
    private bool isOwnColliderEnabled = true; 

    public Transform referenceObject; 

    void Start() { 
            

            //Box Colliders of BLOCKS
            Owncollider = OwnColor.GetComponent<BoxCollider2D>();
            ColliderColor1 = Color1.GetComponent<BoxCollider2D>();
            ColliderColor2 = Color2.GetComponent<BoxCollider2D>();
            ColliderColor3 = Color3.GetComponent<BoxCollider2D>();

            // Accessing Polygon Colliders 
            OwnerColliderPolygon = OwnObject.GetComponent<PolygonCollider2D>(); 
            Color1ObjColliderPolygon = Color1Obj.GetComponent<PolygonCollider2D>(); 
            Color2ObjColliderPolygon = Color2Obj.GetComponent<PolygonCollider2D>(); 
            Color3ObjColliderPolygon = Color3Obj.GetComponent<PolygonCollider2D>(); 

           
            
          
           

    }       


    void Update() { 

       if(Input.GetKeyDown(KeyCode.P)) {
       }
    }

     void OnCollisionEnter2D(Collision2D collision){

        Debug.Log(collision.gameObject.tag);

        
    }


*/
}
