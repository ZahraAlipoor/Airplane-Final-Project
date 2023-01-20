using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Game_Controller : MonoBehaviour



{ public Text highScoreText;
  public Text scoreText;
  
  public  int score;
  public int highScore;
  public score_Manager Score_manager;

  public GameObject gamePausePanel;
  public GameObject gamePauseButton;

    void Start()
    {
        gamePausePanel.SetActive(false);
        gamePauseButton.SetActive(true);
    }

    
    void Update()
    {
        highScore = PlayerPrefs.GetInt("high_score");
        score = score_Manager.lastScore;
        highScoreText.text = "High Score:" + highScore.ToString();
        scoreText.text ="Score:" + score.ToString();

    }
     public void Restart(){
        SceneManager.LoadScene("game");

    }
    public void start(){
      SceneManager.LoadScene("game");
    }
    public void Home (){
       SceneManager.LoadScene("Start");
    }
      public void PauseGame(){
        Time.timeScale = 0;
        gamePausePanel.SetActive(true);
        gamePauseButton.SetActive(false);
      }
      public void ResumeGame(){
        Time.timeScale = 1;
         gamePausePanel.SetActive(false);
         gamePauseButton.SetActive(true);
      }
}


