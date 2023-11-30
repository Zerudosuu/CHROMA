using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checking : MonoBehaviour
{

    public string tagname;
    public GameObject obj; 
    Collider2D col; 
    // Start is called before the first frame update
    void Start()
    {

        col = GetComponent<BoxCollider2D>();
        Debug.Log(obj.tag);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

  private void OnCollisionEnter2D(Collision2D collision)
{
    if (collision.gameObject.CompareTag(obj.tag))
    {
        Debug.Log("Collided with Red");
        col.enabled = true; 
    }
    else
    {
        Debug.Log("Collided with other color");
        col.enabled = false;
    }
}

}
