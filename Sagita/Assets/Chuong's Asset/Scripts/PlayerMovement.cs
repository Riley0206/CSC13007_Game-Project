using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerMovement : MonoBehaviour
{
    private Vector2 movement;
    private Rigidbody2D rb;
    private Animator animator;
    [SerializeField] float speed = 3;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    private void OnMovement(InputValue value)
    {
        movement = value.Get<Vector2>();

        if (movement.x != 0 || movement.y != 0)
        {
            animator.SetFloat("X", movement.x);
            animator.SetFloat("Y", movement.y);

            animator.SetBool("IsWalking", true);
        }
        else
        {
            animator.SetBool("IsWalking", false);
        }


    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + speed * movement * Time.fixedDeltaTime);
    }

    /* [SerializeField] float speed = 5f;
    public Vector3 movement;
    public Rigidbody2D rb;
    Animate animate;

    public float lastHorizontalVector;
    public float lastVerticalVector;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        movement = new Vector3();
        animate = GetComponent<Animate>();
    }

    private void Start()
    {
        lastHorizontalVector = 1f;
    }

    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animate.horizontal = movement.x;

        movement *= speed;

        rb.linearVelocity = movement;

        if (movement.x != 0)
        {
            lastHorizontalVector = movement.x;
        }
        if (movement.y != 0)
        {
            lastVerticalVector = movement.y;
        }
        
    void Update()
     if (movement.x != 0 || movement.y != 0)
        {
            animator.SetFloat("X", movement.x);
            animator.SetFloat("Y", movement.y);

            animator.SetBool("IsWalking", true);
        }
        else
        {
            animator.SetBool("IsWalking", false);
        }
    }

    */

}
