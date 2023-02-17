using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodBeef : MonoBehaviour
{
    public GameObject beefTruck;
    public AudioSource sounds;

    private void OnMouseDown()
    {
        beefTruck.GetComponent<Animator>().enabled = true;
        sounds.Play();
    }

}
