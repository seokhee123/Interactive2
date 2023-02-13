using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KitchenSound : MonoBehaviour
{
    public static bool isParty;
    public static bool isBoom;
    public static bool isOpen;
    public static bool isFood;
    public static bool isWindow;
    public static bool isRainbow;
    public static bool isRefopen;
    public static bool isClosed;
    public static bool isMagic;
    public AudioSource partySound;
    public AudioSource boomSound;
    public AudioSource openSound;
    public AudioSource foodSound;
    public AudioSource windowSound;
    public AudioSource rainbowSound;
    public AudioSource refopenSound;
    public AudioSource closeSound;
    public AudioSource magicSound;

    void Update()
    {
        if (isBoom)
        {
            isBoom = false;
            boomSound.Play();
        }

        if (isParty)
        {
            isParty = false;
            partySound.Play();
        }
        if (isOpen)
        {
            isOpen = false;
            openSound.Play();
        }
        if (isFood)
        {
            isFood = false;
            foodSound.Play();
        }
        if (isWindow)
        {
            isWindow = false;
            windowSound.Play();
        }
        if (isRainbow)
        {
            isRainbow = false;
            rainbowSound.Play();
        }
        if (isRefopen)
        {
            isRefopen = false;
            refopenSound.Play();
        }
        if (isClosed)
        {
            isClosed = false;
            closeSound.Play();
        }
        if (isMagic)
        {
            isMagic = false;
            magicSound.Play();
        }
    }
}
