using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    bool gameover = false;
   // public GameObject GANEOVERBG;
    public GameObject GANEOVERBG;
    

    private void OnEnable()
    {

        gameover = false;
        Time.timeScale = 1f;
        GANEOVERBG.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (gameover) return;

        if (collision.CompareTag("Zombie"))
        {

           
            DGameSystem.LoadPool("AteYourBrains", new Vector3(0, 0));
            //Time.timeScale = 0.5f;
            GANEOVERBG.SetActive(true);

            // DGameSystem.instance.ShowPlayAgain(4f);
            //  GANEOVERBG.SetActive(true);



        }
        
    }
    // public void Restart(string sceneName)
    // {
    //    SceneManager.LoadScene(sceneName);
    // }
    //  public void Exitgame(string sceneName)
    // {
    //      SceneManager.LoadScene(sceneName);
    //  }
    void Regame()
    {
        SceneManager.LoadScene("GameScene");
    }
}
