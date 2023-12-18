using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManagerController : MonoBehaviour
{
    public MusicController msController;
    public SFXController sfxController;
    public Text puntos;
    private int puntaje = 0;
    public string ganaste;
    public string perdiste;
    private void Awake()
    {
        msController.GetComponent<AudioSource>().Play();
        msController.GetComponent<AudioSource>().loop = true;
        puntos.text = "Puntaje: " + puntaje;
    }
    public void PlaySFX()
    {
        sfxController.GetComponent<AudioSource>().Play();
    }
    public void SumarPuntos()
    {
        puntaje = puntaje + 20;
        puntos.text = "Puntaje: " + puntaje;
    }
    public void Ganaste()
    {
        SceneManager.LoadScene(ganaste);
    }
    public void Perdiste()
    {
        SceneManager.LoadScene(perdiste);
    }
}
