using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    private Rigidbody2D body;
	// Use this for initialization
	void Start () {
        body = GetComponent<Rigidbody2D>();
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("left"))
        {
            body.AddForce(Vector3.left * 50, ForceMode2D.Impulse);
            
        } else if (Input.GetKeyDown("right"))
        {
            body.AddForce(Vector3.right * 200, ForceMode2D.Force);
        }
        else if (Input.GetKeyDown("up"))
        {
            body.AddForce(Vector3.up * 50, ForceMode2D.Impulse);
        }
        else if (Input.GetKeyDown("down"))
        {
            body.AddForce(Vector3.down * 50, ForceMode2D.Impulse);
        }

    }
}
