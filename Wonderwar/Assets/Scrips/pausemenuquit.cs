using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pausemenuquit : MonoBehaviour
{
    public static bool isGamepaused = false;
    [SerializeField] GameObject pauseMenu;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            if(isGamepaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isGamepaused = true;

    }

    void PauseGame()
    {
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isGamepaused = true;
    }

    public void LoadMenu()
    {
        pauseMenu.SetActive(false);
        SceneManager.LoadScene("MenuScene");
        Time.timeScale = 1f;
        Debug.Log("Menu");
    }
    public void LoadGame()
    {
        pauseMenu.SetActive(false);
        SceneManager.LoadScene("GameScene");
        Time.timeScale = 1f;
        Debug.Log("Game");
    }

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}
