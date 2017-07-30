using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdjustMassWithGameSpeed : MonoBehaviour {

	public float modifier = 5f;

	private Rigidbody2D body2d;
	private float originalMass;

	void Start () {
		body2d = GetComponent<Rigidbody2D> ();
		originalMass = body2d.gravityScale;
	}

	void Update () {
		body2d.gravityScale = originalMass + GameStats.speed.y * modifier;
	}
}
