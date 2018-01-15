using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healer : MonoBehaviour
{

    public bool healer;
    public GameObject playerHP;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "PlayerCharacter")
        {
            playerHP.gameObject.GetComponent<HP>().health = 1;
        }
    }
}