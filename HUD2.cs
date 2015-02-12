using UnityEngine;
using System.Collections;

public class HUD2 : MonoBehaviour {

	Health2 myHealth2;
	
	void Awake()
	{
		myHealth2 = GetComponent<Health2>();
	}
	
	void OnGUI()
	{
		GUI.Label (new Rect(5, 240, 120, 20),  "Health: " + myHealth2.currentHealth2 + "/" + myHealth2.maxHealth2);
		
	}
} 