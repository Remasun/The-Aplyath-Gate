using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shooting : MonoBehaviour {

    public GameObject prefab;
    public AudioSource sound;
    public bool timerB;
    public float timer;
    public bool canShoot = true;
    public GameObject cro;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (timerB == true)
        {
            timer += 1 * Time.deltaTime;
        }

        if (timer >= 3)
        {
            canShoot = true;
            timerB = false;
            timer = 0;
            cro.GetComponent<Image>().enabled = true;
        }

        if (Input.GetButtonDown("Fire1"))
        {
            if (canShoot == true)
            {
                Instantiate(prefab, transform.position, gameObject.transform.rotation);
                sound.Play();
                cro.GetComponent<Image>().enabled = false;
                canShoot = false;
                timerB = true;
            }
        }
    }
}
