using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orange : MonoBehaviour
{
    public GameObject earth;
    public GameObject cloud;
    public GameObject orange;
    bool isNext = false;
    public GameObject orangeFade;

    Animator anim;

    private void Start()
    {
        cloud.SetActive(true);
        earth.SetActive(true);
        orange.SetActive(true);
        gameObject.GetComponent<Animator>().enabled = true;
    }

    private void OnMouseDown()
    {
        if (isNext == true)
        {




        }
        earth.GetComponent<Animator>().enabled = true;
        gameObject.GetComponent<Animator>().enabled = true;
        earth.SetActive(true);
        orangeFade.GetComponent<Animator>().enabled = true;
        cloud.SetActive(true);
        orange.SetActive(true);
        isNext = true;
        
    }

    void OrangeSoundOn()
    {
        SoundManager.isSound = true;
    }
}
