using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireSplash : MonoBehaviour
{
    public bool waitTimeR;
    public bool waitTimeL;
    public float wait;

    void Start()
    {
        wait = 0;
        StartCoroutine("LaserFireR");
        StartCoroutine("LaserFireL");
    }



    IEnumerator LaserFireR()
    {
        while (waitTimeR == true)
        {
            transform.Translate(Time.deltaTime, 0, 0, Space.World);

            yield return null;
        }
    }
    IEnumerator LaserFireL()
    {
        while (waitTimeL == true)
        {
            transform.Translate(-Time.deltaTime, 0, 0, Space.World);

            yield return null;
        }
    }
}
