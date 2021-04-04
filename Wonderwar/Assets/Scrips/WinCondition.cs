using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinCondition : MonoBehaviour
{
    public GameObject GANEWIN;
    private void Start()
    {
        GANEWIN.SetActive(false);
    }
    void Update()
    {
        if (CheckWin())
            Win();
    }

    public bool CheckWin()
    {
        GameObject[] zombies = GameObject.FindGameObjectsWithTag("Zombie");
        for (int i = 0; i < zombies.Length; i++)
        {
            if (zombies[i].activeSelf == true)
                return false;
        }
        return true;
    }

    public void Win()
    {
        DGameSystem.instance.ShowMessage("You Win!");
        GANEWIN.SetActive(true);

        //DGameSystem.instance.ShowPlayAgain(2f);
    }
}
