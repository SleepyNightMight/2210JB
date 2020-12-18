using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript2 : MonoBehaviour
{

	private Transform player;
	public float playerSpeed;
	//public float maxBound, minBound;

	public GameObject shot;
	public Transform shotSpawn;
	public float fireRate;

	private float nextFire;

	// Use this for initialization
	void Start()
	{
		player = GetComponent<Transform>();
	}

	

	void FixedUpdate()
	{

	  float xValue = Input.GetAxis("Horizontal") * playerSpeed * Time.deltaTime;
		Vector3 xMovement = new Vector3(xValue, 0, 0);
		transform.position += xMovement;

	}

	void Update()
    {

		if (Input.GetKeyDown(KeyCode.Space) && Time.time > nextFire)
		{
			nextFire = Time.time + fireRate;
			Instantiate(shot, shotSpawn.position, shotSpawn.rotation);
		}
	}

}

