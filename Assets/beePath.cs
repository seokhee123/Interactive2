using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;

public class beePath : MonoBehaviour
{
    /*public PathCreator pathCreator;
    public float speed = 1f;
    float distanceTravel;

    void Update()
    {
        distanceTravel += speed * Time.deltaTime;
        transform.position = pathCreator.path.GetPointAtDistance(distanceTravel);
        transform.rotation = pathCreator.path.GetRotationAtDistance(distanceTravel);
    }
    */

    public Transform Target;
    public bool isbee;

    void Update()
    {
        if (isbee)
        {
            transform.RotateAround(Target.position, Vector3.forward, 20 * Time.deltaTime);
        }
        else
        {
            transform.RotateAround(Target.position, Vector3.back, 20 * Time.deltaTime);
        }
    }
}
