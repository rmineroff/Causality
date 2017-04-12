using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour {
	public int movementSpeed = -10;
	public int movementBackSpeed = -10;
	public int none = 0;
	float horz = 0;
	private Rigidbody body;
	void Awake(){
		body = GetComponent<Rigidbody> ();
	//	inputState = GetComponent<InputState> ();

	}

	// Update is called once per frame
	void Update ()
	{
		

		if (Input.GetAxis ("X360_LstickX") > 0.4 || Input.GetAxis ("X360_LstickX") < -0.4) {
		 horz = Input.GetAxis ("X360_LstickX") * 7;

		} 
		else {
			horz = 0;
		}
		
		Vector2 moving = new Vector2 (horz, body.velocity.y);
		body.velocity = moving;

		Debug.Log (Input.GetAxis ("X360_RstickX") + ", " + Input.GetAxis ("X360_RstickY"));
	}
	
}
