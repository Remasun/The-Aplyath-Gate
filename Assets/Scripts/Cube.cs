using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour {

    public bool dis;
    public Material material1;
    public Material material2;
    public float duration = 50;
    public Renderer rend;
    public GameObject playerLevel;
    public GameObject fireEmitter;
    public ParticleSystem fire;
    public float health = 4;

	// Use this for initialization
	void Start ()
    {
        fire = gameObject.GetComponentInChildren<ParticleSystem>();
        fire.Stop();
        rend = GetComponent<Renderer>();
        rend.material = material1;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (health <= 0)
        {
            Disintegrate();
        }

        fire.transform.eulerAngles = new Vector3(-90, 0, 0);
		if (dis == true)
        {
            float lerp = Mathf.PingPong(Time.time, duration) / duration;
            rend.material.Lerp(material1, material2, lerp);
            Destroy(gameObject, 2f);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            dis = true;
        }
	}

    public void Disintegrate()
    {
        gameObject.GetComponent<Collider>().enabled = false;
        gameObject.GetComponent<Rigidbody>().useGravity = false;
        gameObject.GetComponent<AudioSource>().enabled = true;
        fire.Play();
        Destroy(gameObject, 2f);
        dis = true;
        playerLevel.gameObject.GetComponent<Leveling>().Levelup(1);
    }

    public void HealthDown(float damage)
    {
        health -= damage;
    }
}
