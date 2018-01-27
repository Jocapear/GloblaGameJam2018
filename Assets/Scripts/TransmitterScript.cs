using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransmitterScript : MonoBehaviour {

	public Transform bulletSpawn;
	public GameObject bullet0,bullet1;
	public float firePower;

	GameObject newBullet;



	
	public Camera fpsCam;
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Fire1")){
			Shoot(true);
		}
		if (Input.GetButtonDown("Fire2")){
			Shoot(false);
		}
	}

	void Shoot(bool signal){
		if(signal){
			newBullet = Instantiate (bullet0, bulletSpawn.position, bulletSpawn.rotation) as GameObject;
		}
		else{
			newBullet = Instantiate (bullet1, bulletSpawn.position, bulletSpawn.rotation) as GameObject;
		}
		newBullet.GetComponent<Rigidbody>().velocity = fpsCam.transform.forward * firePower;
		
	}
}
