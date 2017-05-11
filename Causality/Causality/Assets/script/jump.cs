using UnityEngine;
using System.Collections;

public class jump : MonoBehaviour {

	public float jumpSpeed = 5f;
	public float forwardSpeed = 20;
	private Rigidbody body;
	//private InputState inputState;

	void Awake(){
		body = GetComponent<Rigidbody> ();
		//inputState = GetComponent<InputState> ();
	}

	// Update is called once per frame
	void Update () {

		//if(inputState.standing) {
		if(Input.GetButtonDown("X360_A") &&  body.velocity.y < 0.06 && body.velocity.y > -0.06) 
		{
			body.velocity = new Vector2(body.velocity.x, jumpSpeed);
			}
		if (Input.GetButtonDown ("X360_B")) {
			if (body.position.y > -50) {
				body.transform.position = new Vector3 (body.position.x, body.position.y - 100.5f, -25f);
			} else
				body.transform.position = new Vector3 (body.position.x, body.position.y + 100.5f, -25f);
			
			}
			if (Input.GetButtonDown ("X360_X")) {
				Debug.Log ("X");

		}
			if (Input.GetButtonDown ("X360_Y")) {
				Debug.Log ("Y");
}
		if (Input.GetButtonDown ("X360_DpadUp")) {
			Debug.Log ("DpadUp");
		}
		if (Input.GetButtonDown ("X360_DpadDown")) {
			Debug.Log ("DpadDown");
		}
		if (Input.GetButtonDown ("X360_DpadLeft")) {
			Debug.Log ("DpadLeft");
		}
		if (Input.GetButtonDown ("X360_DpadRight")) {
			Debug.Log ("DpadRight");
		}
		if (Input.GetButtonDown ("X360_Lstick")) {
			Debug.Log ("Lstick");
		}
		if (Input.GetButtonDown ("X360_Rstick")) {
			Debug.Log ("Rstick");
		}
		if (Input.GetButtonDown ("X360_Lbumper")) {
			Debug.Log ("Lbumper");
		}
		if (Input.GetButtonDown ("X360_Rbumper")) {
			Debug.Log ("Rbumper");
		}
		if (Input.GetButtonDown ("X360_Start")) {
			Debug.Log ("Start");
		}
		if (Input.GetButtonDown ("X360_Back")) {
			Debug.Log ("Back");
		}
}
	}
