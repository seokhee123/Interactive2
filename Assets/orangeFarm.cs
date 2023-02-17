using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orangeFarm : MonoBehaviour
{
    public GameObject orangeFade;
    public GameObject orangeBox;
    Animator anim;
    Animator anim1;
    // Start is called before the first frame update
    void Start()
    {
        anim = orangeFade.GetComponent<Animator>();
        anim1 = orangeBox.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void AnimationPause()
    {
        Time.timeScale = 0;
        //gameObject.GetComponent<Animator>().speed= 0;
        anim.enabled = true;
    }

    private void OnMouseDown()
    {
        Time.timeScale = 1;
        //gameObject.GetComponent<Animator>().speed = 0;
        anim.enabled = false;
        Color c = anim.GetComponent<SpriteRenderer>().color;
        c.a = 1;
        anim.GetComponent<SpriteRenderer>().color = c;
    }

    void OrangeBox()
    {
        anim1.enabled = true;
    }

    void OrangeSoundOn()
    {
        SoundManager.isSound = true;
    }

    void PlaneSoundOn()
    {
        SoundManager.isPlaneSound = true;
    }

    void PlaneSoundOff()
    {
        SoundManager.isPlaneStop = true;
    }

    void TreeSoundOn()
    {
        SoundManager.isTree = true;
    }

    void FactorySoundOn()
    {
        SoundManager.isFac = true;
    }

    void TruckSoundOn()
    {
        SoundManager.isTruck = true;
    }
    
    void TruckSoundOff()
    {
        SoundManager.isTruckStop = true;
    }

    void SeaSoundOn()
    {
        SoundManager.isSea = true;
    }

    void SeagulSound()
    {
        SoundManager.isSeagul = true;
    }
}
