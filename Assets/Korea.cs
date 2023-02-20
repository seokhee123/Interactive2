using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Korea : MonoBehaviour
{
    private void OnMouseDown()
    {
        gameObject.GetComponentInParent<Animator>().SetBool("isKorea", true);
    }
}
