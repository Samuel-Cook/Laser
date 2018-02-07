using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireSplash : MonoBehaviour
{
    public bool waitTime;
    public float wait;

    void Start()
    {
        waitTime = true;
        wait = 0;
        StartCoroutine("LaserFire");
    }
    void Update()

    {
        if (waitTime = true)
        {
            wait = wait + 1 * Time.deltaTime;
        }
        if (wait >= 12)
        {
            waitTime = false;
        }
    }

    IEnumerator LaserFire()
    {
        while (waitTime == true && wait <= 12)
        {
            transform.Translate(Time.deltaTime, 0, 0, Space.World);

            yield return null;
        }
    }
}
