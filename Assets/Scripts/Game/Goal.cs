using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    public GameObject scoreHolder;
    //public GameObject particle;
    //public GameObject art;

    // Use this for initialization
    void Start()
    {
        
        // grabs score manager script
        scoreHolder = GameObject.Find("ScoreManager");
        ScoreManager s = scoreHolder.GetComponent<ScoreManager>();

        // grabs particle system
        //particle = GameObject.Find("VfxBoltLighting");
        //ParticleSystem t = particle.GetComponent<ParticleSystem>();
        //art = GetComponentInChildren<GoalRotation>();
        //GoalRotation art = gameObject.GetComponentInChildren<GoalRotation>();// GoalRotation.activated = true;
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Laser")
        {
            ScoreManager.scoreTotal++;
            // GoalRotation.changeBool();
            //GoalRotation.changeBool();

            //  ParticleSystem.play;
            //            ParticleSystem.Play();
            Destroy(GetComponent<Goal>());
        }
    }
}