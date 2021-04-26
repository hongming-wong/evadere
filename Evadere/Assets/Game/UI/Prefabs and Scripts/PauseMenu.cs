﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool paused = false;
    public GameObject pauseMenuUI;

    public GameObject cameraControls;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (paused)
            {
                
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;
                Resume();
                
            }
            else
            {
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        paused = false;
    }
    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        paused = true;
    }
    public void goMenu()
    {
        Time.timeScale = 1f;
        Debug.Log("Going back to menu");
        SceneManager.LoadScene("Menu");
    }
    public void quitGame()
    {
        Debug.Log("Quit game successfully! ");
        Application.Quit();
    }
}
