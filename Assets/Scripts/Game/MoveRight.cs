using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRight : MonoBehaviour
{
    public GameObject laserPrefabVerticalU;
    public GameObject laserPrefabVerticalD;
    public GameObject SwitchC;
    public GameObject scoreHolder;
    public bool GoRight;
    public ParticleSystem effect;
    public AudioSource Saudio;

    // Use this for initialization
    void Start()
    {
        GoRight = true;
        laserPrefabVerticalU = (GameObject)(Resources.Load("Vertical/Laser Vertical U"));
        laserPrefabVerticalD = (GameObject)(Resources.Load("Vertical/Laser Vertical D"));

        SwitchC = GameObject.Find("SwitchC");
        Switch s = SwitchC.GetComponent<Switch>();

        // grabs scoreholder script
        scoreHolder = GameObject.Find("ScoreManager");
        ScoreManager t = scoreHolder.GetComponent<ScoreManager>();

        effect = this.GetComponent<ParticleSystem>();

        Saudio = this.GetComponent<AudioSource>();

        StartCoroutine("LaserHorizontal");

    }
    IEnumerator LaserHorizontal()
    {
        while (GoRight == true)
        {
            transform.Translate(Time.deltaTime, 0, 0, Space.World);

            yield return null;
        }
    }
    IEnumerator SpawnNewLaserVertical()
    {
        {
            effect.Play();
            Saudio.Play();
            Instantiate(laserPrefabVerticalU, transform.position, transform.rotation);
            Switch.laserCount++;
            Instantiate(laserPrefabVerticalD, transform.position, transform.rotation);
            Switch.laserCount++;

            yield return null;
        }
        // function in switch script..
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
        if (Input.GetMouseButtonDown(0) && Time.timeScale == 1 && playSpace.clicked == true && ScoreManager.maxTaps >= 1)
        {
            StopCoroutine("LaserHorizontal");
            StartCoroutine("SpawnNewLaserVertical");
            StartCoroutine("Destroythis");
        }
    }
}