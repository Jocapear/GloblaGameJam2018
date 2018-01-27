using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletScript : MonoBehaviour {
	public float damage;
	public float destroyTime;

	void Start(){
		Destroy(gameObject,destroyTime);
	}
	void OnCollisionEnter(Collision c){
		if (c.gameObject.tag != "MainCamera"){
			Destroy(gameObject);
		}
		EnemyScript target = c.transform.GetComponent<EnemyScript>();
		if (target != null){
			target.TakeDamage(damage);
		}

		
	}
}
