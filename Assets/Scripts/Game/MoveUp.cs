using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUp : MonoBehaviour
{ 
    public GameObject laserPrefabHorizontalR;
    public GameObject laserPrefabHorizontalL;
    public GameObject SwitchC;
    public GameObject scoreHolder;
    public GameObject playspace;

    void Start()
    {
        //StartCoroutine("LaserVertical");
        

        // loads prefabs from resources folder for instantiation
        laserPrefabHorizontalR = (GameObject)(Resources.Load("Horizontal/Laser Horizontal R"));
        laserPrefabHorizontalL = (GameObject)(Resources.Load("Horizontal/Laser Horizontal L"));

        // grabs switch script
        SwitchC = GameObject.Find("SwitchC");
        Switch s = SwitchC.GetComponent<Switch>();
        
        // grabs scoreholder script
        scoreHolder = GameObject.Find("ScoreManager");
        ScoreManager t = scoreHolder.GetComponent<ScoreManager>();

        playspace = GameObject.Find("playspace");
        playSpace v = playspace.GetComponent<playSpace>();

        // starts laser movement over time
        StartCoroutine("LaserVertical");
    }

    IEnumerator LaserVertical()
    {
        while (Switch.GoUp == true)
        {
            transform.Translate(0, Time.deltaTime, 0, Space.Self);

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
        // function in switch script..
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && Time.timeScale == 1 && playSpace.clicked == true)
        {
           // StopCoroutine("FireLaserUp");

            if(Time.timeScale == 1)
            {
                StopCoroutine("FireLaserUp");
                StartCoroutine("SpawnNewLaserHorizontal");
                //ScoreManager.tapTotal++;
                StartCoroutine("Destroythis");
            }
            //StartCoroutine("SpawnNewLaserHorizontal");
            //ScoreManager.tapTotal++;
            //StartCoroutine("Destroythis");
        }    
    }
}