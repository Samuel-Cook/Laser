using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IGM : MonoBehaviour
{

    public void Start()
    {

    }

    public void OpenMenu()
    {
        if (Time.timeScale == 1) // is paused? 
            Time.timeScale = 0; //pause game
        else
            Time.timeScale = 1; //otherwise unpause game
    }
}
