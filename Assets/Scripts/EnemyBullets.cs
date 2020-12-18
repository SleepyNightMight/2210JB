using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullets : MonoBehaviour
{
	private Transform bullet;
	public float speed;

	// Use this for initialization
	void Start()
	{
		bullet = GetComponent<Transform>();
	}

	void FixedUpdate()
	{
		bullet.position += Vector3.up * -speed;

		if (bullet.position.y <= -10)
			Destroy(bullet.gameObject);
	}

	void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.tag == "Player")
		{
			Destroy(collision.gameObject);
			Destroy(gameObject);
			GameOver.isPlayerDead = true;
		}
		
	}
}