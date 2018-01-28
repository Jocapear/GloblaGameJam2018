﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public GameObject[] availableEnemies;
    public GameObject[] spawners;
    public GameObject player;
    public int playersLife;

    private int level;
    private int numEnemies;
    private int enemiesAlive;
    private GameObject[] enemies;

    // Use this for initialization
    void Start () {
        level = 1;
        numEnemies = 10;
        enemies = new GameObject[numEnemies];
        StartCoroutine(CreateEnemies());
	}
	
	// Update is called once per frame
	void Update () {
		if (enemiesAlive <= 0)
        {
            LevelUp();
        }
        if (playersLife <= 0)
        {
            Debug.Log("----------------GAME OVER----------------");
        }
	}

    public void EnemyDead()
    {
        enemiesAlive--;
        Debug.Log("Enemy killed, "+enemiesAlive+" enemies remaining.");
    }

    private void LevelUp()
    {
        level++;
        StartCoroutine(RestTime());
        numEnemies = 10 * level;
        Debug.Log("Level UP: " + level);
        StartCoroutine(CreateEnemies());
    }

    IEnumerator RestTime()
    {
        yield return new WaitForSeconds(10);
    }

    IEnumerator CreateEnemies()
    {
        Debug.Log(numEnemies + " will respawn");
        enemiesAlive = numEnemies;
        for (int i = 0; i < numEnemies; i++)
        {
            enemies = new GameObject[numEnemies];
            int randomNumber = Random.Range(0, 3);
            //Debug.Log("Spawner is: " + randomNumber);
            enemies[i] = Instantiate(availableEnemies[0], spawners[randomNumber].transform.position, spawners[randomNumber].transform.rotation);
            yield return new WaitForSeconds(1);
        }
        
    }
}
