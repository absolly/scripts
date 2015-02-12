using UnityEngine;
using System.Collections;

public class respawn1 : MonoBehaviour {
	Health myHealth;

	// Use this for initialization
	void Start () {
		myHealth = GetComponent<Health>();
	}
	
	// Update is called once per frame
	void Update () {
		if(myHealth.currentHealth <= 0){
			transform.position = GameObject.FindGameObjectWithTag("Respawn").transform.position;
			myHealth.currentHealth = 100;
}
}
}