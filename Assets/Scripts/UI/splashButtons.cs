using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class splashButtons : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void LoadLevelSelect ()
    {
        SceneManager.LoadScene("Menu");
    }

    public void Quit ()
    {
        Application.Quit();
    }
    public void MainMenu ()
    {
        SceneManager.LoadScene(0);
    }
}
