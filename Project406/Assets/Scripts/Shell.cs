using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shell : MonoBehaviour {
	
	public Rigidbody2D rb;
	public float speed = 5f;
	public int damage = 40;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody2D>();
		//rb.velocity = transform.right * speed * Turret.chargePower;
		rb.AddForce(transform.right * speed * Turret.chargePower);
	}

	void OnTriggerEnter2D(Collider2D hitInfo){

		EnemyAI enemy = hitInfo.GetComponent<EnemyAI>();

		if(enemy != null){
			enemy.TakeDamage(damage);
		}

		Destroy(gameObject);
	}

	void FixedUpdate(){
		//Rotates shell towards destination
		float angle = Mathf.Atan2 (rb.velocity.y, rb.velocity.x) * Mathf.Rad2Deg;
		rb.rotation = angle;
		
	}
}
