using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectFood : MonoBehaviour
{
    public Scenario scenario;
    public Bgm bgm;
    private void OnMouseDown()
    {
        scenario.ChangeScene();
        bgm.Select1();
    }
}
