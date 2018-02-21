using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class ScoreManager : MonoBehaviour
{
    public GameObject playspace;
    public static int scoreTotal;
    public static int tapTotal;
    public static int laserTotal;
    public bool gameStarted;
    public Animator failWidget;
    public GameObject SwitchC;
    public TextMeshProUGUI levelName;
    public TextMeshProUGUI tapText;
    public TextMeshProUGUI scoreText;
    public static int maxTaps;
    public int Taps;
    public AudioSource Failsfx;

    // Use this for initialization
    void Start()
    {
        maxTaps = Taps;
        playspace = GameObject.Find("playspace");
        playSpace v = playspace.GetComponent<playSpace>();

        SwitchC = GameObject.Find("SwitchC");
        Switch s = SwitchC.GetComponent<Switch>();

        scoreTotal = 0;
        tapTotal = 0;
        gameStarted = true;
        levelName.SetText("Level: " + SceneManager.GetActiveScene().buildIndex);
                
    if (Time.timeScale != 1) // is paused?
        {
            Time.timeScale = 1; //pause game
        }

    }
            

    // Update is called once per frame
    void Update()
    {
        scoreText.SetText("Score: " + scoreTotal);
        tapText.SetText("Taps: " + maxTaps);


        if (Input.GetMouseButtonDown(0) && Time.timeScale == 1 && playSpace.clicked == true && gameStarted == true && maxTaps >= 1)
        {
            maxTaps--;
        }

 /*       if(maxTaps <=0)
        {
            failWidget.SetBool("fail", true);
            gameStarted = false;
        }
*/
        if (Switch.laserCount == 0 && gameStarted == true)
        {
            failWidget.SetBool("fail", true);
            Failsfx.Play();
            gameStarted = false;
          //  Time.timeScale = 0; //pause game

        }
    }
}
