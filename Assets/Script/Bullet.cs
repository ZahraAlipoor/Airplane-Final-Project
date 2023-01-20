using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{ 

    public float Speed=10f;
   
    void Start()
    {
      
        
    }
    

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up * Speed * Time.deltaTime);
        
    }
   private void OnTriggerEnter2D(Collider2D collision){
        if(collision.gameObject.tag == "enemy"){
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }
   

}

