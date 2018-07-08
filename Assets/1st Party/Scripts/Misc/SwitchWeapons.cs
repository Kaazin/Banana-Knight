using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchWeapons : MonoBehaviour
{
	Animator anim;

	public int swordLayer;
	public int axeLayer;
	public int bowLayer;

	public GameObject[] Weapons;

	void Awake () 
	{
		anim = GetComponentInChildren<Animator> ();
		foreach (GameObject w in Weapons) 
		{
			w.SetActive (false);
		}
		Weapons [0].SetActive (true);
	}
	
	void Update () 
	{
		if (Input.GetKeyDown (KeyCode.Tab)) 
		{
			SwapWeapons ();
		}
	}

	void SwapWeapons()
	{
		if (Weapons [0].activeSelf && !Weapons [1].activeSelf  && !Weapons[2].activeSelf) 
		{
			foreach (GameObject w in Weapons) 
			{
				w.SetActive (false);
			}
			Weapons [1].SetActive (true);

			anim.SetLayerWeight (swordLayer, 0);
			anim.SetLayerWeight (axeLayer,  1);
			anim.SetLayerWeight (bowLayer, 0);
		}

		else if (Weapons [1].activeSelf && !Weapons [0].activeSelf  && !Weapons[2].activeSelf) 
		{
			foreach (GameObject w in Weapons) 
			{
				w.SetActive (false);
			}
			Weapons [2].SetActive (true);

			anim.SetLayerWeight (swordLayer, 0);
			anim.SetLayerWeight (axeLayer,  0);
			anim.SetLayerWeight (bowLayer, 1);


		}		

		else if (Weapons [2].activeSelf && !Weapons [0].activeSelf  && !Weapons[1].activeSelf) 
		{
			foreach (GameObject w in Weapons) 
			{
				w.SetActive (false);
			}
			Weapons [0].SetActive (true);
			anim.SetLayerWeight (swordLayer, 1);
			anim.SetLayerWeight (axeLayer,  0);
			anim.SetLayerWeight (bowLayer, 0);


		}
	}
}
