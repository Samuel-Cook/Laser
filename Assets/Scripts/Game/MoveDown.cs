using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDown : MonoBehaviour
{
    public GameObject laserPrefabHorizontalR;
    public GameObject laserPrefabHorizontalL;
    public GameObject scoreHolder;
    public GameObject SwitchC;
    public ParticleSystem effect;
    public AudioSource Saudio;

    // Use this for initialization
    void Start()
    {
        laserPrefabHorizontalR = (GameObject)(Resources.Load("Horizontal/Laser Horizontal R"));
        laserPrefabHorizontalL = (GameObject)(Resources.Load("Horizontal/Laser Horizontal L"));

        SwitchC = GameObject.Find("SwitchC");
        Switch s = SwitchC.GetComponent<Switch>();
        
        // grabs scoreholder script
        scoreHolder = GameObject.Find("ScoreManager");
        ScoreManager t = scoreHolder.GetComponent<ScoreManager>();

        effect = this.GetComponent<ParticleSystem>();

        Saudio = this.GetComponent<AudioSource>();

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
            effect.Play();
            Saudio.Play();
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
        if (Input.GetMouseButtonDown(0) && Time.timeScale == 1 && playSpace.clicked == true && ScoreManager.maxTaps >= 1)
        {
            StopCoroutine("FireLaserDown");
            StartCoroutine("SpawnNewLaserHorizontal");
            StartCoroutine("Destroythis");
        }
    }
}