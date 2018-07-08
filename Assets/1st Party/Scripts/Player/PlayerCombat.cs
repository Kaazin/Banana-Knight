using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
	public float time;

	Animator anim;

	void Awake ()
	{
		anim = GetComponentInChildren<Animator> ();
	}
	
	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.X) && PlayerMovement.isGrounded) 
		{
			anim.SetBool ("Attack1", true);
			StartCoroutine (Reset1 (time));	
		}

		if (Input.GetKeyDown (KeyCode.Z) && PlayerMovement.isGrounded) 
		{
			anim.SetBool ("Attack2", true);
			StartCoroutine (Reset2 (time));	
		}

	}

	IEnumerator Reset1(float time)
	{
		yield return new WaitForSeconds (time);
		anim.SetBool ("Attack1", false);
	}
	IEnumerator Reset2(float time)
	{
		yield return new WaitForSeconds (time);
		anim.SetBool ("Attack2", false);
	}
}
