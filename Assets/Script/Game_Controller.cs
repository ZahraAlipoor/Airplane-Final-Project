using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game_Controller : MonoBehaviour
{ public Text highScoreText;
  public Text scoreText;
  
  public  int score;
  public int highScore;
  public score_Manager Score_manager;


    void Start()
    {
        
    }

    
    void Update()
    {
        highScore = PlayerPrefs.GetInt("high_score");
        score = score_Manager.lastScore;
        highScoreText.text = "High Score:" + highScore.ToString();
        scoreText.text ="Score:" + score.ToString();

    }
}
