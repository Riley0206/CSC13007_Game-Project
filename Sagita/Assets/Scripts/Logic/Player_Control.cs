using UnityEngine;
using UnityEngine.InputSystem;

public class Player_Control : MonoBehaviour
{
    [HideInInspector]
    public Vector2 movement;
    private Rigidbody2D rb;
    private Animator anim;
    [HideInInspector]
    public float lastHorizontalVector;
    [HideInInspector]
    public float lastVerticalVector;

    [SerializeField] float speed = 5f;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        movement = new Vector2();
    }

    private void OnMovement(InputValue value)
    {
        //movement.x = Input.GetAxisRaw("Horizontal");
        //movement.y = Input.GetAxisRaw("Vertical");
        movement = value.Get<Vector2>();

        if (movement != Vector2.zero)
        {
            anim.SetFloat("X_Axis", movement.x);
            anim.SetFloat("Y_Axis", movement.y);
            anim.SetBool("IsWalking", true);
        }
        else
        {
            anim.SetBool("IsWalking", false);
        }
    }

    private void Update()
    {
        if (movement.x != 0)
        {
            lastHorizontalVector = movement.x;
        }

        if (movement.y != 0)
        {
            lastVerticalVector = movement.y;
        }
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
    }
}
