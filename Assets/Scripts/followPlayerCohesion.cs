using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[RequireComponent(typeof(followPlayerBoid))]

public class followPlayerCohesion : MonoBehaviour
{
    private followPlayerBoid boid;

    public float radius;

    // Use this for initialization
    void Start()
    {
        boid = GetComponent<followPlayerBoid>();
    }

    // Update is called once per frame
    void Update()
    {
        var boids = FindObjectsOfType<followPlayerBoid>();
        var average = Vector3.zero;
        var found = 0;
        foreach (var boid in boids.Where(b => b != boid))
        {
            var diff = boid.transform.position - this.transform.position;
            if (diff.magnitude < radius)
            {
                average += diff;
                found += 1;
            }
        }
        if (found > 0)
        {
            average = average / found;
            boid.velocity += Vector3.Lerp(Vector3.zero, average, (average.magnitude) / radius);
        }
    }
}
