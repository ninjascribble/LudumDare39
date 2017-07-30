using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatedTexture : MonoBehaviour {

    private Vector2 offset = Vector2.zero;
    private Material material;

    // Use this for initialization
    void Start () {
        material = GetComponent<Renderer> ().material;
        offset = material.GetTextureOffset("_MainTex");
    }

    // Update is called once per frame
    void Update () {
		var step = GameStats.speed * Time.deltaTime;

		if (step.y < 0.002f) {
			step.y = 0.002f;
		}

		offset += step;
		material.SetTextureOffset("_MainTex", offset);
    }
}