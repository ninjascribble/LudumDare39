using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterTime : MonoBehaviour {

	public int seconds = 10;

	// Use this for initialization
	void Start () {
		StartCoroutine (Countdown ());
	}

	IEnumerator Countdown () {
		yield return new WaitForSeconds (seconds);
		GameObjectUtil.Destroy (gameObject);
	}
}
