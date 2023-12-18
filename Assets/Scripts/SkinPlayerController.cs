using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinPlayerController : MonoBehaviour
{
    public GameObject jugador;
    void Update()
    {
        transform.position = new Vector3(jugador.transform.position.x, jugador.transform.transform.position.y, transform.position.z);
    }

}
