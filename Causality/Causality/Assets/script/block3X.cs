using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class block3X : MonoBehaviour {

	Rigidbody body;
	public GameObject player;
	public GameObject rightWall;

	// Use this for initialization
	void Start () {
		body = GetComponent<Rigidbody> ();
	}

	// Update is called once per frame
	void FixedUpdate ()
	{
		float difference = player.transform.position.x - this.transform.position.x;
		float differenceY = player.transform.position.y - this.transform.position.y;
		float rWallDifference = rightWall.transform.position.x - this.transform.position.x;
		this.transform.position = new Vector3 (blockXPosition.block3, this.transform.position.y, 0);
		if (rWallDifference > 2 || rWallDifference < -2) {
			if (differenceY < 0.3 && differenceY > -0.3) {
				if (difference < 1.3 && difference > 0) {
					if (Input.GetButton ("X360_X")) {
						blockXPosition.block3 = player.transform.position.x - (float)1.3;
					}
				}
				else if (difference > -1.3 && difference < -0) {
					if (Input.GetButton ("X360_X")) {
						blockXPosition.block3 = player.transform.position.x + (float)1.3;
					}
				}
			}
		}

	}
}
