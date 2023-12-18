using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D _compRigidbody2D;
    private int velocidad = 8;
    private float direccionHorizontal;

    void Awake()
    {
        _compRigidbody2D = GetComponent<Rigidbody2D>();
        velocidad = 8;
    }
    void Update()
    {
        direccionHorizontal = Input.GetAxisRaw("Horizontal");
    }
    void FixedUpdate()
    {
        _compRigidbody2D.velocity = new Vector2(velocidad * direccionHorizontal,0);
    }
}
