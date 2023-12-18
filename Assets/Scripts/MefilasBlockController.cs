using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MefilasBlockController : MonoBehaviour
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
                AplicarPowerUp(player);
            }
            else if (probabilidad <= 80 && PowerUpActive == false)
            {
                AplicarPowerUp(player, 0.25f);
                PowerUpActive = true;
            }
            else
            {
                if (PowerUpActive == false)
                {
                    AplicarPowerUp(collider.gameObject, 2);
                }
            }
        }
    }
    void AplicarPowerUp(PlayerController player)
    {
        player.RestartValues();
        PowerUpActive = false;
    }
    void AplicarPowerUp(PlayerController jugador, float escala)
    {
        if(PowerUpActive == false)
        {
            jugador.transform.localScale = new Vector2(0.20f + escala, 0.20f + escala);
        }
    }
    void AplicarPowerUp(GameObject Ball, int velocidad)
    {
        Ball.GetComponent<BallControler>().speed = velocidad;
    }
}
