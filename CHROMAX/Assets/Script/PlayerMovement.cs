using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float horizontal;
    private float speed = 8f;
    private float jumpPower = 16f;
    private bool isGrounded = false;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private string groundTag = "Ground"; 

    private void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");

      
        Collider2D[] colliders = Physics2D.OverlapCircleAll(groundCheck.position, 0.1f);
        isGrounded = false;
        for (int i = 0; i < colliders.Length; i++)
        {
            if (colliders[i].gameObject != gameObject && colliders[i].gameObject.CompareTag(groundTag))
            {
                isGrounded = true;
                break;
            }
        }

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
          
            rb.velocity = new Vector2(rb.velocity.x, jumpPower);
        }

       
        if (Input.GetButtonUp("Jump") && rb.velocity.y > 0f)
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
        }
    }

    private void FixedUpdate()
    {
       
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
    }
}
