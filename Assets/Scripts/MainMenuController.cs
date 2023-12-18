using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    private string gameplayScene = "Nivel1";
    public void Jugar()
    {
        SceneManager.LoadScene(gameplayScene);
    }
    public void Exit()
    {
        Application.Quit();
    }
}
