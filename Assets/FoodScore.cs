using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodScore : MonoBehaviour
{
    public GameObject blur;
    public GameObject foodScore;
    public GameObject market;

    private void OnMouseDown()
    {
        blur.SetActive(true);
        foodScore.SetActive(true);
        market.SetActive(false);
    }
}
