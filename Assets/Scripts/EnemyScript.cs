using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public float opponentSpeed;
    public float speedModifier;
    
    // Start is called before the first frame update
    void Start()
    {
      

        Debug.Log("Speed Modifier: " + speedModifier);


    }

    // Update is called once per frame
    void Update()
    {
        float adjustedSpeed = opponentSpeed * speedModifier;
        transform.position += (Vector3.right * adjustedSpeed * Time.deltaTime);
        //transform.position += (Vector3.down * adjustedSpeed * Time.deltaTime);

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Bound1" || collision.tag == "Bound2")
        {
            //speedModifier = Random.Range(0.5f, 2);
            speedModifier = 1;
            opponentSpeed *= -1.0f;

           
        }
    }
}
