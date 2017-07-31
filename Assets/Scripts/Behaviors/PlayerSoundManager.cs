using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSoundManager : MonoBehaviour {

	public AudioSource playOnBoost;
	public AudioSource playOnDestroy;

	public void PlayBoostClip () {
		playOnBoost.Play ();
	}

	private void OnDestroy() {
		playOnDestroy.Play ();
	}
}
