using UnityEngine;
using System.Collections;

public class follow : MonoBehaviour {
	public Transform player;
	public Vector3 offset;

	void Update () 
	{
		transform.position = new Vector3 (player.position.x + offset.x, player.transform.position.y, offset.z);

	}
}
