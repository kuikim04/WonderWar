using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour
{
   public void Outgame()
    {
        Application.Quit();
        Debug.Log("Exit Game");
        
    }
}
