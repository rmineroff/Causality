using UnityEngine;
using System.Collections;

public class movement : MonoBehaviour {
	public int movementSpeed = -10;
	public int movementBackSpeed = -10;
	public int none = 0;
	float horz = 0;
	public SpriteRenderer lev;
	private Rigidbody body;
	Animator anim;
	void Awake(){
		body = GetComponent<Rigidbody> ();
	//	inputState = GetComponent<InputState> ();
		anim = GetComponent<Animator>();
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

		if (horz > 0)
			lev.flipX = false;
		else if (horz < 0)
			lev.flipX = true;

		Debug.Log (Input.GetAxis ("X360_RstickX") + ", " + Input.GetAxis ("X360_RstickY"));
		//anim.SetFloat (speed, horz);
	}
	
}
