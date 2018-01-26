using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PuzzleSolutions : MonoBehaviour
{
    public List<GameObject> puzzleGoals = new List<GameObject>();

    public int Solution;    

    public GameObject scoreHolder;

    public Animator Complete;

    void Start()
    {
        scoreHolder = GameObject.Find("ScoreManager");
        ScoreManager t = scoreHolder.GetComponent<ScoreManager>();
        GameObject currentGoal = GameObject.Find("Goal");
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
            StartCoroutine("PauseGame");
        }
    }
    IEnumerator PauseGame()
    {
        {
            
            yield return new WaitForSeconds(2.2f);
            Time.timeScale = 0;
        }
        // function in switch script..
    }
}

