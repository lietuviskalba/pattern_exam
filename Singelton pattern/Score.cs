using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    // *** SINGELTON PATTERN ***
    // Create a private static instance to save as the sole instance of the game
    // With a private contructor so that noone could call it
    private static Score scoreInstance;

    private Score() {}

    private Text score;
    public int highScore;
    public static int points;

    public void Start()
    {
        SingeltonInstance();
        score = GameObject.Find("Score").GetComponent<Text>();
        points = 0;
    }

    // *** STATE PATTERN ***
    // Cheking if the instance already exist or not
    // Destroy if it does
    // Set this instance as the sole one

    private void SingeltonInstance()
    {
        
        if (scoreInstance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            scoreInstance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    private void Update()
    {
        if(score == null)
        {
            score = GameObject.Find("Score").GetComponent<Text>();
        }

        highScore = points;
        score.text = "-" + points.ToString("00") + "-";

    }
}
