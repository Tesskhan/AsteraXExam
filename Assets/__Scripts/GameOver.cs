using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameOver : MonoBehaviour
{
    public TextMeshProUGUI gameOverText;
    // Start is called before the first frame update
    void Start()
    {
        GameOverScreen(false);
    }

    public void GameOverScreen(bool gameOver)
    {
        if (gameOver)
        {
            gameOverText.text = "Game Over";
            Debug.Log("Game Over");
        } 
        else
        {
            gameOverText.text = "";
        }
    }
}
