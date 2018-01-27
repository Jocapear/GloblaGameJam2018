using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour {

	public Transform bulletSpawn;
	public GameObject bullet;
	public float firePower;


	public Camera fpsCam;
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Fire1")){
			Shoot();
		}
	}

	void Shoot(){
		Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

		GameObject newBullet = Instantiate (bullet, bulletSpawn.position, Quaternion.LookRotation(ray.direction)) as GameObject;
		newBullet.GetComponent<Rigidbody>().velocity = ray.direction * firePower;
	}
}
