using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOffscreen : MonoBehaviour {

	public float offset = 64f;
	public delegate void OnDestroy ();
	public event OnDestroy DestroyCallback;

	private bool offscreen;
	private float offscreenX = 0;
	private float offscreenY = 0;
	private Rigidbody2D body2d;

	void Awake () {
		body2d = GetComponent<Rigidbody2D> ();
	}

	// Use this for initialization
	void Start () {
		// Get the actual pixels of the screen based on current resolution
		offscreenX = Screen.width / PixelPerfectCamera.pixelsToUnits / 2 + offset;
		offscreenY = Screen.height / PixelPerfectCamera.pixelsToUnits / 2 + offset;
	}

	// Update is called once per frame
	void Update () {
		var posX = transform.position.x;
		var posY = transform.position.y;
		var dirX = body2d.velocity.x;
		var dirY = body2d.velocity.y;

		if (Mathf.Abs (posX) > offscreenX) {
			offscreen = (dirX <= 0 && posX < -offscreenX || dirX >= 0 && posX > offscreenX);
		}

		if (Mathf.Abs (posY) > offscreenY) {
			offscreen = (dirY <= 0 && posY < -offscreenY || dirY >= 0 && posY > offscreenY);
		}

		if (offscreen == true) {
			OnOutOfBounds ();
		}
	}

	void OnOutOfBounds () {
		if (DestroyCallback != null) {
			DestroyCallback ();
		}

		offscreen = false;

		GameObjectUtil.Destroy (gameObject);
	}
}
