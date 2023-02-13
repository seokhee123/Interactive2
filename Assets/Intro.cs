using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Intro : MonoBehaviour
{
    private void Start()
    {

    }
    private void OnMouseDown()
    {
        gameObject.GetComponent<Animator>().enabled = true;
    }
    void InTroScene()
    {
        SceneManager.LoadScene("Mart");
    }
}
