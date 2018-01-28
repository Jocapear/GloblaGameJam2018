using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeeleScript : MonoBehaviour {

    public float damage,speed,hittime;
    public GameObject hit;
    bool hitting;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (hitting) {
            float step = speed * Time.deltaTime;

            float duration = Time.time + hittime;
            while (Time.time < duration)
            {
                gameObject.transform.rotation = Quaternion.RotateTowards(gameObject.transform.rotation, hit.transform.rotation, step);
            }
            hitting = false;
            
        }

        if (Input.GetButtonDown("Fire1"))
            hitting = true;
        
    }
}
