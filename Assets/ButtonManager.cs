using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ButtonManager : MonoBehaviour
{
    private int score;
    public TMPro.TMP_Text scoreText;

    private void Start()
    {
        score = 0;
        scoreText.text = score.ToString();
    }

    public void ChangeScore(int change)
    {
        score = score + change;
        if (score < 0)
        {
            score = 0;
        }
        scoreText.text = score.ToString();
    }
}