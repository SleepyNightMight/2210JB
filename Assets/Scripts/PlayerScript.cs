using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    public float playerSpeed;
    //private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        //scoreKeeper = GetComponent<PlayerScoreKeeper>();
        //rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float xValue = Input.GetAxis("Horizontal") * playerSpeed * Time.deltaTime;
        Vector3 xMovement = new Vector3(xValue, 0, 0);
        //Vector3 moveDirection = new Vector3(xValue, 0.0f, 0.0f);
        // Vector3.moveDirection = new Vector3(xValue,0.0f,0.0f); 
        //rb.AddForce(moveDirection, ForceMode2D.Force);
        transform.position += xMovement;

    }
   
}
