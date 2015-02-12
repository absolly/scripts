using UnityEngine;
using System.Collections;

public class bgmmenu : MonoBehaviour {
	public AudioClip EpicOrchestral;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	if (!audio.isPlaying) {
			audio.loop = true; audio.clip = EpicOrchestral; audio.Play();
		}
	}
}
