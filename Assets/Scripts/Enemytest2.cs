using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemytest2 : MonoBehaviour
{
	private Transform Invader;
	public float speed;

	public GameObject shot;
	//public Text winText;
	public float fireRate = 0.997f;

	// Use this for initialization
	void Start()
	{
		//winText.enabled = false;
		InvokeRepeating("MoveEnemy", 0.1f, 0.3f);
		Invader = GetComponent<Transform>();
	}

	void MoveEnemy()
	{
		Invader.position += Vector3.right * speed;

		foreach (Transform enemy in Invader)
		{
			if (enemy.position.x < -7.5 || enemy.position.x > 7.5)
			{
				speed = -speed;
				Invader.position += Vector3.down * 0.5f;
				return;
			}

			//EnemyBulletController called too?
			if (Random.value > fireRate)
			{
				Instantiate(shot, enemy.position, enemy.rotation);
			}


			if (enemy.position.y <= -4)
			{
				GameOver.isPlayerDead = true;
				Time.timeScale = 0;
			}
		}

		if (Invader.childCount == 1)
		{
			CancelInvoke();
			InvokeRepeating("MoveEnemy", 0.1f, 0.25f);
		}

		//if (enemyHolder.childCount == 0)
		//{
			//winText.enabled = true;
		//}
	}
}