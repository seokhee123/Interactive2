using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orange : MonoBehaviour
{
    public GameObject earth;
    public GameObject cloud;
    public GameObject orange;
    bool isNext = false;
    private void OnMouseDown()
    {
        if (isNext == true)
        {
            earth.GetComponent<Animator>().enabled = true;
        }
        gameObject.GetComponent<Animator>().enabled = true;
        earth.SetActive(true);
        
        cloud.SetActive(true);
        orange.SetActive(true);
        isNext = true;

    }
}
