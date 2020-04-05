using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayerBoid : MonoBehaviour
{
    public Vector3 velocity;
    public float maxVelocity;
    public GameObject Player;
    public float speed = 0;
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
        this.transform.position = Vector3.MoveTowards(this.transform.position, Player.transform.position, step);
    }
}
