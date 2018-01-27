using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour {

	public Transform bulletSpawn;
	public GameObject bullet;
	public float firePower;
	public int ammo = 10;


	public Camera fpsCam;
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Fire1")){
			Shoot();
		}
	}

	void Shoot(){
		
		if (ammo > 0){
			//bulletSpawn.rotation = Quaternion.LookRotation(hit.point-bulletSpawn.position);
			//Vector3.Normalize(hit.point-bulletSpawn.position)
			GameObject newBullet = Instantiate (bullet, bulletSpawn.position, bulletSpawn.rotation ) as GameObject;
			newBullet.GetComponent<Rigidbody>().velocity =  fpsCam.transform.forward * firePower;
			ammo -= 1;
		}
		
		
	}
}
