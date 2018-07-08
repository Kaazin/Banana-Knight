using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectHit : MonoBehaviour 
{
	public float damage;
	void OnTriggerEnter(Collider col)
	{
		if (col.tag == "Enemy") 
		{
			EnemyHealth enemyHealth = col.GetComponent<EnemyHealth> ();

			if (enemyHealth != null)
				enemyHealth.TakeDamage (damage);
		}
	}

}
