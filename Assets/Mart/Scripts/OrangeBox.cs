using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class OrangeBox : MonoBehaviour
{
    public GameObject box;
    Animator anim;
    private void Awake()
    {
        anim = box.GetComponent<Animator>();
    }
    private void OnMouseDown()
    {
        anim.enabled = true;

    }
}
