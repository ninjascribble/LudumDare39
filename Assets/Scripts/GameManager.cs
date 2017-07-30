using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	void Update () {
		if (GameStats.distance <= 0) {
			UnloadEverything ();
			GameStats.Reset ();
			SceneManager.LoadScene("WinScreen");
		}
	}

	void UnloadEverything () {
		GameObject[] everything = GameObject.FindObjectsOfType (typeof(GameObject)) as GameObject[];

		for (var i = 0; i < everything.Length; i++) {
			Destroy(everything [i]);
		}
	}
}
