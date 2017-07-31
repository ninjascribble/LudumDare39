using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneOnInput : MonoBehaviour {

	public string scene;
	public float delaySeconds = 0f;

	private bool acceptingInput = false;

	void Start () {
		StartCoroutine (BeginAcceptingInput ());
	}

	IEnumerator BeginAcceptingInput () {
		yield return new WaitForSeconds (delaySeconds);
		acceptingInput = true;
	}

	void Update () {
		if (acceptingInput && Input.anyKeyDown) {
			acceptingInput = false;
			SceneManager.LoadScene(scene);
		}
	}
}
