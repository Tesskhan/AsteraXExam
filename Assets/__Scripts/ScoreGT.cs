using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;

public class ScoreGT : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    public void UpdateScore(int score)
    {
        scoreText.text = "Score: " + score;
        Debug.Log("Score updated to: " + score);
    }

    public void AddScore(int score)
    {
        this.score += score;
        UpdateScore(this.score);
    }
}
