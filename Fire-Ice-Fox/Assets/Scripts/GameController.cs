using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{

    public bool upKeyPressed = false;
    public bool upRightKeyPressed = false;
    public bool downKeyPressed = false;
    public bool downRightKeyPressed = false;
    public bool rightKeyPressed = false;

    public static GameController instance;

    void Start()
    {
        instance = this;
    }

    public void LoadScene(string scene)
    {
        SceneManager.LoadScene(scene);
    }

    public void OpenMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void OpenRepository()
    {
        Application.OpenURL("https://github.com/LarissaRC/Fire-Ice-Fox");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
