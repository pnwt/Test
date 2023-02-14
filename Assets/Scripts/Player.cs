using System;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float jumpForce;
    private float moveDown;
    private bool _DragDown = false;
    [SerializeField] private float _MoveDownSpeed;
    private Rigidbody2D rb;


    private bool isGrounded;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGround;

    private int extraJump;
    public int extraJumpValue;
    public static Action OnGameOver;
    private Animator _Animator;
    // Start is called before the first frame update
    void Start()
    {
        extraJump = extraJumpValue;
        rb = GetComponent<Rigidbody2D>();
        _Animator= GetComponent<Animator>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);

        
    }

    void Update()
    {
        moveDown = Input.GetAxis("Vertical");
        if (isGrounded == true)
        {
            extraJump = extraJumpValue;
            _DragDown = false;
            _Animator.SetBool("IsGrounded", true);
        }
        else
        {
            _Animator.SetBool("IsGrounded", false);
        }

        if (Input.GetKeyDown(KeyCode.UpArrow) && extraJump > 0)
        {
            rb.velocity = Vector2.up * jumpForce;
            extraJump--;
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow) && extraJump == 0 && isGrounded == true)
        {
            rb.velocity = Vector2.up * jumpForce;
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            if (!isGrounded)
            {
                _DragDown = true;
            }
            else
            {
                _Animator.SetBool("IsSlide", true);
                gameObject.GetComponent<BoxCollider2D>().offset = new Vector2(0, -0.75f);
                gameObject.GetComponent<BoxCollider2D>().size = new Vector2(1.5f, 1.5f);
            }
            
        }
        else if (Input.GetKeyUp(KeyCode.DownArrow))
        {
            _Animator.SetBool("IsSlide", false);
            gameObject.GetComponent<BoxCollider2D>().offset = new Vector2(0, 0);
            gameObject.GetComponent<BoxCollider2D>().size = new Vector2(1.5f, 3);
        }
        if(_DragDown && moveDown < 0)
        {
            rb.velocity = new Vector2(rb.velocity.x, moveDown * _MoveDownSpeed);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Obstacle"))
        {
            _Animator.SetTrigger("Die");
            this.enabled = false;
            OnGameOver?.Invoke();
        }
    }
}