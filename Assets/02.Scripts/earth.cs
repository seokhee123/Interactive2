using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class earth : MonoBehaviour
{
    private void OnMouseDown()
    {
        SceneManager.LoadScene("Meat_Ex1");
    }
}
