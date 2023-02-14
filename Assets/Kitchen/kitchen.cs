using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kitchen : MonoBehaviour
{
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(HKY.URGSensorObjectDetector.OnNewObject);
    }



    void TimeScale()
    {
        Time.timeScale = 0;
    }

    void PartySoundOn()
    {
        KitchenSound.isParty = true;
    }

    void BoomSoundOn()
    {
        KitchenSound.isBoom = true;
    }

    void OpenSoundOn()
    {
        KitchenSound.isOpen = true;
    }

    void FoodSoundOn()
    {
        KitchenSound.isFood = true;
    }

    void WindowSoundOn()
    {
        KitchenSound.isWindow = true;
    }

    void RainbowSoundOn()
    {
        KitchenSound.isRainbow = true;
    }

    void RefOpenSound()
    {
        KitchenSound.isRefopen = true;
    }

    void CloseSound()
    {
        KitchenSound.isClosed = true;
    }

    void MagicSound()
    {
        KitchenSound.isMagic = true;
    }
}
