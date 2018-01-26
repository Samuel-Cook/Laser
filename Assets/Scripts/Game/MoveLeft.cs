using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public GameObject SwitchC;
    public GameObject laserPrefabVerticalU;
    public GameObject laserPrefabVerticalD;
    public bool GoLeft;

    // Use this for initialization
    void Start()
    {
        GoLeft = true;
        laserPrefabVerticalU = (GameObject)(Resources.Load("Vertical/Laser Vertical U"));
        laserPrefabVerticalD = (GameObject)(Resources.Load("Vertical/Laser Vertical D"));
        SwitchC = GameObject.Find("SwitchC");
        Switch s = SwitchC.GetComponent<Switch>();
        StartCoroutine("LaserHorizontal");
    }

    IEnumerator LaserHorizontal()
    {
        while (Switch.GoLeft == true)
        {
            transform.Translate(-Time.deltaTime, 0, 0, Space.World);

            yield return null;
        }
    }

    IEnumerator SpawnNewLaserVertical()
    {
        {
            Instantiate(laserPrefabVerticalU, transform.position, transform.rotation);
            Switch.laserCount++;
            Instantiate(laserPrefabVerticalD, transform.position, transform.rotation);
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
        // function in switch script..
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && Time.timeScale == 1)
        {
            StopCoroutine("FireLaserUp");
            StartCoroutine("SpawnNewLaserVertical");
            StartCoroutine("Destroythis");
        }
    }
}