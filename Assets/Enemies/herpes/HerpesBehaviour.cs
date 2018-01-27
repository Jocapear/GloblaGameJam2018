using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HerpesBehaviour : MonoBehaviour {

    public Animator anim;
    public float defaultSpeed;
    public double attackDistance;
    public GameObject player;
    public GameObject mine;

    private Transform enemyModel;
    private bool dead;
    private AudioSource source;
    private UnityEngine.AI.NavMeshAgent navigation;
    private Transform minePivot;

    void Awake()
    {
        source = GetComponent<AudioSource>();
        enemyModel = transform.GetChild(0);
        minePivot = transform.GetChild(1);
    }

    // Use this for initialization
    void Start () {
        
        //life = 10;
        dead = false;
        navigation = GetComponent<UnityEngine.AI.NavMeshAgent>();
        StartCoroutine(PutMine());
    }
	
	// Update is called once per frame
	void Update () {
        navigation.SetDestination(player.transform.position);

        AnimatorStateInfo currentState = anim.GetCurrentAnimatorStateInfo(0);
        Debug.Log(currentState.ToString());
    }

    IEnumerator PutMine()
    {
        while (true)
        {
            Instantiate(mine, minePivot.position, minePivot.rotation);
            yield return new WaitForSeconds(3);
        }
    }
}
