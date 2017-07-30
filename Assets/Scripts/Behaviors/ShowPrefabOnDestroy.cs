using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowPrefabOnDestroy : MonoBehaviour {

	public GameObject prefab;

	void OnDestroy() {
		GameObjectUtil.Instantiate (prefab, Vector3.zero);
	}
}