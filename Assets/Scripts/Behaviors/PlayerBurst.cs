using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBurst : MonoBehaviour {

	private Animator animator;
	private Rigidbody2D player;
	private PlayerSoundManager sounds;

	// Use this for initialization
	void Start () {
		animator = GetComponent<Animator>();
		player = GetComponent<Rigidbody2D>();
		sounds = GetComponent<PlayerSoundManager> ();
	}

	public void Perform () {
		animator.SetBool ("burst", true);
		player.AddForce (Vector2.up * 300, ForceMode2D.Impulse);
		GameStats.speed.y += 7;
		StartCoroutine (StopBursting ());
		sounds.PlayBoostClip ();
	}

	IEnumerator StopBursting () {
		yield return new WaitForSeconds (.4f);
		animator.SetBool ("burst", false);
	}
}
