using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NerongaBlockController : MonoBehaviour
{
    private bool PowerUpActive = false;
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Ball")
        {
            PlayerController player = collider.gameObject.GetComponent<BallControler>().playerStats;
            int probabilidad = Random.Range(0, 100);
            if (probabilidad <= 50)
            {
                AplicarPowerUp(player, collider.gameObject);
            }
            else if (probabilidad <= 80 && PowerUpActive == false)
            {
                AplicarPowerUp(player, 0.20f);
                PowerUpActive = true;
            }
            else
            {
                if (PowerUpActive == false)
                {
                    AplicarPowerUp(collider.gameObject, 4);
                }
            }
        }
    }
    void AplicarPowerUp(PlayerController player,GameObject ball)
    {
        player.RestartValues();
        ball.GetComponent<BallControler>().speed = 3;
        PowerUpActive = false;
    }
    void AplicarPowerUp(PlayerController jugador, float escala)
    {
        if (PowerUpActive == false)
        {
            jugador.transform.localScale = new Vector2(escala, escala);
        }
    }
    void AplicarPowerUp(GameObject Ball, int velocidad)
    {
        Ball.GetComponent<BallControler>().speed = velocidad;
    }
}
