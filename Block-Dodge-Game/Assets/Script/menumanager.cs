﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
public class menumanager : MonoBehaviour
{

    void Start()
    {
        
    }


    public void PlayGame()
    {
       
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
   
    // Start is called before the first frame update
    public void OnApplicationQuit()
    {
       
        Application.Quit();
    }
}
