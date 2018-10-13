using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour

{

    public static int mLaser;
    public static int laserCount;
    public static bool GoUp;
    public static bool GoRight;
    public static bool GoLeft;
    public static bool GoDown;
    public static bool score;
    public static float speed;



    void Start()
    {
        laserCount = 1;
        mLaser = 2;
        GoUp = true;
        GoDown = true;
        GoRight = true;
        GoLeft = true;
        speed = .5f;
    }
    void Update()
    {
        //scoreText.text = "Score: " + puzzle;

        if(score == true)
        {
            AddToScore();
        }
    }
    void AddToScore()
    {
     //   puzzle = puzzle + 1;
       // Debug.Log("added to score");
    }
}