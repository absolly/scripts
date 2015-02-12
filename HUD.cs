using UnityEngine;
using System.Collections;

public class HUD : MonoBehaviour {
	Health myHealth;
	
	void Awake()
	{
		myHealth = GetComponent<Health>();
	}

	void OnGUI()
	{
		GUI.Label (new Rect(5, 25, 120, 20),  "Health: " + myHealth.currentHealth + "/" + myHealth.maxHealth);
		
	}
}
