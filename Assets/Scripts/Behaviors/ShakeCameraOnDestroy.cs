using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeCameraOnDestroy : MonoBehaviour {

	public Shakable shakable;
	public float amount = 16f;
	public float duration = 1f;

	private Vector3 originalCameraPosition;

	void OnDestroy() {
		shakable.Shake (amount, duration);
	}
}