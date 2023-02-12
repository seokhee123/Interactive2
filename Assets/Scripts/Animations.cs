using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animations : MonoBehaviour
{
    public Scenario scenario;
    public Bgm bgm;

    int childCnt = 0;

    public void Truck(int i)
    {
        bgm.Truck(i);
    }
    public void Baart()
    {
        bgm.Bart();
    }
    public void Air1()
    {
        bgm.Air1();
    }
    public void Saw(int i)
    {
        bgm.Saw(i);
    }
    public void Cow()
    {
        bgm.Cow();
    }
    public void Appear()
    {
        bgm.appear1.Play();
    }
    public void AirPlane(int i)
    {
        bgm.AirPlane(i);
    }
    public void FirstEarthTree()
    {
        scenario.earth.SetBool("tree1", true);
    }
    public void SecondEarthTree()
    {
        scenario.earth.SetBool("tree2", true);
    }
    public void TruckON()
    {
        scenario.truck.SetBool("truckOn", true);
    }
    public void MeatFac()
    {
        scenario.meatFac.SetActive(true);
    }
    public void ThirdEarthTree()
    {
        scenario.earth.SetBool("tree3", true);
    }
    public void FourthEarthTree()
    {
        scenario.earth.SetBool("tree4", true);
    }
    public void FifthEarthTree()
    {
        scenario.earth.SetBool("tree5", true);
    }
    public void FactoryOn()
    {
        scenario.truckObj.SetActive(true);
    }
    public void MeathToHam()
    {
        //scenario.meat2.GetComponent<Animator>().SetBool("meatOut", true);
        scenario.steak.SetActive(true);
    }
    public void SteakToHam()
    {
        scenario.steak.GetComponent<Animator>().SetBool("steakToham", true);
    }
    public void Hamburger()
    {
        scenario.hamburger.SetActive(true);
    }
    public void Children()
    {
        scenario.children.SetActive(true); 
    }
    public void ChildEat()
    {
        if (childCnt == 0)
        {
            scenario.hamburger.SetActive(false);
            childCnt++;
        }
        else if (childCnt == 1)
        {
            scenario.hamburger2.SetActive(false);
            childCnt++;
        }
        else if (childCnt == 2)
        {
            gameObject.GetComponent<Animator>().SetBool("eat", false);
            gameObject.GetComponent<Animator>().SetBool("sick", true);
        }

    }
    public void HamburgerOn()
    {
        scenario.hamburger2.SetActive(true);
        scenario.hamburger3.SetActive(true);
    }
}
