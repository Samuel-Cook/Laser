using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalParticleSystem : MonoBehaviour
{
    public ParticleSystem cunt;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Laser")
        {
            Debug.Log("Hit");
            cunt.Play();
        }
    }
}
