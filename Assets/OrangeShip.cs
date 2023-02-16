using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrangeShip : MonoBehaviour
{
    public GameObject orangeShip;

    private void OnMouseDown()
    {
        orangeShip.GetComponent<Animator>().enabled = true;
    }

}
