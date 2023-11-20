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
    [SerializeField] private string groundTag = "Ground"; // Define the ground tag here

    private void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");

        // Check if the player is grounded using tags
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
            // Jump only if grounded
            rb.velocity = new Vector2(rb.velocity.x, jumpPower);
        }

        // Reduce jump height if the jump button is released early
        if (Input.GetButtonUp("Jump") && rb.velocity.y > 0f)
        {
            rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
        }
    }

    private void FixedUpdate()
    {
        // Move the player horizontally
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);
    }
}
