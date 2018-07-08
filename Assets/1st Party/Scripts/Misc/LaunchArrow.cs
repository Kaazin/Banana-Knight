using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchArrow : MonoBehaviour 
{

	public Rigidbody arrowPrefab;
	public Transform barrelEnd;

	void Update ()
	{
		if(Input.GetKeyDown(KeyCode.X))
		{
			Rigidbody arrowInstance;
			arrowInstance = Instantiate(arrowPrefab, barrelEnd.position, transform.rotation) as Rigidbody;
			arrowInstance.velocity = transform.up * 100;
		}
	}
}
