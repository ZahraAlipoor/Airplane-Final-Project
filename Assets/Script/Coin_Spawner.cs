using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin_Spawner : MonoBehaviour
{
    public GameObject[] coinPrefabs;
    void Start()
    {
        StartCoroutine(coinSpawner());
    }

   
    void Update()
    {
        
    }
     void coin(){
        int rand=Random.Range(0,coinPrefabs.Length);
       float randXPos= Random.Range(-3.05f,3.05f);
       Instantiate(coinPrefabs[rand], new Vector3(randXPos, transform.position.y,transform.position.z),Quaternion.Euler(0,0,0));

}
 IEnumerator coinSpawner(){
        while(true){
        int time =Random.Range(8,18);
        yield return new WaitForSeconds(time);
        coin();

        }
         }      
}
