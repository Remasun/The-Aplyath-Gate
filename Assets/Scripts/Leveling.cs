using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Leveling : MonoBehaviour {

    public float levelStart = 0;
    public Text t;
    public float level;
    public string lvl;

	// Use this for initialization
	void Start () {
        level = levelStart;
	}

    // Update is called once per frame
    void Update()
    {
        lvl = level.ToString();
        t.text = "Lvl:" + lvl;
    }

    public void Levelup (int levelup)
    {
        lvl += levelup;
    }
}
