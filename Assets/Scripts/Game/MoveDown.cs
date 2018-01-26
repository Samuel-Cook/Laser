using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDown : MonoBehaviour
{
    public GameObject laserPrefabHorizontalR;
    public GameObject laserPrefabHorizontalL;
    public GameObject SwitchC;

    // Use this for initialization
    void Start()
    {
        laserPrefabHorizontalR = (GameObject)(Resources.Load("Horizontal/Laser Horizontal R"));
        laserPrefabHorizontalL = (GameObject)(Resources.Load("Horizontal/Laser Horizontal L"));
        SwitchC = GameObject.Find("SwitchC");
        Switch s = SwitchC.GetComponent<Switch>();
        StartCoroutine("FireLaserDown");
    }

    IEnumerator FireLaserDown()
    {
        while (Switch.GoDown == true)
        {
            transform.Translate(0, -Time.deltaTime, 0, Space.Self);

            yield return null;
        }
    }

    IEnumerator SpawnNewLaserHorizontal()
    {
        { 
            Instantiate(laserPrefabHorizontalR, transform.position, transform.rotation);
            Switch.laserCount++;
            Instantiate(laserPrefabHorizontalL, transform.position, transform.rotation);
            Switch.laserCount++;

            yield return null;
        }
    }

    IEnumerator Destroythis()
    {
        {
            Switch.laserCount--;
            Destroy(this);
            yield return null;
        }
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && Time.timeScale == 1)
        {
            StopCoroutine("FireLaserDown");
            StartCoroutine("SpawnNewLaserHorizontal");
            StartCoroutine("Destroythis");
        }
    }
}