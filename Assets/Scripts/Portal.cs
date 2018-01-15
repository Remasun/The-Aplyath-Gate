using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{

    public GameObject targetPortal;
    public Vector3 targetLoc;
    public AudioSource sound;

    // Use this for initialization
    void Start()
    {
        targetLoc = targetPortal.transform.position;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "PlayerCharacter")
        {
            col.transform.position = targetLoc;
            col.transform.eulerAngles = new Vector3(0, 0, 0);
            sound.Play();
        }
    }
}
