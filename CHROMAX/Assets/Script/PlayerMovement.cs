using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    private float horizontal;
    public float speed = 8f;
    public float jumpPower = 16f;
    private bool isGrounded = false;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private string groundTag = "Ground";
    public ParticleSystem dust;

    private bool facingRight = true; // Added variable to track player's direction

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

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
            dust.Play();
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

        // Check the movement direction to flip the particle system
        if (horizontal > 0 && !facingRight)
        {
            FlipParticle(false); // Flip particle for right movement
        }
        else if (horizontal < 0 && facingRight)
        {
            FlipParticle(true); // Flip particle for left movement
        }
    }

    void FlipParticle(bool flip)
    {
        facingRight = !flip; // Update facingRight based on the flip value

<<<<<<< Updated upstream
        var particleMain = dust.main;
        particleMain.startRotation = facingRight ? 0f : Mathf.PI; // Rotate particle based on movement direction
    }
=======


>>>>>>> Stashed changes
}
