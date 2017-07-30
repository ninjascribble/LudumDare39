using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneOnInput : MonoBehaviour {

	public string scene;

	private bool acceptingInput = true;

	void Update () {
		if (acceptingInput && Input.anyKeyDown) {
			acceptingInput = false;
			SceneManager.LoadScene(scene);
		}
	}
}
