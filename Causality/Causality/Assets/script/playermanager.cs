using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermanager: MonoBehaviour {
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
		push = false;

		Vector3 horizontal = rb.velocity;

		if (horizontal.x > 0)
		{
			anim.SetFloat("speed", horizontal.x);
		}
		else if (horizontal.x < 0)
		{
			anim.SetFloat("speed", horizontal.x * -1);

		}
		if (push == true)
		{
			anim.SetBool("push", true);
		}

	}
}

