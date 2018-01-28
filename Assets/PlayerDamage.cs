using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDamage : MonoBehaviour {
    GameController gc;
    // Use this for initialization
    void Start () {
        gc = GameObject.Find("EscenarioGGJ_2018_07").GetComponent<GameController>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnCollisionEnter(Collision c)
    {
        if(c.gameObject.layer == 10)
        {
            gc.playersLife -= 10;
        }
    }
}
