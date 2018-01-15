using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHP : MonoBehaviour {

    public float maxHP = 1;
    public float minHP = 0;
    public float scale;
    public float health = 1;
    public GameObject particle;
    public GameObject playerLevel;
    public float amnt = 0;
    public TextMesh uiHp;
    public string uiHpString;
    public Transform target;
    public GameObject player;
    public float speed;
    public Transform targetC;
    public GameObject cam;
    public float dis;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        uiHpString = health.ToString();
        uiHp.text = "HP:" + uiHpString + "/1";

        if (health > maxHP)
        {
            health = maxHP;
        }
        else
        {
            if (health < minHP)
            {
                particle.gameObject.GetComponent<ParticleSystem>().Play(true);
                amnt += 1;
                Levelupr(1);
                Destroy(gameObject, 1.1f);
                gameObject.GetComponent<EnemyHP>().enabled = false;
            }
        }
        targetC = cam.transform;
        cam.transform.LookAt(targetC);
        dis = Vector3.Distance(player.transform.position, transform.position);
        target = player.transform;
        transform.LookAt(target);
        transform.Rotate(0, 180, 0);
        if (dis >= 100)
        {
            gameObject.GetComponent<Rigidbody>().Sleep();
            return;
        }
        transform.Translate(0, 0, -speed * Time.deltaTime * 2, Space.Self);
    }

    public void Damage(float dmg)
    {
        health -= dmg;
    }

    public void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Projectile")
        {
            Damage(0.06f);
            Destroy(col.gameObject);
        }
    }

    public void Levelupr (float lvl)
    {
        if (amnt == 1)
        {
            playerLevel.gameObject.GetComponent<Leveling>().level += 1;
        }
    }
}
