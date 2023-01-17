using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score_Manager : MonoBehaviour
{
    public int score =0;

    public Text scoreText;  
    void Start()
    {
        StartCoroutine(Score());
    }

    
    void Update()
    {
         scoreText.text = score.ToString();
    }
    IEnumerator Score(){
        while(true){

             yield return new WaitForSeconds(2);
         score = score +1;
        Debug.Log("Score:"+ score); 
    }
        }
       
}
