using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniMap_TriangleFollowPlayer : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 targetPostition = new Vector3( 0, this.transform.position.y,0 );
		transform.LookAt(targetPostition );
	}
}
