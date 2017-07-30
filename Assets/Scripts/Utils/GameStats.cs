using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStats : MonoBehaviour {

	public static Vector2 speed;
	public static float distance;

	private static float initialSpeedX = 0;
	private static float initialSpeedY = 1;
	private static float maxSpeed = 5000;
	private static float initialDistance = 700;

	void Start() {
		GameStats.Reset ();
	}

	void Update() {
		GameStats.UpdateSpeed ();
		GameStats.UpdateDistance ();
	}

	public static void Reset() {
		speed = new Vector2 (initialSpeedX, initialSpeedY);
		distance = initialDistance;
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

	static void UpdateDistance () {
		distance -= (GameStats.speed.y * Time.deltaTime) * 3;
	}
}
