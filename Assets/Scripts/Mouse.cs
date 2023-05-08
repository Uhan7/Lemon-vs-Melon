using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour
{

    private Rigidbody2D rb;

    public float decay;
    public float rotDecay;

    public GameObject bounceFX;
    public GameObject deathFX;
    
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        rb.velocity *= decay;
        rb.rotation *= rotDecay;
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        switch (col.gameObject.tag)
        {
            case "Lemon Hole":
                Instantiate(deathFX, transform.position, transform.rotation);
                GameMaster.melonScore++;
                Debug.Log("Melon Score : " + GameMaster.melonScore);
                Destroy(gameObject);
                break;

            case "Melon Hole":
                Instantiate(deathFX, transform.position, transform.rotation);
                GameMaster.lemonScore++;
                Debug.Log("Lemon Score : " + GameMaster.lemonScore);
                Destroy(gameObject);
                break;

            default:
                Instantiate(bounceFX, transform.position, transform.rotation);
                break;
        }
    }
}
