
using UnityEngine;

public class EnemyScript : MonoBehaviour {
    GameController gc;

    public float health = 50f;

    void Awake()
    {
        gc = GameObject.Find("EscenarioGGJ_2018_07").GetComponent<GameController>();
    }

	public void TakeDamage(float damage){
		health -= damage;
		if (health <= 0){
			Die();
		}
	}

	void Die (){
        gc.EnemyDead();
		Destroy(gameObject);
	}

}
