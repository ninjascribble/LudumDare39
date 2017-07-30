using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IRecyclable {
	void Restart();
	void Shutdown();
}

public class Recyclable : MonoBehaviour {

	private List<IRecyclable> recyclableChildren = new List<IRecyclable> ();

	void Awake () {
		foreach (var component in GetComponents<MonoBehaviour> ()) {
			if (component is IRecyclable) {
				recyclableChildren.Add (component as IRecyclable);
			}
		}
	}

	public void Restart () {
		gameObject.SetActive (true);

		foreach (var component in recyclableChildren) {
			component.Restart ();
		}
	}

	public void Shutdown () {
		gameObject.SetActive (false);

		foreach (var component in recyclableChildren) {
			component.Shutdown ();
		}
	}
}
