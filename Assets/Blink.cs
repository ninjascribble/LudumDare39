using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blink : MonoBehaviour {

	public float seconds = 0.5f;

	private SpriteRenderer renderer;

	// Use this for initialization
	void Start () {
		renderer = GetComponent<SpriteRenderer> ();
		StartCoroutine (Step ());
	}

	IEnumerator Step () {
		yield return new WaitForSeconds (seconds);

		var color = renderer.color;

		color.a = (color.a == 1) ? 0 : 1;
		renderer.color = color;

		StartCoroutine (Step ());
	}
}
