using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour {

    public float speed;
    public GameObject hitE;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(0, 0, speed * Time.deltaTime * 10, Space.Self);
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Terrain")
        {
            GameObject ef = Instantiate(hitE, col.transform);
            Destroy(ef, 1f);
            Destroy(gameObject, 1.1f);
        }

        if (col.gameObject.tag == "FT")
        {
            col.gameObject.GetComponent<FlameThrower>().HealthDown(0.1f);
        }
    }
}
