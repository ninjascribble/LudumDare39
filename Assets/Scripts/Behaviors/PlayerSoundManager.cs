using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSoundManager : MonoBehaviour {

	public AudioSource playOnBoost;
	public AudioSource playOnDestroy;

	private void OnTriggerEnter2D(Collider2D collision) {
		if (collision.gameObject.tag == "booster") {
			playOnBoost.Play ();
		}
	}

	private void OnDestroy() {
		playOnDestroy.Play ();
	}
}
