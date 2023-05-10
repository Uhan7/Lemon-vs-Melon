using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MelonMove : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;

    public float speedX;
    public float speedY;

    public float maxSpeedX;
    public float maxSpeedY;

    public float friction;

    private bool moveLeft;
    private bool moveRight;
    private bool moveUp;
    private bool moveDown;

    public float rotationTime;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {

        anim.SetFloat("Speed", rb.velocity.magnitude);

        moveLeft = false;
        moveRight = false;
        moveUp = false;
        moveDown = false;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            moveLeft = true;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            moveRight = true;
        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            moveUp = true;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            moveDown = true;
        }
    }

    void FixedUpdate()
    {

        if (moveLeft)
        {
            rb.AddForce(Vector2.left * speedX);
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 0, 90), rotationTime);
        }
        if (moveRight)
        {
            rb.AddForce(Vector2.right * speedX);
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 0, 270), rotationTime);
        }
        if (moveUp)
        {
            rb.AddForce(Vector2.up * speedY);
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 0, 0), rotationTime);
        }
        if (moveDown)
        {
            rb.AddForce(Vector2.down * speedY);
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 0, 180), rotationTime);
        }
        if (moveLeft && moveUp) transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 0, 45), rotationTime);
        if (moveLeft && moveDown) transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 0, 135), rotationTime);
        if (moveRight && moveDown) transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 0, 225), rotationTime);
        if (moveRight && moveUp) transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.Euler(0, 0, 315), rotationTime);

        if (rb.velocity.x > maxSpeedX)
        {
            rb.velocity = new Vector2(maxSpeedX, rb.velocity.y);
        }

        if (rb.velocity.x < -maxSpeedX)
        {
            rb.velocity = new Vector2(-maxSpeedX, rb.velocity.y);
        }

        if (rb.velocity.y > maxSpeedY)
        {
            rb.velocity = new Vector2(rb.velocity.x, maxSpeedY);
        }

        if (rb.velocity.y < -maxSpeedY)
        {
            rb.velocity = new Vector2(rb.velocity.x, -maxSpeedY);
        }

        if (rb.velocity.magnitude > Mathf.Sqrt(maxSpeedY + maxSpeedX))
        {
            rb.velocity = rb.velocity.normalized;
        }

        rb.velocity = new Vector2(rb.velocity.x * friction, rb.velocity.y * friction);
    }

}
