using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LazySly : MonoBehaviour
{
    public Vector3 velocity;
    public GameObject[] waypointArray;
    public float maxVelocity;
    int current = 1;
    public float speed = 0;
    int radius = 1;
    
    // Use this for initialization
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (velocity.magnitude > maxVelocity)
        {
            velocity = velocity.normalized * maxVelocity;
        }
        float step = speed * Time.deltaTime;
        this.transform.position += velocity * Time.deltaTime;
        this.transform.rotation = Quaternion.LookRotation(velocity);

        if (Vector3.Distance(waypointArray[current].transform.position, transform.position) < radius)
        {
            if(current < waypointArray.Length)
            {
                current += 1;
            }
            else
            {
                current = 1;
            }
            
        }
        this.transform.position = Vector3.MoveTowards(transform.position, waypointArray[current].transform.position, Time.deltaTime * speed);
    }
}
