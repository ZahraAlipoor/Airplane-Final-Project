using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Airplane_Movment1 : MonoBehaviour
{
     public Transform transform;
    public float speed=4f;
    void Start()
    {
          transform =GetComponent<Transform>(); 
    }

   
    void Update()
    {
        transform.position -= new Vector3(0,speed * Time.deltaTime ,0);
    }
}
