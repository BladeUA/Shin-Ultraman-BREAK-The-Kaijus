using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoMainMenuController : MonoBehaviour
{
    public string menuTag = "Menu";
    public void GoMainMenu()
    {
        SceneManager.LoadScene(menuTag);
    }
}
