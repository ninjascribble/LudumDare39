﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    private Animator animator;
    private Rigidbody2D player;

	// Use this for initialization
	void Start () {
        animator = GetComponent<Animator>();
        player = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        animator.SetBool("burst", true);
		player.AddForce(Vector2.up * 100, ForceMode2D.Impulse);
    }

    private void OnTriggerExit2D(Collider2D collision)
	{
		animator.SetBool("burst", false);
		GameObjectUtil.Destroy (collision.gameObject);
    }
}
