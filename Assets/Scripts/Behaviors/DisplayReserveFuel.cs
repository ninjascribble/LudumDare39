using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayReserveFuel : MonoBehaviour {

	public Sprite[] sprites;

	private SpriteRenderer spriteRenderer;

	// Use this for initialization
	void Start () {
		spriteRenderer = GetComponent<SpriteRenderer> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (GameStats.reserveFuel >= 3) {
			spriteRenderer.sprite = sprites [0];
		} else if (GameStats.reserveFuel == 2) {
			spriteRenderer.sprite = sprites [1];
		} else if (GameStats.reserveFuel == 1) {
			spriteRenderer.sprite = sprites [2];
		} else if (GameStats.reserveFuel < 1) {
			spriteRenderer.sprite = sprites [3];
		}
	}
}
