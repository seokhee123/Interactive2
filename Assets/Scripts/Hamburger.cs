using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hamburger : MonoBehaviour
{
    [SerializeField]
    private GameObject Child;
    int childNo = 0;
    private void OnMouseDown()
    {
        if (childNo == 0)
        {
            Child.SetActive(true);
            childNo++;
        }
        else if (childNo == 1)
        {
            Child.GetComponent<Animator>().SetBool("eat", true);
        }
    }
}
