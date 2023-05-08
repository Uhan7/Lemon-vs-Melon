using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bounce : MonoBehaviour
{

    private Animator anim;

    private bool bounce;

    public bool amCat;
    public bool amMouse;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        anim.SetBool("Bounce", bounce);
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (amCat)
        {
            if (col.gameObject.CompareTag("Mouse"))
            {
                bounce = true;
            }
        }
        if (amMouse)
        {
            bounce = true;
        }
    }

    private void OnCollisionExit2D(Collision2D col)
    {
        if (amCat)
        {
            if (col.gameObject.CompareTag("Mouse"))
            {
                bounce = false;
            }
        }
        if (amMouse)
        {
            bounce = false;
        }
    }
}
