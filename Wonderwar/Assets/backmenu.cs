using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class backmenu : MonoBehaviour
{
    // Start is called before the first frame update

    public void ChangScenegameState()
    {
        SceneManager.LoadScene("MenuScene");
        
    
    }
    
}
