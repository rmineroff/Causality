using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followY : MonoBehaviour {
	
	public Transform player;
	public Vector3 offset;

	void Update () 
	{
		transform.position = new Vector3 (this.transform.position.x, player.position.y + offset.y, offset.z);

	}
}
