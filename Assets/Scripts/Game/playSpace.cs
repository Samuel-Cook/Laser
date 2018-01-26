using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playSpace : MonoBehaviour
{
    public static bool clicked;
	// Use this for initialization
	void Start ()
    {
        StartCoroutine("FalseSetter");
	}

    // Update is called once per frame
    void OnMouseDown()
    {
        clicked = true;
        StartCoroutine("FalseSetter");
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
