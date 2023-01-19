using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Controller : MonoBehaviour


{
    public GameObject starbutton;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     public void start(){
      SceneManager.LoadScene("game");
}
}
