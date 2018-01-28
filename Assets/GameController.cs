using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{

    public GameObject[] availableEnemies;
    public GameObject[] spawners;
    public GameObject player;
    public int playersLife;

    public int ammo1;
    public int ammo2;
    private int level;
    private int numEnemies;
    private int enemiesAlive;
    private GameObject[] enemies;

    // Use this for initialization
    void Start () {
        ammo1 = 100;
        ammo2 = 100;
        level = 1;
        numEnemies = 3;
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
        numEnemies = 2*level;
        enemiesAlive = numEnemies;
        Debug.Log("Level UP: " + level);
        StartCoroutine(RestTime());

    }

    IEnumerator RestTime()
    {
        yield return new WaitForSeconds(10);
        StartCoroutine(CreateEnemies());
    }

    IEnumerator CreateEnemies()
    {
        Debug.Log(numEnemies + " will respawn");
        for (int i = 0; i < numEnemies; i++)
        {
            enemies = new GameObject[numEnemies];
            int randomNumber = Random.Range(0, 3);
            //Debug.Log("Spawner is: " + randomNumber);
            enemies[i] = Instantiate(availableEnemies[Random.RandomRange(0,2)], spawners[randomNumber].transform.position, spawners[randomNumber].transform.rotation);
            yield return new WaitForSeconds(2);

        }

        }
    }

