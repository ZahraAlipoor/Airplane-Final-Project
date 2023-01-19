using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movment : MonoBehaviour
{
    public Transform transform;
    public float speed=1.5f;
    public float rotationSpeed=5f;
    public score_Manager score_value;
    public GameObject gameOverPanel;
     public  AudioSource CoinSound;
    void Start()
    {
        gameOverPanel.SetActive(false);
        Time.timeScale = 1;
    }

    
    void Update()
    {
        if(Input.GetKey(KeyCode.RightArrow)){
            transform.position += new Vector3(speed * Time.deltaTime , 0,0);
            transform.rotation = Quaternion.Lerp(transform.rotation,Quaternion.Euler(0,0,174.2f),rotationSpeed *Time.deltaTime);
        }
         if(Input.GetKey(KeyCode.LeftArrow)){
            transform.position -= new Vector3(speed * Time.deltaTime , 0,0);
              transform.rotation = Quaternion.Lerp(transform.rotation,Quaternion.Euler(0,0,-174.2f),rotationSpeed *Time.deltaTime);
        }
        

        Vector3 pos =transform.position;
        pos.x = Mathf.Clamp(pos.x,-2.88f,2.88f);
        transform.position=pos;
        
        
    
    }
  private void OnTriggerEnter2D(Collider2D collision){
    if(collision.gameObject.tag=="enemy"){
       Time.timeScale = 0;
       gameOverPanel.SetActive(true);

     } 
     if(collision.gameObject.tag=="coin.heart"){
      score_value.score += 10;
     Destroy(collision.gameObject);
      
   }
    if (collision.gameObject.tag == "coin.heart"){
               CoinSound.Play();
               score_value.score += 10;
              Destroy(collision.gameObject);
    }
  }
}


