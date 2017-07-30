using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shakable : MonoBehaviour {

	private bool isShaking = false;
	private Vector3 originalPosition;

	public void Shake(float amount, float duration) {
		if (!isShaking) {
			isShaking = true;
			originalPosition = transform.position;
			StartCoroutine (UpdateShake (amount, duration));
		}
	}

	public IEnumerator UpdateShake(float amount, float duration) {
		for (var t = duration; t > 0; t -= Time.deltaTime) {
			Vector3 position = originalPosition;

			position.x += Random.Range(-1, 1) * amount;
			position.y += Random.Range(-1, 1) * amount;
			transform.position = position;

			yield return t;
		}

		transform.position = originalPosition;
		isShaking = false;
	}
}
