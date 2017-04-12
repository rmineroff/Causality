using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crank : MonoBehaviour {
	
	Rigidbody body;
	public GameObject player;
	// Use this for initialization
	void Start () {
		body = GetComponent<Rigidbody> (); 
	}
	
	// Update is called once per frame
	void Update () {
		float difference = player.transform.position.x - this.transform.position.x;
		float differenceY = player.transform.position.y - this.transform.position.y;
		if (differenceY < 0.5 && differenceY > -0.5) {
			if (difference < 2 && difference > -2) {
				if (Input.GetButton ("X360_X")) {
					blockXPosition.crank1 = true;
				}
			}
		}

		
	}
}
