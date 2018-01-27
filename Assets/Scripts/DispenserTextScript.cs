using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DispenserTextScript : MonoBehaviour {
	GameObject player;
	// Use this for initialization
	void Start () {
		player = GameObject.Find("FPSController");
		SetText("Hola");
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.rotation = Quaternion.LookRotation((player.transform.position - gameObject.transform.position)*-1);
	}

	public void SetText(string text){
		gameObject.GetComponent<TextMesh>().text = text;
	}
}
