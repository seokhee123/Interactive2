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

}
