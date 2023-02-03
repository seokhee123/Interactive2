using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class orangeFarm : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void AnimationPause()
    {
        Time.timeScale = 0;
    }

    private void OnMouseDown()
    {
        Time.timeScale = 1;

    }
}
