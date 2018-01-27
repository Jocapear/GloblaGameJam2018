using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClamidiaBehaviour : MonoBehaviour {

    public Animator anim;
    public float defaultSpeed;
    public double attackDistance;
    public GameObject player;

    private Transform enemyModel;
    private bool dead;
    private AudioSource source;
    private UnityEngine.AI.NavMeshAgent navigation;

    void Awake()
    {
        source = GetComponent<AudioSource>();
        enemyModel = transform.GetChild(0);
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
}
