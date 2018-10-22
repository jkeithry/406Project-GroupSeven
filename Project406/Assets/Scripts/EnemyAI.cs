using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour {

	public int health = 100;

	// Use this for initialization
	public void TakeDamage(int damage) {
		health -= damage;
		if (health <= 0) {
			Destroy(gameObject);
		}
	}


	
	// Update is called once per frame
	void Update () {
		
	}
}
