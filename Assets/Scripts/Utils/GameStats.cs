using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStats : MonoBehaviour {

	public static Vector2 speed;

	private static float initialSpeedX = 0;
	private static float initialSpeedY = 1;
	private static float maxSpeed = 50;

	void Start() {
		GameStats.speed = new Vector2 (initialSpeedX, initialSpeedY);
	}

	void Update() {
		GameStats.UpdateSpeed ();
	}

	static void UpdateSpeed() {
		if (speed.x > maxSpeed) {
			speed.x = maxSpeed;
		}

		if (speed.y > maxSpeed) {
			speed.y = maxSpeed;
		}

		if (speed.x > initialSpeedX) {
			speed.x = Mathf.Lerp (speed.x, initialSpeedX, Time.deltaTime);
		}

		if (speed.y > initialSpeedY) {
			speed.y = Mathf.Lerp (speed.y, initialSpeedY, Time.deltaTime);
		}
	}
}
