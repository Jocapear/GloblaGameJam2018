using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SifilisBehaviour : MonoBehaviour {

    public Animator anim;
    public float defaultSpeed;
    public double attackDistance;
    
    private Transform enemyModel;
    private bool dead;
    private AudioSource source;
    private UnityEngine.AI.NavMeshAgent navigation;
    private GameObject player;
    private GameController gc;

    void Awake()
    {
        source = GetComponent<AudioSource>();
        enemyModel = transform.GetChild(0);
        player = GameObject.Find("Player");
        gc = GameObject.Find("EscenarioGGJ_2018_07").GetComponent<GameController>();
    }

    // Use this for initialization
    void Start () {
        
        //life = 10;
        dead = false;
        navigation = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }
	
	// Update is called once per frame
	void Update () {
        navigation.SetDestination(player.transform.position);
	}

    void OnCollisionEnter(Collision c)
    {
        if (c.gameObject.layer == 11)//Its player
        {
            gc.playersLife -= 20;
            gc.enemiesAlive--;
            Destroy(gameObject);
        }
    }
}
