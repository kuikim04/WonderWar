using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playkun2 : MonoBehaviour
{
    bool isPlayfast = false;
    public void FastGame()
    {
        if (isPlayfast)
        {
            Time.timeScale = 1;
            isPlayfast = false;
        }
        else
        {
            Time.timeScale = Time.timeScale * 2;
            isPlayfast = true;
        }
    }
}
