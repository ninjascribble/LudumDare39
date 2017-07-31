using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowTutorial : MonoBehaviour {

	void Start () {
		if (GameStats.showTutorial == false) {
			GameObjectUtil.Destroy (gameObject);
		}
		GameStats.showTutorial = false;
	}
}
