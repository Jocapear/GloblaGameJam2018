using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour {

	public Transform bulletSpawn;
	public GameObject bullet;
	public float firePower;

    GameController gc;


	public Camera fpsCam;
	void Start()
    {
        gc = GameObject.Find("EscenarioGGJ_2018_07").GetComponent<GameController>();
    }
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Fire1")){
			Shoot();
		}
	}

	void Shoot(){
		
		if (gc.ammo1 > 0){
			//bulletSpawn.rotation = Quaternion.LookRotation(hit.point-bulletSpawn.position);
			//Vector3.Normalize(hit.point-bulletSpawn.position)
			GameObject newBullet = Instantiate (bullet, bulletSpawn.position, bulletSpawn.rotation ) as GameObject;
			newBullet.GetComponent<Rigidbody>().velocity =  fpsCam.transform.forward * firePower;
			gc.ammo1 -= 1;
		}
		
		
	}
}
