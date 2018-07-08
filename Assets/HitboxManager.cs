using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitboxManager : MonoBehaviour
{
	public GameObject[] swordHitboxes;

	public BoxCollider axeHitbox;


	void EnableAxeHitbox()
	{
		axeHitbox.enabled = true;
	}
	void DisableAxeHitbox()
	{
		axeHitbox.enabled = false;
	}	

	void EnableswordHitbox()
	{
		foreach (GameObject h in swordHitboxes) 
		{
			h.SetActive (true);
		}
	}

	void DisableSwordHitbox()
	{
			foreach (GameObject h in swordHitboxes) 
			{
				h.SetActive (false);
			}
	}

}
