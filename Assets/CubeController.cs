using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour {

	private float speed = -0.2f;
	private float deadLine = -10;
	public AudioClip block;
	AudioSource audioSource;

	// Use this for initialization
	void Start () {
		audioSource = GetComponent<AudioSource> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (this.speed, 0, 0);
		if (transform.position.x < this.deadLine) {
			Destroy (gameObject);
		}

	}
	void OnCollisionEnter2D(Collision2D other){
		if (other.gameObject.tag == "UnityChan") {
			GetComponent<AudioSource> ().volume = 0;
		} 

		if (other.gameObject.tag == "Ground" || tag == "Cube") {
			audioSource.PlayOneShot (block);
		}
	}
}
