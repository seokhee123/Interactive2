using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scenario : MonoBehaviour
{
    public GameObject[] screen;
    public Animator earthAnim;
    public Animator nextAnim;
    public Animator earth;
    public Animator truck;

    public GameObject truckObj;
    public GameObject meatFac;
    public GameObject felling;
    public GameObject cow;
    public GameObject factory;
    public GameObject hamburger;
    public GameObject hamburger2;
    public GameObject hamburger3;
    public GameObject meat2;
    public GameObject nextBtn;
    public GameObject children;
    public GameObject steak;

    public int sceneNo = 1;
    public void ChangeScene()
    {
        screen[0].SetActive(false);
        screen[1].SetActive(true);
    }
}
