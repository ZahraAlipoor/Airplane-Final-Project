using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner_Script : MonoBehaviour
{
    public  GameObject plan1;
    void Start()
    {
        Instantiate(plan1, transform.position,Quaternion.identity);
    }

   
    void Update()
    {
        
    }
}
