using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SignalScript : MonoBehaviour {
	public bool signalType;
	public float destroyTime;

	void Start(){
		Destroy(gameObject,destroyTime);
	}
	void OnCollisionEnter(Collision c){
        Debug.Log("choco");
        DispenserScript target = c.transform.GetComponent<DispenserScript>();
        if (target != null)
        {
            target.EnterSignal(signalType);
            Debug.Log("entro");
        }
        if (c.gameObject.tag != "MainCamera"){
			Destroy(gameObject);
		}
		

		
	}
}
