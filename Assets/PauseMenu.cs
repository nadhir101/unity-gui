﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

    public static bool GameIsPaused;

    public GameObject PauseMenuUI;
 	
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if( GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
	}
    public void Resume()
    {
        PauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    void Pause()
    {
        PauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }
    public void LoadMenu()
    {
        Time.timeScale = 1f;
        Debug.Log("loading menu");
        SceneManager.LoadScene("menu");
    }
    public void QuitGame()
    {
        Debug.Log("Quit!!");
        Application.Quit();
    }
}