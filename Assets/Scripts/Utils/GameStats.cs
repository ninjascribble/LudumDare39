using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStats : MonoBehaviour {

	public static Vector2 speed;
	public static float distance;
	public static int reserveFuel;

	private static float initialSpeedX = 0f;
	private static float initialSpeedY = 1f;
	private static float maxSpeed = 5000f;
	private static float initialDistance = 700f;
	private static int initialReserveFuel = 3;

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
		reserveFuel = initialReserveFuel;
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
