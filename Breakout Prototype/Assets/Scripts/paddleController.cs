﻿using UnityEngine;
using System.Collections;

public class paddleController : MonoBehaviour {
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		transform.position = new Vector3 (Mathf.Clamp (transform.position.x, -12.5f, 12.5f),-10.0f,0.0f);
	}

	
}


