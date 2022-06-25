using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fox : MonoBehaviour
{

    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if(GameController.instance.rightKeyPressed == true)
        {
            anim.SetTrigger("Jump");
            GameController.instance.rightKeyPressed = false;
        }
        if(GameController.instance.upRightKeyPressed == true)
        {
            anim.SetTrigger("Jump");
            GameController.instance.upRightKeyPressed = false;
        }
        if(GameController.instance.upKeyPressed == true)
        {
            anim.SetTrigger("Jump");
            GameController.instance.upKeyPressed = false;
        }
        if(GameController.instance.downRightKeyPressed == true)
        {
            anim.SetTrigger("Jump");
            GameController.instance.downRightKeyPressed = false;
        }
        if(GameController.instance.downKeyPressed == true)
        {
            anim.SetTrigger("Jump");
            GameController.instance.downKeyPressed = false;
        }
    }
}
