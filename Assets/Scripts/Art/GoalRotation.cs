using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalRotation : MonoBehaviour
{
    public bool activated;
	// Use this for initialization
	void Start ()
    {
        activated = false;	
	}
	
	// Update is called once per frame
	void Update ()
    {
	if (activated == true)
        {
            transform.Rotate(0, 0, 2);
        }
	}

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Laser")
        {
            activated = true; 
        }
    }
}
