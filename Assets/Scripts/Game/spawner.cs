using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject laserPrefabVerticalU;

    void Start ()
    {

        Instantiate(laserPrefabVerticalU, transform.position, transform.rotation);
        Destroy(this);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
