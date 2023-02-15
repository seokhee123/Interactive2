using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodBeef : MonoBehaviour
{
    public GameObject beefTruck;

    private void OnMouseDown()
    {
        beefTruck.GetComponent<Animator>().enabled = true;
    }
}
