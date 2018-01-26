using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundary : MonoBehaviour
{
    public GameObject SwitchC;
    // Use this for initialization
    void Start ()
    {
        SwitchC = GameObject.Find("SwitchC");
        Switch s = SwitchC.GetComponent<Switch>();


    }
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Laser")
        {
            Destroy(collision.gameObject.GetComponent<MoveUp>());
            Destroy(collision.gameObject.GetComponent<MoveDown>());
            Destroy(collision.gameObject.GetComponent<MoveLeft>());
            Destroy(collision.gameObject.GetComponent<MoveRight>());
            Switch.laserCount--;

        }
    }
}
