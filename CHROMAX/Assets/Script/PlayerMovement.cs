using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{

   public Script1 Red; 
   public Script1 Blue; 
   public Script1 Yellow; 
   public Script1 Green; 

   
   

    private float horizontal;
    public float speed = 8f;
    public float jumpPower = 16f;
    public bool isGrounded = false;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private string groundTag = "Ground";
    public ParticleSystem dust;

    private bool isJumping = false;


    public Transform wallcheck; 
    public bool istouchingWall; 
    public bool isSliding = false; 
    public float WallSlidingSpeed;
    public float wallJumpForce; 
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
       
    }

    private void Update()
{
   if(Red.istouchingwall || Yellow.istouchingwall || Green.istouchingwall || Blue.istouchingwall)  { 
    istouchingWall = true;
   }else { 
    istouchingWall = false;
   }




    horizontal = Input.GetAxisRaw("Horizontal");

    Collider2D[] colliders = Physics2D.OverlapCircleAll(groundCheck.position, 0.1f);
    isGrounded = false;
    for (int i = 0; i < colliders.Length; i++)
    {
        if (colliders[i].gameObject != gameObject && colliders[i].gameObject.CompareTag(groundTag))
        {   
            isJumping = false; 
            isGrounded = true;
            break;
        }
    }

    if (Input.GetButtonDown("Jump") && isGrounded)
    {
        dust.Play();
        rb.velocity = new Vector2(rb.velocity.x, jumpPower);
        isJumping = true;
    }

    if (Input.GetButtonDown("Jump") && istouchingWall && !isGrounded)
    {
        WallJump();
    }

    if (Input.GetButtonUp("Jump") && rb.velocity.y > 0f)
    {
        rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
    }

    if (istouchingWall && !isJumping)
    {
        isSliding = true;
    }
    else
    {
        isSliding = false;
    }
}


    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * speed, rb.velocity.y);

         if (isSliding)
        {
            rb.velocity = new Vector2(rb.velocity.x, Mathf.Clamp(rb.velocity.y, -WallSlidingSpeed, float.MaxValue));
        }

    }

    void WallJump()
    {

        int wallDirection = istouchingWall ? -1 : 1;
        rb.velocity = new Vector2(wallJumpForce * wallDirection, jumpPower);
        isJumping = true;
    }

}
