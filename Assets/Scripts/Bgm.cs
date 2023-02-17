using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bgm : MonoBehaviour
{
    public AudioSource select1;
    public AudioSource saw;
    public AudioSource appear1;
    public AudioSource cow;
    public AudioSource air1;
    public AudioSource bart;
    public AudioSource bart2;
    public AudioSource truck;
    public AudioSource airPlane;
    public AudioSource factory;
    public AudioSource steakSound;
    public AudioSource eatSound;
    public AudioSource childrenSound;
    public AudioSource engineSound;
    public AudioSource crySound;
    public AudioSource poop;

    public void Truck(int i)
    {
        if (i == 0) truck.Play();
        else truck.Pause();
    }
    public void Bart()
    {
        bart.Play();
    }
    public void Bart2()
    {
        bart2.Play();
    }
    public void Select1()
    {
        select1.Play();
    }
    public void Saw(int i)
    {
        if (i== 1) saw.Play();
        else saw.Pause();
    }
    public void Appear()
    {
        appear1.Play();
    }
    public void Cow()
    {
        cow.Play();
    }
    public void Air1()
    {
        air1.Play();
    }
    public void AirPlane(int i)
    {
        if (i == 1) airPlane.Play();
        else airPlane.Pause();
    }
    public void Factory()
    {
        factory.Play();
    }
    public void SteakSound()
    {
        steakSound.Play();
    }
    public void EatSound()
    {
        eatSound.Play();
    }
    public void ChildrenSound()
    {
        childrenSound.Play();
    }
    public void EngineSound()
    {
        engineSound.Play();
    }
    public void CrySound()
    {
        crySound.Play();
    }
    public void Poop()
    {
        poop.Play();
    }
}
