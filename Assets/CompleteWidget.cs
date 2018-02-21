using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CompleteWidget : MonoBehaviour
{


    public void Restart()
    {
        StartCoroutine("RestartScene");
    }

    public void Continue()
    {
        StartCoroutine("ContinueScene");
    }
    public void Splash()
    {
        StartCoroutine("SplashScreen");
    }
    public void LevelSelect()
    {
        StartCoroutine("LevelSelector");
    }
    IEnumerator RestartScene()
    {
        {
            float fadeTime = GameObject.Find("AudioManager").GetComponent<fade>().BeginFade(1);
            yield return new WaitForSeconds(fadeTime);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        //  yield return null;
    }
    IEnumerator ContinueScene()
    {
        {
            float fadeTime = GameObject.Find("AudioManager").GetComponent<fade>().BeginFade(1);
            yield return new WaitForSeconds(fadeTime);
            SceneManager.LoadScene("Menu");
        }
        // yield return null;
    }
    IEnumerator SplashScreen()
    {
        {
            float fadeTime = GameObject.Find("AudioManager").GetComponent<fade>().BeginFade(1);
            yield return new WaitForSeconds(fadeTime);
            SceneManager.LoadScene("Splash");
        }
        // yield return null;
    }
    IEnumerator LevelSelector()
    {
        {
            float fadeTime = GameObject.Find("AudioManager").GetComponent<fade>().BeginFade(1);
            yield return new WaitForSeconds(fadeTime);
            SceneManager.LoadScene("Menu");

            // yield return null;
        }
    }
}
