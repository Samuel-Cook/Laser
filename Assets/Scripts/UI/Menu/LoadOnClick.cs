using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadOnClick : MonoBehaviour
{
    public void LoadScene(int level)
    {
        StartCoroutine("LoadScenef", level);
    }
    IEnumerator LoadScenef(int level)
    {
        {
            float fadeTime = GameObject.Find("AudioManager").GetComponent<fade>().BeginFade(1);
            yield return new WaitForSeconds(fadeTime);
            SceneManager.LoadScene(level);
        }
        yield return null;
    }

}
