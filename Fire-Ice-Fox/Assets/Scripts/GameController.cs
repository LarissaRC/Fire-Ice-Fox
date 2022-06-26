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

    public int keyDirection = 0;
    // 0 = Up
    // 1 = Up Right
    // 2 = Right
    // 3 = Down Right
    // 4 = Down

    public bool moveRocks = false;
    public int floorRockTotal;
    public int floorRocksCount = 0;
    public bool moveGround = false;
    public bool moveFoxFriend = false;

    public GameObject rightScreen; // Pra fazer desaparecer ao fim do jogo
    public GameObject winScreen;
    public GameObject lostScreen;

    public GameObject fox;
    public GameObject deadFox;

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
        print("Lost");
    }

    public void EndGameScreen()
    {
        if(ScoreManager.score == (floorRockTotal - 1))
        {
            Invoke("CloseRightScreen", 2.0f);
            Invoke("LoadEndGameScreen", 3.0f);
        }
        else
        {
            deadFox.SetActive(true);
            fox.SetActive(false);
            Invoke("CloseRightScreen", 0.0f);
            Invoke("LoadEndGameScreen", 2.0f);
        }
    }

    public void CloseRightScreen()
    {
        rightScreen.SetActive(false);
        if((floorRockTotal - 1) != ScoreManager.score)
        {
            ScoreManager.Miss();
        }
    }

    public void LoadEndGameScreen()
    {
        if((floorRockTotal - 1) == ScoreManager.score)
        {
            winScreen.SetActive(true);
        }
        else
        {
            lostScreen.SetActive(true);
        }
    }
}
