﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

	public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        
    #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
    #else
          Application.Quit ();
    #endif
        
    }

    public void BackToStart()
    {
        SceneManager.LoadScene("Startmenu");
    }

    public void TryAgain()
    {
        SceneManager.LoadScene("Levels");
    }


    public void Controls()
    {
        SceneManager.LoadScene("Controls");
    }
}

