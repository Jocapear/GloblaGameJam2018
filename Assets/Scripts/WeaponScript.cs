using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponScript : MonoBehaviour {
	public int actualWeapon = 0;
	// Use this for initialization
	void Start () {
		selectWeapon();

	}
	
	// Update is called once per frame
	void Update () {
		int previousWeapon = actualWeapon;

		if (Input.GetAxis("Mouse ScrollWheel") > 0f){
			if(actualWeapon >= transform.childCount -1)
				actualWeapon = 0;
			else
				actualWeapon ++;			
		}
		if (Input.GetAxis("Mouse ScrollWheel") < 0f){
			if(actualWeapon <= 0)
				actualWeapon = transform.childCount -1;
			else
				actualWeapon --;			
		}

		if (previousWeapon != actualWeapon){
			selectWeapon();
		}
	}

	void selectWeapon(){
		int i = 0;
		foreach (Transform weapon in transform){
			if (i == actualWeapon)
				weapon.gameObject.SetActive(true);
			else
				weapon.gameObject.SetActive(false);
			i++;
		}
	}
}
