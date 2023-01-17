using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movment : MonoBehaviour
{
    public Transform transform;
     public float speed=1.5f;
      public float rotationSpeed=5f;
    void Start()
    {
        
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
        pos.x = Mathf.Clamp(pos.x,-3.05f,3.05f);
        transform.position=pos;
        
        
    
    }
  private void OnTriggerEnter2D(Collider2D collision){
    if(collision.gameObject.tag=="enemy"){
       Time.timeScale = 0;
     }
    }

}
