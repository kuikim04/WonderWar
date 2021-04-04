using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pgame : MonoBehaviour
{
    public static bool isPauseGame ;
    public GameObject PauseMenu;
    public GameObject backmenu2;

    void Start()
    {
        PauseMenu.SetActive(false);
    }
     void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPauseGame)
            {
                ResumeGame();
            }
            
            else
            {
                PauseGame();

            }
        }
        
    }
    public void PauseGame()
    {
        PauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isPauseGame = true;
    }
    public void ResumeGame()
    {
        PauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isPauseGame = false;

    }
    public void GotoMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MenuScene");
    }

}
