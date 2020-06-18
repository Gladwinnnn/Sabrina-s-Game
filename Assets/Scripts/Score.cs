using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    int initialScore = 0;
    Text scoreDisplay;

    void Start()
    {
        scoreDisplay = GetComponent<Text>();
        scoreDisplay.text = initialScore.ToString();
    }

    void Update()
    {
        scoreDisplay.text = GetScore().ToString();
    }

    public void AddToScore()
    {
        initialScore += 1;
        PlayerPrefs.SetInt("Score", initialScore);
    }

    int GetScore()
    {
        return initialScore;
    }
}
