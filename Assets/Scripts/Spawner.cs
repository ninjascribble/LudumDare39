using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	public GameObject[] prefabs;
	public float delay = 2f;
	public bool active = true;
	public Vector2 delayRange = new Vector2 (1, 2);

	// Use this for initialization
	void Start () {
		ResetDelay ();
		StartCoroutine (Spawn ());
	}

	IEnumerator Spawn () {
		yield return new WaitForSeconds (delay);

		if (active) {
			var position = transform.position;

			position.y += 100;

			GameObjectUtil.Instantiate (prefabs [Random.Range (0, prefabs.Length)], position);
			ResetDelay ();
		}

		StartCoroutine (Spawn ());
	}

	void ResetDelay () {
		delay = Random.Range (delayRange.x, delayRange.y);
	}
}
