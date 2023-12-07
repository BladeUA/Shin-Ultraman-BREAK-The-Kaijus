using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControler : MonoBehaviour
{
    public float speed = 10f;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(speed, speed);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        string tag = collision.gameObject.tag;

        if (tag == "VerticalWall")
        {
            rb.velocity = new Vector2(-rb.velocity.x, rb.velocity.y);
        }
        else if (tag == "HorizontalWall")
        {
            rb.velocity = new Vector2(rb.velocity.x, -rb.velocity.y);
        }
        else if (tag == "Vaus")
        {
            float x = hitFactor(transform.position, collision.transform.position, collision.bounds.size.x);
            Vector2 dir = new Vector2(x, 1).normalized;
            rb.velocity = dir * speed;
        }
        float hitFactor(Vector2 ballPos, Vector2 vausPos, float vausWidth)
        {
            return (ballPos.x - vausPos.x) / vausWidth;
        }
    }

}
