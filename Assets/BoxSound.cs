using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxSound : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void BoxSoundOn()
    {
        SoundManager.isBox = true;
    }

    void FactorySoundOn()
    {
        SoundManager.isFac = true;
    }

    void TreeSoundOn()
    {
        SoundManager.isTree = true;
    }

    void SeaSoundOn()
    {
        SoundManager.isSea = true;
    }
}
