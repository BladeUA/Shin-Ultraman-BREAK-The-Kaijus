using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControler : MonoBehaviour
{
    public float speed;
    public int direccionX;
    public int direccionY;
    public GameManagerController gm;
    private Rigidbody2D _compRigidbody2D;
    public PlayerController playerStats;
    private int bloquesDestruidos = 0;
    private void Awake()
    {
        _compRigidbody2D = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        _compRigidbody2D.velocity = new Vector2(speed * direccionX, speed * direccionY);
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
        else if (tag == "Block")
        {
            Vector2 direction = collision.gameObject.transform.position - this.gameObject.transform.position;
            if (Mathf.Abs(direction.y) > Mathf.Abs(direction.x))
            {
                direccionY = direccionY * -1;
                gm.SumarPuntos();
                bloquesDestruidos = bloquesDestruidos + 1;
                Destroy(collision.gameObject);
            }
            else
            {
                direccionX = direccionX * -1;
                gm.SumarPuntos();
                bloquesDestruidos = bloquesDestruidos + 1;
                Destroy(collision.gameObject);
            }
        }
        else if (tag == "Perder")
        {
            gm.Perdiste();
        }
        if (bloquesDestruidos >= 27)
        {
            gm.Ganaste();
        }
        gm.PlaySFX();
    }
}
