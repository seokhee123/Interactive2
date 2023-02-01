using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour
{
    public int aniStage;
    public Animator animator;
    bool lr;
    public GameObject[] table;
    public bool tableColor = false;
    Animation anim;

    public GameObject tab;

    void Start()
    {
        Color cc = table[0].GetComponent<SpriteRenderer>().color;
        cc = new Color(1, 1, 1, 1);
        table[0].GetComponent<SpriteRenderer>().color = cc;
        for (int i = 0; i < table.Length; i++)
        {
            tableColor = true;
            Color c = table[i].GetComponent<SpriteRenderer>().color;
            c.a = 1;
            c = new Color(1, 1, 1, 1);
            table[i].GetComponent<SpriteRenderer>().color = c;
            table[i].GetComponent<SpriteRenderer>().color = c;

        }
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            animator.SetTrigger("isTable");

        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            for (int i = 0; i < table.Length; i++)
            {
                tableColor = true;
                Color c = table[i].GetComponent<SpriteRenderer>().color;
                c.a = 255f;
                c = new Color(1, 1, 1, 1);
                table[i].GetComponent<SpriteRenderer>().color = c;
                table[i].GetComponent<SpriteRenderer>().color = c;

            }
            tab.SetActive(true);
            animator.SetTrigger("isWindow");

        }

        if(tableColor == true)
        {
            Color cc = table[0].GetComponent<SpriteRenderer>().color;
            cc = new Color(1, 1, 1, 1);
            table[0].GetComponent<SpriteRenderer>().color = cc;
            for (int i = 0; i < table.Length; i++)
            {
                tableColor = true;
                Color c = table[i].GetComponent<SpriteRenderer>().color;
                c.a = 1;
                c = new Color(1, 1, 1, 1);
                table[i].GetComponent<SpriteRenderer>().color = c;
                table[i].GetComponent<SpriteRenderer>().color = c;

            }


        }
        else if(aniStage == 2)
        {
            
        }
    }

}
