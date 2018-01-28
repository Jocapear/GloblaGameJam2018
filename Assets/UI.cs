using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour {
    public Text healthText;
    public Text ammoText;
    private GameController gc;
	// Use this for initialization
	void Start () {
        gc = GameObject.Find("EscenarioGGJ_2018_07").GetComponent<GameController>();
    }
	
	// Update is called once per frame
	void Update () {
        ammoText.text = "Ammo " + gc.ammo1;
	}
}
