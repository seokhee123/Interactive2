using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sign : MonoBehaviour
{
    public GameObject sign;

    public void SignOn()
    {
        sign.SetActive(true);
    }
}
