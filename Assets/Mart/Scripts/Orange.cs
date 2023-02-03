using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orange : MonoBehaviour
{
    public GameObject earth;
    public GameObject cloud;
    public GameObject orange;
    private void OnMouseDown()
    {
        earth.GetComponent<Animator>().enabled = true;
        cloud.SetActive(true);
        orange.SetActive(true);
    }
}
