using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float playerSpeed;
    //GameObject bulletPrefab;
     
    //private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xValue = Input.GetAxis("Horizontal") * playerSpeed * Time.deltaTime;
        Vector3 xMovement = new Vector3(xValue, 0, 0);
        transform.position += xMovement;

      }
    
    }

   

