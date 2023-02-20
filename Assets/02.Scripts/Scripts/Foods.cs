using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Foods : MonoBehaviour
{
    public MartController ctrl;
    private void OnMouseDown()
    {
        ctrl.Market.SetActive(false);
        ctrl.Plane.SetActive(true);
    }
}
