﻿using UnityEngine;
using System.Collections;

public class attackb : MonoBehaviour {
	public GameObject player2;
	public float attackTimer;
	
	// Use this for initialization
	void Start () {
		attackTimer = 0;
	}
	void Update (){
		if(Input.GetKeyDown("f")) {
			if(attackTimer == 0) {
				Attack();
				
			}
		}
		
	}
	
	private void Attack() {
		float distance = Vector3.Distance(player2.transform.position, transform.position);
		
		Vector3 dir = (player2.transform.position - transform.position).normalized;
		
		float direction = Vector3.Dot(dir, transform.forward);
		
		if(distance < 6f) {
			if(direction > 0) {
				Health2 eh = (Health2)player2.GetComponent("Health2");
				eh.ModifyHealth(-5);
			}
		}
	}
}

