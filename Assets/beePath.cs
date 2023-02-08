using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;

public class beePath : MonoBehaviour
{
    public PathCreator pathCreator;
    public float speed = 1f;
    float distanceTravel;

    void Update()
    {
        distanceTravel += speed * Time.deltaTime;
        transform.position = pathCreator.path.GetPointAtDistance(distanceTravel);
        transform.rotation = pathCreator.path.GetRotationAtDistance(distanceTravel);
    }
}
