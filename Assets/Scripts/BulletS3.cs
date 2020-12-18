using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletS3 : MonoBehaviour
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
		bullet.position += Vector3.up * speed;

		if (bullet.position.y >= 10)
			Destroy(gameObject);
	}

	void OnCollisionEnter2D(Collision2D other)
	{
		if (other.gameObject.name == "Enemy03")
		{
			Destroy(other.gameObject);
			Destroy(gameObject);

		}
	}
}
