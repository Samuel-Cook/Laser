using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PuzzleSolutions : MonoBehaviour
{
    public List<GameObject> puzzleGoals = new List<GameObject>();

    public static int Solution;    

    public GameObject scoreHolder;

    public Animator Complete;

    public AudioSource completeSFX;

    void Start()
    {
        scoreHolder = GameObject.Find("ScoreManager");
        ScoreManager t = scoreHolder.GetComponent<ScoreManager>();
        GameObject currentGoal = GameObject.Find("Goal");
        completeSFX = this.GetComponent<AudioSource>();
        //puzzleGoals.Add(g);
        addGoal(currentGoal);
        checkSolution();
    }



    // Update is called once per frame
    public void addGoal(GameObject currentGoal)
    {

        Debug.Log("outside");
        foreach (GameObject Goal in GameObject.FindGameObjectsWithTag("Goal"))
        {
                puzzleGoals.Add(currentGoal);
            }

        }

    public void checkSolution()
    {
        Solution = puzzleGoals.Count;
    }

    public void Update()
    {
        if(ScoreManager.scoreTotal >= Solution)
        {
            Complete.SetBool("Complete", true);
            ScoreManager.gameFinished = true;
            completeSFX.Play();
            
            ScoreManager.maxTaps = 0;
        }
    }

    IEnumerator PauseGame()
    {
        {
            //completeSFX.Play();
            yield return new WaitForSeconds(2.2f);
            
            Time.timeScale = 0;
        }
        // function in switch script..
    }
}

