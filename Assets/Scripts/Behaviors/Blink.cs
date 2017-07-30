using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blink : MonoBehaviour {

	public float seconds = 0.5f;

	private SpriteRenderer renderer2d;

	// Use this for initialization
	void Start () {
		renderer2d = GetComponent<SpriteRenderer> ();
		StartCoroutine (Step ());
	}

	IEnumerator Step () {
		yield return new WaitForSeconds (seconds);

		var color = renderer2d.color;

		color.a = (color.a == 1) ? 0 : 1;
		renderer2d.color = color;

		StartCoroutine (Step ());
	}
}
