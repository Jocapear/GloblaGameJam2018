using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineBehaviour : MonoBehaviour {
    GameController gc;
	// Use this for initialization
	void Awake () {
        gc = GameObject.Find("EscenarioGGJ_2018_07").GetComponent<GameController>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider c)
    {
        Debug.Log("mina");
        if (c.gameObject.layer == 11){//is player
            gc.playersLife -= 10;
            Destroy(gameObject);
        }
        else if (c.gameObject.layer == 12)// Is Bullet (PlayerDamage)
        {
            Destroy(gameObject);
        }
    }

}
