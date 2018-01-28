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
        RaycastHit hit;

		if(signal){
			newBullet = Instantiate (bullet0, bulletSpawn.position, bulletSpawn.rotation) as GameObject;
		}
		else{
			newBullet = Instantiate (bullet1, bulletSpawn.position, bulletSpawn.rotation) as GameObject;
		}

        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, 100000.0f))
        {
            newBullet.GetComponent<Rigidbody>().velocity = Vector3.Normalize(hit.point - bulletSpawn.transform.position) * firePower;
        }
        else
            newBullet.GetComponent<Rigidbody>().velocity = fpsCam.transform.forward * firePower;
		
	}
}
