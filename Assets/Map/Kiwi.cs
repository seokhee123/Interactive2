using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kiwi : MonoBehaviour
{
    public GameObject kiwiFruit;
    private void OnMouseDown()
    {
        kiwiFruit.GetComponent<Animator>().enabled = true;
    }
}
