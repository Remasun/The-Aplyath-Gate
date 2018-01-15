using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HP : MonoBehaviour {

    public float maxHP = 1;
    public float minHP = 0;
    public float scale;
    public RectTransform healthBar;
    public float health = 1;

	// Use this for initialization
	void Start () {
        scale = healthBar.localScale.x;
	}
	
	// Update is called once per frame
	void Update ()
    {
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

        healthBar.localScale = new Vector3(health * (scale * maxHP), healthBar.localScale.y, 0);
	}

    public void FallDamage(float dmg)
    {
        health -= dmg / 70;
    }

    public void Damage(float dmg)
    {
        health -= dmg;
    }
}
