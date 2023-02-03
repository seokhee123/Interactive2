using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class OrangeBox : MonoBehaviour
{
    public GameObject box;

    private void OnMouseDown()
    {
        box.SetActive(true);

    }
}
