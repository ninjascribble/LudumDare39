using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplodeOnDestroy : MonoBehaviour {

	public GameObject prefab;

	void OnDestroy () {
		GameObjectUtil.Instantiate (prefab, gameObject.transform.position);
	}
}
