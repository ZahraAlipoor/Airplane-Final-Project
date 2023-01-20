using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
   public GameObject playerBullet ;
   public Transform SpawnPoint1;
      
    public Transform SpawnPoint2;

   
   
   
   private void Update(){


    if(Input.GetButtonDown("Fire1"))
       {
         
          Instantiate(playerBullet,transform.position,Quaternion.identity);


         }
       
          
    }
   }
 


   
   


