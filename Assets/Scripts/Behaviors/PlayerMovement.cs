using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	private Rigidbody2D body;
	private const float MAX_VELOCITY = 100;
	private const int FORCE = 1200;
	private PlayerBurst playerBurst;
	private bool playerBurstEnabled;

	void Start() {
		body = GetComponent<Rigidbody2D>();
		playerBurst = GetComponent<PlayerBurst>();
		playerBurstEnabled = true;
	}

	void FixedUpdate() {
		float velocityDifference = Mathf.Abs(body.velocity.x) - MAX_VELOCITY;

		if (Input.GetKey ("left")) {
			body.AddForce (Vector2.left * FORCE, ForceMode2D.Force);
		} else if (Input.GetKey ("right")) {
			body.AddForce (Vector2.right * FORCE, ForceMode2D.Force);
		}

		if (playerBurstEnabled && Input.GetKey ("up")) {
			playerBurstEnabled = false;
			playerBurst.Perform();
			GameStats.reserveFuel--;
			StartCoroutine (EnablePlayerBurst ());
		}

		if (velocityDifference > 0) {
			if (body.velocity.x > 0) {
				body.AddForce(Vector2.left * velocityDifference, ForceMode2D.Impulse);
			} else {
				body.AddForce(Vector2.right * velocityDifference, ForceMode2D.Impulse);
			}
		}
	}

	IEnumerator EnablePlayerBurst () {
		yield return new WaitForSeconds (0.5f);

		if (GameStats.reserveFuel > 0) {
			playerBurstEnabled = true;
		}
	}
}