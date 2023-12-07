using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControler : MonoBehaviour
{
    public float speed;
    public int direccionX;
    public int direccionY;

    private Rigidbody2D rb;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();

    }
    void Start()
    {
        
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(speed * direccionX, speed * direccionY);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        string tag = collision.gameObject.tag;

        if (tag == "VerticalWall")
        {
            if (direccionX > 0)
            {
                direccionX = -1;
            }
            else
            {
                direccionX = 1;
            }
        }
        else if (tag == "HorizontalWall")
        {
            if (direccionY > 0)
            {
                direccionY = -1;
            }
        }
        else if (tag == "VausLeft")
        {
            direccionX = -1;
            direccionY = 1;
        }
        else if (tag == "VausCenter")
        {
            direccionX = 0;
            direccionY = 1;
        }
        else if (tag == "VausRight")
        {
            direccionX = 1;
            direccionY = 1;
        }


    }

}
