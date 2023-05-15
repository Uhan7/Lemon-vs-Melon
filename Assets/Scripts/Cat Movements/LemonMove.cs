using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LemonMove : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;

    public float speed;
    public float maxSpeed;
    public float decaySpeed;
    public float rotationSpeed;

    private bool moving;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {

        anim.SetFloat("Speed", rb.velocity.magnitude);

        if (Input.GetKey(KeyCode.Q))
        {
            moving = true;
        }
        else
        {
            moving = false;
        }
    }

    private void FixedUpdate()
    {
        if (rb.velocity.magnitude > maxSpeed || !moving)
        {
            rb.velocity *= decaySpeed;
        }
        else if (moving)
        {
            rb.AddForce(transform.up * speed);
        }

        if (!moving)
        {
            transform.Rotate(Vector3.forward * (rotationSpeed));
        }
    }

}