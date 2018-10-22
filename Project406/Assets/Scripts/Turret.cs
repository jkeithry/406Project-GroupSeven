using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour {

	public Transform firePoint;
	public GameObject shellPrefab;
	public static float chargePower;

	void Start(){
		chargePower = 1f;
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Fire1")){
			chargePower = 1f;
		}
		if (Input.GetButton("Fire1")){
			if(chargePower >= 1 && chargePower < 100){
				chargePower += 0.5f;
			}
			Debug.Log(chargePower);
		}
		if (Input.GetButtonUp("Fire1")) {
			Shoot();
		}

	}

	void Shoot(){
		//shooting logic
		Instantiate(shellPrefab, firePoint.position, firePoint.rotation);
	}
}
