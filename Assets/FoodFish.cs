using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodFish : MonoBehaviour
{
    public GameObject foodFish;

    private void OnMouseDown()
    {
        foodFish.GetComponent<Animator>().enabled = true;
    }
}
