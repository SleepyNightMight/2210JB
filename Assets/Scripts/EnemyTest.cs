using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTest : MonoBehaviour
{
    public float horDistance = 1.0f;
    public float verDistance = 0.5f;
    public float speed = 0.4f;
    private float startTime;
    private Vector3 startingPosition;
    private Vector3 target;

    // Use this for initialization
    void Start()
    {
        this.startTime = Time.time;
        this.startingPosition = this.transform.position;
        this.target = this.startingPosition + new Vector3(this.horDistance, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currentPosition = this.transform.position;
        Vector3 newPosition = Vector3.MoveTowards(currentPosition, this.target, speed * Time.deltaTime);
        this.transform.position = newPosition;

        //print (this.target);
       
        
        if (newPosition == target)
        {
            if (newPosition.x == startingPosition.x)
            {
                if (((newPosition.y - startingPosition.y) / verDistance) % 2 == 0)
                    this.target = newPosition + new Vector3(this.horDistance, 0, 0);
               // Debug.Log(target);
                else
                    this.target = newPosition - new Vector3(0, this.verDistance, 0);
                Debug.Log(newPosition);
            }
            else
            {
                if (((newPosition.y - startingPosition.y) / verDistance) % 2 != 0)
                    this.target = newPosition - new Vector3(this.horDistance, 0, 0);
                //Debug.Log(horDistance);
                
                else
                    this.target = newPosition - new Vector3(0, this.verDistance, 0);
                Debug.Log(verDistance);
            }
        }
    }
}

