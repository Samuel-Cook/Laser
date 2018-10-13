using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playSpace : MonoBehaviour
{
    public static bool clicked;
    public AudioSource sound;
    public GameObject scoreHolder;
    public GameObject SwitchC;

    // Use this for initialization
    void Start ()
    {
        StartCoroutine("FalseSetter");
        sound = this.GetComponent<AudioSource>();

        scoreHolder = GameObject.Find("ScoreManager");
        ScoreManager t = scoreHolder.GetComponent<ScoreManager>();

        SwitchC = GameObject.Find("SwitchC");
        Switch s = SwitchC.GetComponent<Switch>();
    }

    // Update is called once per frame
    void OnMouseDown()
    {
        if (ScoreManager.maxTaps >0)
        {
            Switch.speed = Switch.speed += .3f;
            clicked = true;
            StartCoroutine("FalseSetter");
            sound.Play();
        }
    }
    IEnumerator FalseSetter()
    {
        {
            yield return new WaitForSeconds(.1f);
            clicked = false;
        }
        // function in switch script..
    }
}
