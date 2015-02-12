using UnityEngine;
using System.Collections;

public class Alarmtrigger : MonoBehaviour {

	// Use this for initialization
	void OnTriggerEnter(Collider sphere){
		audio.Play ();
		animation.Play ();
	}
void OnTriggerExit (Collider sphere){
		audio.Stop ();
		animation.Stop ();
	}
}
