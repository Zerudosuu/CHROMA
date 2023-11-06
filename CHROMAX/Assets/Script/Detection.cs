using System.Collections;
using System.Collections.Generic;
using UnityEngine;

 
public class Detection : MonoBehaviour
{
    // Start is called before the first frame update

    public float distance;
    Rigidbody2D rb;
    void Start() { 
    rb = GetComponent<Rigidbody2D>();
    }


    // Update is called once per frame
    void Update()
    {

        int layerMask = 1 << 8;
        layerMask = ~layerMask;

        RaycastHit2D hitdown = Physics2D.Raycast(transform.position, -transform.up, distance, layerMask);

        if(hitdown.collider != null) { 
            Debug.Log(hitdown.collider.gameObject.layer);
        }


          RaycastHit2D hitright = Physics2D.Raycast(transform.position, transform.right, distance, layerMask);
          RaycastHit2D hitleft = Physics2D.Raycast(transform.position, -transform.right, distance, layerMask);

         if(hitright.collider != null) { 
          Debug.Log(hitright.collider.gameObject.layer);
        }

         if(hitleft.collider != null) { 
           Debug.Log(hitleft.collider.gameObject.layer);
        }
    }
}
