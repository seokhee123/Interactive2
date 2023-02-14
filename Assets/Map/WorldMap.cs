using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WorldMap : MonoBehaviour
{
    public GameObject worldMap;
    public GameObject worldMapBlur;
    public GameObject market;

    private void OnMouseDown()
    {
        market.SetActive(false);
        worldMapBlur.SetActive(true);
        worldMap.SetActive(true);
    }
}
