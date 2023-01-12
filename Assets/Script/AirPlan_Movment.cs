 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirPlan_Movment : MonoBehaviour
{
    public Transform transform;
    public float speed=4f;
    void Start()
    {
        transform =GetComponent<Transform>(); 
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(0,speed * Time.deltaTime ,0);
    }
}
