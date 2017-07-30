using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPool : MonoBehaviour {

	public Recyclable prefab;

	private List<Recyclable> poolInstances = new List<Recyclable>();

	void Awake () {
		DontDestroyOnLoad(gameObject);
	}

	public Recyclable NextObject(Vector3 pos) {
		Recyclable instance = null;

		foreach (var go in poolInstances) {
			if (go.gameObject.activeSelf != true) {
				instance = go;
				instance.transform.position = pos;
			}
		}

		if (instance == null) {
			instance = CreateInstance (pos);
		}

		instance.Restart ();

		return instance;
	}

	private Recyclable CreateInstance(Vector3 pos) {

		var clone = GameObject.Instantiate (prefab);

		clone.transform.position = pos;
		clone.transform.parent = transform;

		poolInstances.Add (clone);

		return clone;
	}
}
