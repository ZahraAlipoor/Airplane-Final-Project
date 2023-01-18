using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class score_Manager : MonoBehaviour
{
    public int score =0;
    public int highScore;

    public static int lastScore = 0;

    public Text scoreText;  
    void Start()
    {
        StartCoroutine(Score());
        highScore = PlayerPrefs.GetInt("high_score" , 0);
        Debug.Log("high score stored:" + PlayerPrefs.GetInt("high_score"));
        Debug.Log("high score  :" + highScore );
         Debug.Log("last store  :" + lastScore );
        
    }

    
    void Update()
    {
         scoreText.text = score.ToString();
         if(score > highScore){
            highScore =score;
            PlayerPrefs.SetInt("high_score" ,highScore);
         }
    }
    IEnumerator Score(){
        while(true){
        yield return new WaitForSeconds(2);
         score = score +1;
        
    }
        }

        IEnumerator Reload(){
        yield return new WaitForSeconds(10);
        SceneManager.LoadScene("game");
       
}
}
