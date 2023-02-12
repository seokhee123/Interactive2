using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meat : MonoBehaviour
{
    public Scenario scenario;
    public Bgm bgm;
    int no = 0;
    private void OnMouseDown()
    {
        if (scenario.sceneNo == 0)
        {
            scenario.earthAnim.SetBool("earthOn", true);
            //scenario.nextAnim.SetBool("nextOn", true);
            scenario.sceneNo++;
        }
        else if (scenario.sceneNo == 1)
        {
            bgm.Select1();
            scenario.felling.SetActive(true);
            scenario.sceneNo++;
        }
        else if (scenario.sceneNo == 2)
        {
            scenario.felling.GetComponent<Animator>().SetBool("fellingOut", true);
            scenario.cow.SetActive(true);
            gameObject.SetActive(false);
            scenario.sceneNo++;
        }
        else if (scenario.sceneNo == 3)
        {
            scenario.cow.GetComponent<Animator>().SetBool("cowOut", true);
            scenario.sceneNo++;
        }
        else if (scenario.sceneNo == 4) 
        {
            scenario.factory.SetActive(true);
            scenario.sceneNo++;
        }

    }
}
