using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserFiring : MonoBehaviour {

    public GameObject prefab;
    public bool shoot = false;

    // Use this for initialization
    void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("Fire1"))
        {
            shoot = true;
        }
        else
        {
            if (Input.GetButtonUp("Fire1"))
            {
                shoot = false;
            }
        }
        
        if (shoot == true)
        {
            Instantiate(prefab, transform.position, gameObject.transform.rotation);
        }
    }
}
