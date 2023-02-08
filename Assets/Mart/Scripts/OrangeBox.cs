using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class OrangeBox : MonoBehaviour
{
    public GameObject box;
    public GameObject boxFade;
    Animator anim;
    Animator anim1;
    private void Awake()
    {
        anim = box.GetComponent<Animator>();
        anim1 = boxFade.GetComponent<Animator>();
    }
    private void OnMouseDown()
    {
        anim.enabled = true;
        anim1.enabled = false;
    }
}
