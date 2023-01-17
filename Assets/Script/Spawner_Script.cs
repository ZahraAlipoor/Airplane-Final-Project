using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner_Script : MonoBehaviour
{
    public  GameObject[] plane1;
    void Start()
    {
       StartCoroutine(SpawnPlanes());
    }

   
    void Update()
    {
        
    }
    void plan(){
        int rand=Random.Range(0,plane1.Length);
       float randXPos= Random.Range(-3.05f,3.05f);
       Instantiate(plane1[rand], new Vector3(randXPos, transform.position.y,transform.position.z),Quaternion.Euler(0,0,0));

    }
    IEnumerator SpawnPlanes(){
        while(true){
        yield return new WaitForSeconds(4);
        plan();

        }
         }      
}
