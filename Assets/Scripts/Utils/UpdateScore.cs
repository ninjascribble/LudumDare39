using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
    
public class UpdateScore : MonoBehaviour {
    public Text distText;
    private float distance;

    // Update is called once per frame
    void Update () {
		distText.text = String.Format("{0:0.00} km", GameStats.distance);
	}
}
