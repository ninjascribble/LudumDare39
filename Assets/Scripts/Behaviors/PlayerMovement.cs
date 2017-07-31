using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
	private Rigidbody2D body;
	private const float MAX_VELOCITY = 100;
	private const int FORCE = 1200;
	private PlayerBurst playerBurst;

	void Start() {
		body = GetComponent<Rigidbody2D>();
		playerBurst = GetComponent<PlayerBurst>();
	}

	void FixedUpdate() {
		float velocityDifference = Mathf.Abs(body.velocity.x) - MAX_VELOCITY;

		if (Input.GetKey ("left")) {
			body.AddForce (Vector2.left * FORCE, ForceMode2D.Force);
		} else if (Input.GetKey ("right")) {
			body.AddForce (Vector2.right * FORCE, ForceMode2D.Force);
		} else if (Input.GetKeyDown ("up") && GameStats.reserveFuel > 0) {
			playerBurst.Perform();
			GameStats.reserveFuel--;
		}

		if (velocityDifference > 0) {
			if (body.velocity.x > 0) {
				body.AddForce(Vector2.left * velocityDifference, ForceMode2D.Impulse);
			} else {
				body.AddForce(Vector2.right * velocityDifference, ForceMode2D.Impulse);
			}
		}
	}
}