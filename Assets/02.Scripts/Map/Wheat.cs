using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wheat : MonoBehaviour
{
    public GameObject wheat;

    private void OnMouseDown()
    {
        wheat.GetComponent<Animator>().enabled = true;
    }
}
