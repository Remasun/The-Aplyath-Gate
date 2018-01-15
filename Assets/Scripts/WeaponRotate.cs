using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponRotate : MonoBehaviour {

    public GameObject f;
    public GameObject s;
    public GameObject t;
    public float speed;
    public float mSpeed;
    public GameObject l;
    public float lVa = 0.5f;

	// Use this for initialization
	void Start () {
        speed = mSpeed;
	}
	
	// Update is called once per frame
	void Update () {
        f.transform.Rotate(speed * Time.deltaTime, 0, 0);
        s.transform.Rotate(speed * Time.deltaTime * 4 , 0, 0);
        t.transform.Rotate(speed * Time.deltaTime * 7 , 0, 0);

        if (Input.GetButtonDown("Fire1"))
        {
            speed = mSpeed*8;
            l.gameObject.GetComponent<Light>().intensity = lVa + 1;
        }
        else
        {
            if (Input.GetButtonUp("Fire1"))
            {
                speed = mSpeed;
                l.gameObject.GetComponent<Light>().intensity = lVa - 1;
            }
        }
    }
}
