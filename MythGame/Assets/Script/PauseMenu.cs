﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PauseMenu : MonoBehaviour
{

    public static bool GameIsPaused = false;
    public bool pausecuy;
    public int countpause = 0;
    public GameObject pauseMenuUI;

    // Update is called once per frame
    void Update()
    {
      if (Input.GetKeyDown(KeyCode.Escape) || pausecuy == true && countpause == 0)
        {
            countpause = 1;
            if (GameIsPaused)
            {
                Resume();
            } else
            {
                Pause();
            }
        }  
    }

    public void Resume ()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        countpause = 0;
        GameIsPaused = false;
        pausecuy = false;
    }

    void Pause ()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void LoadMenu()
    {
        Resume();
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitGame()
    {
        Debug.Log("Quitting game.....");
        Application.Quit();
    }

    public void TekanPause()
    {
        pausecuy = true;
    }
    
    
}
