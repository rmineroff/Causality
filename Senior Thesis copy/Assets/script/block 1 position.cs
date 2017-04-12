using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class block1position : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.position = new Vector3((float)blockXPosition.block1, -22.37f, 0f);
		
	}
}
