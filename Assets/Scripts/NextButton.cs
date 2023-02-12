using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextButton : MonoBehaviour
{
    public Scenario scenario;
    int sceneNo = 0;

    private void OnMouseDown()
    {
        if (sceneNo == 0)
        {
            scenario.felling.SetActive(true);
            sceneNo++;
        }
        else if (sceneNo == 1)
        {
            scenario.felling.GetComponent<Animator>().SetBool("fellingOut", true);
            scenario.cow.SetActive(true);
            sceneNo++;
        }
        else if (sceneNo == 2) 
        {
            scenario.meatFac.SetActive(true);
            sceneNo++;
        }
        else if (sceneNo == 3)
        {
            scenario.cow.GetComponent<Animator>().SetBool("cowOut", true);
            sceneNo++;
        }
        else if (sceneNo == 4)
        {
            scenario.factory.SetActive(true);
            sceneNo++;
        }
        else if (sceneNo == 5)
        {
            scenario.hamburger.SetActive(false);
            scenario.cow.SetActive(false);
            scenario.factory.SetActive(false);
            scenario.nextBtn.SetActive(false);
            scenario.children.SetActive(false);
            scenario.earthAnim.SetBool("end", true);
        }
    }
}
