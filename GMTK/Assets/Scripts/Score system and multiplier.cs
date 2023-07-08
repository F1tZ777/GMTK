using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class Scoresystemandmultiplier : MonoBehaviour
{
    public float score;
    public float scoreincrement;
    public float multiplier;
    public TMP_Text scoretext;
    private float timer;
    public Boolean multi;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        if(timer > 0.5)
        {
            if (multiplier >= 2)
            {
                IncreaseScoreMulti();
            }
            else
                IncreaseScore();

            UpdateScoreDisplay();
            timer = 0;
        }

    }

    public void IncreaseScore()
    {
        score += scoreincrement;
    }

    public void IncreaseScoreMulti()
    {
        if (multiplier >= 2)
        {
            score += (scoreincrement * multiplier);
        }
    }

    public void UpdateScoreDisplay()
    {
        scoretext.text = "Score : " + (int)score;
    }
}
