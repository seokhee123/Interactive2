using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grape : MonoBehaviour
{
    public GameObject grapeFruit;
    private void OnMouseDown()
    {
        grapeFruit.GetComponent<Animator>().enabled = true;
    }
}
