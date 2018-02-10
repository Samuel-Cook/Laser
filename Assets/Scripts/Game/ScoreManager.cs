using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    public Text tapText;
    public GameObject playspace;
    public static int scoreTotal;
    public static int tapTotal;
    public static int laserTotal;
    public bool gameStarted;
    public Animator failWidget;
    public GameObject SwitchC;
    public TextMeshProUGUI levelName;

    // Use this for initialization
    void Start()
    {
        playspace = GameObject.Find("playspace");
        playSpace v = playspace.GetComponent<playSpace>();

        SwitchC = GameObject.Find("SwitchC");
        Switch s = SwitchC.GetComponent<Switch>();

        scoreTotal = 0;
        tapTotal = 0;
        gameStarted = true;
        levelName.SetText ("Level: " + SceneManager.GetActiveScene().buildIndex);
                
    if (Time.timeScale != 1) // is paused?
        {
            Time.timeScale = 1; //pause game
        }

    }
            

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score: " + scoreTotal;
        tapText.text = "Taps: " + tapTotal;


        if (Input.GetMouseButtonDown(0) && Time.timeScale == 1 && playSpace.clicked == true && gameStarted == true)
        {
            tapTotal++;
        }
        if (Switch.laserCount == 0 && (gameStarted == true))
        {
            failWidget.SetBool("fail", true);
            gameStarted = false;
          //  Time.timeScale = 0; //pause game

        }
    }
}
