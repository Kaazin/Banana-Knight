using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
	public float maxHealth;
	public float currentHealth;
	public Transform bloodSpawn;
	public GameObject blood;
	bool isDead;
	void Awake () 
	{
		currentHealth = maxHealth;
	}
	
	public void TakeDamage(float damage)
	{
		currentHealth -= damage;
		Instantiate (blood, bloodSpawn.position, bloodSpawn.rotation);
		if (currentHealth <= 0 && !isDead)
			Death ();
	}

	void Death()
	{
		isDead = true;

		Destroy (gameObject);
	}
}
