using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour {

	public Transform bulletSpawn;
	public GameObject bullet;
	public float firePower;

    GameController gc;

    AudioSource shoot;

	public Camera fpsCam;

    void Awake()
    {
        shoot = gameObject.GetComponent<AudioSource>();
    }

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
        RaycastHit hit;

        if (gc.ammo1 > 0){
            
			GameObject newBullet = Instantiate (bullet, bulletSpawn.position, bulletSpawn.rotation ) as GameObject;
            if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, 100000.0f))
            {
                newBullet.GetComponent<Rigidbody>().velocity = Vector3.Normalize(hit.point - bulletSpawn.transform.position) * firePower;
            }
            else
                newBullet.GetComponent<Rigidbody>().velocity = fpsCam.transform.forward * firePower;

            gc.ammo1 -= 1;
		}
		
		
	}
}
