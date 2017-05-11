using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lever : MonoBehaviour {
	public SpriteRenderer lev;

	// Use this for initialization
	void Start () {
		

	}
	
	// Update is called once per frame
	void Update () {
		if (blockXPosition.crank1 == true)
			lev.flipX = true;
			
	}
}
