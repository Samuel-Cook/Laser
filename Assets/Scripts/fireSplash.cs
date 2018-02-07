using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireSplash : MonoBehaviour
{
    public bool waitTime;

    void Start()
    {
        waitTime = true;
        StartCoroutine("LaserFire");
    }
    void Update()

    {
        //if(waitTime != 0)
        {
            //waitTime = waitTime - 1*Time.deltaTime;
            
        }
    }

    IEnumerator LaserFire()
    {
        while (waitTime == true)
        {
            transform.Translate(Time.deltaTime, 0, 0, Space.World);

            yield return null;
        }
    }
}
