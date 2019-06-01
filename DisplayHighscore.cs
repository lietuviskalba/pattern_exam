using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayHighscore : MonoBehaviour
{
    public Text txtHighscore;

    void Start()
    {
        GameObject scoreKeep = GameObject.FindGameObjectWithTag("Score");
        int highScore = scoreKeep.GetComponent<Score>().highScore;

        txtHighscore.text = highScore.ToString("00");
    }
}
