using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    private Animator animator;
    private Rigidbody2D player;
	private PlayerBurst playerBurst;

	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
        player = GetComponent<Rigidbody2D>();
		playerBurst = GetComponent<PlayerBurst> ();
	}

    private void OnTriggerEnter2D(Collider2D collision) {
		if (collision.gameObject.tag == "booster") {
			GameObjectUtil.Destroy (collision.gameObject);
			playerBurst.Perform ();
		}
    }

	private void OnCollisionEnter2D(Collision2D collision) {
		if (collision.gameObject.tag == "deadly") {
			GameObjectUtil.Destroy (collision.gameObject);
			GameObjectUtil.Destroy (gameObject);
		}
	}
}
