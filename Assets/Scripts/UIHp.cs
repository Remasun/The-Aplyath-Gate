using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIHp : MonoBehaviour {

    public float maxHP = 100;
    public float minHP = 0;
    public float health = 100;
    public Text uiHp;
    public string uiHpString;
    public float amnt = 0;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        uiHpString = health.ToString();
        uiHp.text = "Health:" + uiHpString;

        if (health > maxHP)
        {
            health = maxHP;
        }
        else
        {
            if (health < minHP)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            print("neejij");
            Damage(0.1f);
        }

    }

    public void Damage (float dam)
    {
        health -= dam;
    }
}
