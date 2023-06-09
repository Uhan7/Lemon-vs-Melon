using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatBump : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;

    public KeyCode bumpKey;

    public float bumpForce;
    public float bumpDecay;

    private bool bumping;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetKeyDown(bumpKey))
        {
            bumping = true;
        }
    }

    private void FixedUpdate()
    {
        if (bumping)
        {
            rb.AddForce(transform.up * bumpForce);
            bumping = false;
        }
        else
        {
            rb.velocity *= bumpDecay;
        }
    }

}