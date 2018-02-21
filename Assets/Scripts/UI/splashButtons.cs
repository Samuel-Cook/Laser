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
        StartCoroutine("LevelSelector");
    }

    public void Mute()
    {
        StartCoroutine("MuteGame");
    }

    public void Quit ()
    {
        StartCoroutine("QuitGame");
    }
    public void MainMenu ()
    {
        StartCoroutine("LoadMenu");
    }

    IEnumerator LoadMenu()
    {
        {
            float fadeTime = GameObject.Find("AudioManager").GetComponent<fade>().BeginFade(1);
            yield return new WaitForSeconds(fadeTime);
            SceneManager.LoadScene(0);
        }
    }

    IEnumerator LevelSelector()
    {
        {
            float fadeTime = GameObject.Find("AudioManager").GetComponent<fade>().BeginFade(1);
            yield return new WaitForSeconds(fadeTime);
            SceneManager.LoadScene("Menu");
        }
    }

    IEnumerator QuitGame()
    {
        {
            float fadeTime = GameObject.Find("AudioManager").GetComponent<fade>().BeginFade(1);
            yield return new WaitForSeconds(fadeTime);
            Application.Quit();
        }
    }
    IEnumerator MuteGame()
    {
        {
            if (AudioListener.pause == false)
            {
                AudioListener.pause = true;
            }
            else if (AudioListener.pause == true)
            {
                AudioListener.pause = false;

            }
            yield return null;
        }

    }
}
