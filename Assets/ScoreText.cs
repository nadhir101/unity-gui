using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour {

    public Text scoreText;
    int score=0;
    private void Update()
    {
        score++;
        scoreText.text = "Score:" + score.ToString();
        
    }

}
