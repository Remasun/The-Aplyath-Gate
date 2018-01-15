using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour {

    public float speed;
    public GameObject hpHolder;

    // Use this for initialization
    void Start()
    {
        hpHolder = GameObject.Find("HpHolder");
        Destroy(gameObject, 0.4f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, speed * Time.deltaTime * 10, 0, Space.Self);
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "PlayerCharacter")
        {
            hpHolder.gameObject.GetComponent<HP>().Damage(0.01f);
        }
    }
}
