﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PixelPerfectCamera : MonoBehaviour {

	public static float pixelsToUnits = 1f;
	public static float scale = 1f;

	public Vector2 nativeResolution = new Vector2(240, 160);

	void Awake () {
		var camera = GetComponent<Camera> ();

		if (camera.orthographic == true) {
			scale = Screen.height / nativeResolution.y;
			pixelsToUnits = 1f * scale;
			camera.orthographicSize = (Screen.height / 1.8f) / pixelsToUnits;
		}
	}
}
