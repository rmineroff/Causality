﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class block2p : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.position = new Vector3 (blockXPosition.block2, this.transform.position.y, 0);
	}
}
