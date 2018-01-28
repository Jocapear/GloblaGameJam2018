using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    public GameObject[] availableEnemies;
    public GameObject[] spawners;
    public GameObject player;

    private int level;
    private int numEnemies;
    private GameObject[] enemies;

    // Use this for initialization
    void Start () {
        level = 1;
        numEnemies = 1;
        enemies = new GameObject[numEnemies];
        StartCoroutine(CreateEnemies());
	}
	
	// Update is called once per frame
	void Update () {
		if (enemies.Length <= 0)
        {
            LevelUp();
        }
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
        for (int i = 0; i < numEnemies; i++)
        {
            enemies = new GameObject[numEnemies];
            enemies[i] = Instantiate(availableEnemies[0], spawners[0].transform.position, spawners[0].transform.rotation);

            yield return new WaitForSeconds(1);
        }
        
    }
}
