using UnityEngine;
using System.Collections;

public class respawn2 : MonoBehaviour {
	Health2 myHealth2;

	// Use this for initialization
	void Start () {
		myHealth2 = GetComponent<Health2>();

	}
	
	// Update is called once per frame
	void Update () {
		if (myHealth2.currentHealth2 <= 0) {
						transform.position = GameObject.FindGameObjectWithTag ("Respawn 2").transform.position;
						myHealth2.currentHealth2 = 100;
				}
	}
}
