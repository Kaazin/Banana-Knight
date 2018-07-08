using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour 
{
	public float speed;
	public float jumpForce;
	Rigidbody rb;

	Vector3 dir;

	Animator anim;

	public static bool isGrounded;

	void Awake ()
	{
		rb = GetComponent<Rigidbody> ();
	}

	void Update () 
	{
		Debug.Log (isGrounded);
		float moveV = Input.GetAxis ("Vertical") * speed;
		float moveH = Input.GetAxis ("Horizontal") * speed;


		dir = new Vector3 (moveH, rb.velocity.y, moveV);


		if ((moveV != 0 || moveH != 0) && isGrounded) 
		{
			transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(dir), 1f);
		}

		rb.velocity = dir;

		if (isGrounded && Input.GetButtonDown ("Jump"))
			Jump ();
		else if (!isGrounded)
			dir.y = 0;

	}

	void OnCollisionEnter(Collision col)
	{
		if (col.transform.tag == "Ground") 
		{
			isGrounded = true;
		}
	}

	void Jump()
	{
		rb.velocity = new Vector3 (dir.x, jumpForce, dir.z);
		isGrounded = false;
	}
}
