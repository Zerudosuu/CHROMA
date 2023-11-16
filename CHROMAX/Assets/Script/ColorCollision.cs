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

    private EdgeCollider2D ColliderColor1; 
    private EdgeCollider2D ColliderColor2; 
    private EdgeCollider2D ColliderColor3; 

    private EdgeCollider2D owncollider;

    void Start()
    {
        ColliderColor1 = Color1.GetComponent<EdgeCollider2D>(); 
        ColliderColor2 = Color2.GetComponent<EdgeCollider2D>(); 
        ColliderColor3 = Color3.GetComponent<EdgeCollider2D>(); // Correct assignment
        owncollider = GetComponent<EdgeCollider2D>();

        ColliderColor1.enabled = false; 
        ColliderColor2.enabled = false; 
        ColliderColor3.enabled = false; 
        owncollider.enabled = true;

       
    }

    void Update()
    {
        // You can put any additional logic here if needed.
    }

    void OnCollisionEnter2D(Collision2D col)
{
    int collidedLayer = col.gameObject.layer;

    if (collidedLayer == Color1.layer || collidedLayer == Color2.layer || collidedLayer == Color3.layer)
    {
        ColliderColor1.enabled = (collidedLayer == Color1.layer);
        ColliderColor2.enabled = (collidedLayer == Color2.layer);
        ColliderColor3.enabled = (collidedLayer == Color3.layer);
        owncollider.enabled = false;
        Debug.Log("Collided with Color");
    }
    else if (collidedLayer == LayerMask.NameToLayer(sameColorLayerName))
    {
        ColliderColor1.enabled = false;
        ColliderColor2.enabled = false;
        ColliderColor3.enabled = false;
        owncollider.enabled = true;
        Debug.Log("Collided with Same Color");
    }
    else if (col.gameObject.CompareTag("Ground"))
    {

        owncollider.enabled = true;
        Debug.Log("Collided with Ground");
    }
}

    void OnCollisionExit2D(Collision2D collision)
    {
        isColliding = false;
        Debug.Log("Collision Exit with: " + collision.collider.name);
    }
}
