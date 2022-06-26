using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public string buttonType;
    public string nextLevel; // Se existir

    void OnMouseDown()
    {
        if(buttonType == "Play")
        {
            GameController.instance.LoadScene(nextLevel);
        }
        else if(buttonType == "Exit")
        {
            GameController.instance.ExitGame();
        }
    }
}
