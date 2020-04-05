using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LazyBoids : MonoBehaviour
{
    public Vector3 velocity;
    public GameObject[] waypointArray;
    public float maxVelocity;
    int current; 
    public float speed = 0;
    int radius = 7;
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
        
        if(Vector3.Distance(waypointArray[current].transform.position,transform.position) < radius)
        {
            if (current > 1)
            {
                current -= 1;
            }
            else
            {
                current = 7;
            }
        }
        this.transform.position = Vector3.MoveTowards(transform.position, waypointArray[current].transform.position, Time.deltaTime * speed);
    }
}
