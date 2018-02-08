using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalRotation : MonoBehaviour
{
    public bool activated;
    public Animator goalAnim;
    public ParticleSystem particle;
    //public GameObject particleSystem;
    // Use this for initialization
    void Start ()
    {
        activated = false;
	}

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Laser")
        {
            activated = true;
            goalAnim.SetBool("Inters", true);

            StartCoroutine("Lightning");
            // particle.Play();
        }
    }
    IEnumerator Lightning()
    {
        yield return new WaitForSeconds(.5f);
        particle.Emit(1);
        yield return null;
    }
}