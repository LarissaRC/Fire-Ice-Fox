using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorRock : MonoBehaviour
{
    public float t;
    private float verticalMove = 2.0f;
    private float horizontalMove = 3.0f;

    // Update is called once per frame
    void Update()
    {

        if(GameController.instance.moveRocks)
        {
            switch(GameController.instance.keyDirection)
            {
                case 0: // Up
                    verticalMove = -2.0f;
                    horizontalMove = 0.0f;
                break;
                case 1: // Up right
                    verticalMove = -2.0f;
                    horizontalMove = 3.0f;
                break;
                case 2: // Right
                    verticalMove = 0.0f;
                    horizontalMove = 3.0f;
                break;
                case 3: // Down right
                    verticalMove = 2.0f;
                    horizontalMove = 3.0f;
                break;
                case 4: // Down
                    verticalMove = 2.0f;
                    horizontalMove = 0.0f;
                break;
            }
            transform.position = Vector2.Lerp(transform.position, new Vector3(transform.position.x - horizontalMove, transform.position.y + verticalMove, transform.position.z), t);
            GameController.instance.floorRocksCount += 1;

            if(GameController.instance.floorRocksCount == GameController.instance.floorRockTotal)
            {
                GameController.instance.moveRocks = false;
                GameController.instance.floorRocksCount = 0;

                // Verificar se ele já pulou sobre todas as rochas
                if(ScoreManager.score == (GameController.instance.floorRockTotal - 1))
                {
                    GameController.instance.EndGameScreen();
                }
            }
        }
        
    }
}
