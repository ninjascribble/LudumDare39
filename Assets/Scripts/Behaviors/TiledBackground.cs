﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiledBackground : MonoBehaviour {

	public int textureSize = 128; // Must be a power of 2
	public bool scaleHorizontally = true;
	public bool scaleVertically = true;

	// Use this for initialization
	void Start () {
		var newWidth = !scaleHorizontally ? 1 : Mathf.Ceil (Screen.width * 1.5f / (textureSize * PixelPerfectCamera.scale));
		var newHeight = !scaleVertically ? 1 : Mathf.Ceil (Screen.height * 1.5f / (textureSize * PixelPerfectCamera.scale));

		transform.localScale = new Vector3 (newWidth * textureSize, newHeight * textureSize, 1);

		GetComponent<Renderer> ().material.mainTextureScale = new Vector3 (newWidth, newHeight, 1);
	}
}
