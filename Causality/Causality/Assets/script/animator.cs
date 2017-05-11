using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animator : MonoBehaviour {
	Rigidbody rb;
		private Animator anim;
	public static bool push;
		// Use this for initialization
		void Start()
		{
			anim = this.GetComponent<Animator>();
			rb = this.GetComponent <Rigidbody> ();
		}

		// Update is called once per frame
		void Update()
		{
		

		Vector3 horizontal = rb.velocity;

		if (Input.GetAxis ("X360_LstickX") > 0.4) {
			anim.SetFloat ("speed", Input.GetAxis ("X360_LstickX"));
		} else if (Input.GetAxis ("X360_LstickX") > -0.4) {
			anim.SetFloat ("speed", Input.GetAxis ("X360_LstickX") * -1);
				
		} else {
			anim.SetFloat ("speed", 0);
		}
		if (push == true)
			{
			anim.SetBool("push", true);
			}

		}
	}

