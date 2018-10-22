using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public CharacterController2D controller;
	//public GameObject turret;
	public Transform turret;
	public float runSpeed = 40f;
	float horizontalMove = 0f;
	float turretAngle = 0f;
	float moveTurret = 0f; 
	float turretSpeed = 90; // move turret degrees per sec

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
		horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;
		moveTurret = Input.GetAxisRaw("Vertical") * turretSpeed * Time.deltaTime;
		turretAngle = Mathf.Clamp(turretAngle + moveTurret, 0f, 180f);

	}

	void FixedUpdate() {
		//Move Player Character
		controller.Move(horizontalMove * Time.fixedDeltaTime, false, false);
		turret.rotation = Quaternion.Euler(0f,0f,turretAngle);
		//turret.Rotate(0f,0f,moveTurret);
	}
}
