using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movment : MonoBehaviour
{
    public Transform transform;
     public float speed=1.5f;
    void Start()
    {
        
    }

    
    void Update()
    {
        if(Input.GetKey(KeyCode.RightArrow)){
            transform.position += new Vector3(speed * Time.deltaTime , 0,0);
        }
         if(Input.GetKey(KeyCode.LeftArrow)){
            transform.position -= new Vector3(speed * Time.deltaTime , 0,0);
        }

        Vector3 pos =transform.position;
        pos.x = Mathf.Clamp(pos.x,-1.52f,1.52f);
        transform.position=pos;
        
    }
}
