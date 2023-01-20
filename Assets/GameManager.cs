using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject ref1;
    public GameObject ref2;
    public GameObject ref3;
    public GameObject[] refObj;

    public GameObject melon;
    public GameObject melonPos;
    public GameObject melonPos2;
    bool isMelon = false;
    public GameObject melonPlate;
    public GameObject melonPlatePos;
    public GameObject under1;
    public GameObject under1Pos;
    public GameObject under2;
    public GameObject under2Pos;
    public GameObject watermelon;
    public GameObject watermelonPos;
    public GameObject watermelonPos2;
    bool isWatermelon = false;

    public GameObject milk;
    public GameObject milkPos;
    bool isMilk = false;
    public GameObject juice;
    public GameObject juicePos;
    bool isJuice = false;

    public GameObject[] food;

    public GameObject dirtyGround;
    public GameObject dirtyGround2;
    public GameObject clearSky;
    public GameObject dirtySky;

    public GameObject bowlWater;
    public GameObject goodFish;
    public GameObject goodFishLine;
    public GameObject goodFishLine2;

    public GameObject moveFish;
    public float fishHeight;

    public GameObject tree1;
    public GameObject tree2;
    public GameObject tree3;
    public GameObject tree4;

    public GameObject rabbitTree;
    public GameObject rabbitTree2;

    public GameObject[] flowers;
    public GameObject bee1;
    public GameObject bee2;
    public float height;
    public float time;

    public GameObject sheep;
    public GameObject chicken;
    public GameObject rabbit;

    bool isRabbit = false;
    public GameObject rabbitPos1;
    public GameObject rabbitPos2;
    public GameObject rabbitPos3;

    [SerializeField]
    public AnimationCurve curve1;
    public AnimationCurve curve2;

    public GameObject door;
    Animator anim;

    public GameObject rainbow;

    public GameObject[] factory;

    private void Awake()
    {
        anim = door.GetComponent<Animator>();
    }
    void Start()
    {
        StartCoroutine("movingFish");
        StartCoroutine("movingBee");
        StartCoroutine("GameStart");

    }

    IEnumerator GameStart()
    {
        anim.SetBool("isStart", true);
        yield return new WaitForSeconds(1f);
        StartCoroutine("EndRef");
    }

    IEnumerator Ref1()
    {
        ref2.SetActive(false);
        ref3.SetActive(true);
        yield return new WaitForSeconds(1f);
        StartCoroutine("EndRef");
    }

    IEnumerator EndRef()
    {
        //ref3.SetActive(false);
        door.SetActive(false);
        for (int i = 0; i < refObj.Length; i++)
        {
            refObj[i].SetActive(true);
        }
        yield return new WaitForSeconds(1f);
        StartCoroutine("Melon");
    }

    IEnumerator Melon()
    {
        melon.transform.position = Vector2.Lerp(melon.transform.position, melonPos.transform.position, 1f);
        melonPlate.transform.position = Vector2.Lerp(melonPlate.transform.position, melonPlatePos.transform.position, 1f);
        under1.transform.position = Vector2.Lerp(under1.transform.position, under1Pos.transform.position, 1f);
        under2.transform.position = Vector2.Lerp(under2.transform.position, under2Pos.transform.position, 1f);
        watermelon.transform.position = Vector2.Lerp(watermelon.transform.position, watermelonPos.transform.position, 1f);
        yield return new WaitForSeconds(1f);
        isMelon = true;
        isWatermelon = true;
        yield return new WaitForSeconds(1f);
        isMilk = true;
        isJuice = true;
        yield return new WaitForSeconds(1f);
        StartCoroutine("Food");
    }

    IEnumerator Food()
    {
        for (int i = 0; i < food.Length; i++)
        {
            for (float f = 0f; f < 1; f += 0.005f)
            {
                Color c = food[i].GetComponent<SpriteRenderer>().color;
                c.a = f;
                food[i].GetComponent<SpriteRenderer>().color = c;
                yield return null;
            }
            yield return new WaitForSeconds(0.5f);
        }
        yield return new WaitForSeconds(1f);
        StartCoroutine("Factory");
    }

    IEnumerator Factory()
    {
        for (int i = 0; i < factory.Length; i++)
        {
            for (float t = 1f; t > 0; t -= 0.005f)
            {
                Color c = factory[i].GetComponent<SpriteRenderer>().color;
                c.a = t;
                factory[i].GetComponent<SpriteRenderer>().color = c;
                yield return null;
            }
            yield return null;
        }

        yield return new WaitForSeconds(1f);
        StartCoroutine("Window2");
    }

    IEnumerator Window2() {
        for (float t = 1f; t > 0; t -= 0.005f)
        {
            Color cc = dirtyGround.GetComponent<SpriteRenderer>().color;
            cc.a = t;
            dirtyGround.GetComponent<SpriteRenderer>().color = cc;
            Color cc1 = dirtyGround2.GetComponent<SpriteRenderer>().color;
            cc1.a = t;
            dirtyGround2.GetComponent<SpriteRenderer>().color = cc1;
            yield return null;
        }
        yield return new WaitForSeconds(1f);
        StartCoroutine("Window3");
    }

    IEnumerator Window3()
    {
        for (float f = 0f; f < 1; f += 0.005f)
        {
            Color cc = tree1.GetComponent<SpriteRenderer>().color;
            cc.a = f;
            tree1.GetComponent<SpriteRenderer>().color = cc;
            Color cc1 = tree2.GetComponent<SpriteRenderer>().color;
            cc1.a = f;
            tree2.GetComponent<SpriteRenderer>().color = cc1;
            Color cc2 = tree3.GetComponent<SpriteRenderer>().color;
            cc2.a = f;
            tree3.GetComponent<SpriteRenderer>().color = cc2;
            Color cc3 = tree4.GetComponent<SpriteRenderer>().color;
            cc3.a = f;
            tree4.GetComponent<SpriteRenderer>().color = cc3;
            yield return null;
        }

        yield return new WaitForSeconds(1f);
        StartCoroutine("Flower");
    }

    IEnumerator Flower()
    {
        for (int i = 0; i < flowers.Length; i++)
        {
            for (float f = 0f; f < 1; f += 0.005f)
            {
                Color cc = flowers[i].GetComponent<SpriteRenderer>().color;
                cc.a = f;
                flowers[i].GetComponent<SpriteRenderer>().color = cc;
                yield return null;
            }
        }
        yield return new WaitForSeconds(1f);
        StartCoroutine("Window");
    }

    IEnumerator Window()
    {
        
        for (float f = 0f; f < 1; f += 0.005f)
        {
            Color c = clearSky.GetComponent<SpriteRenderer>().color;
            c.a = f;
            clearSky.GetComponent<SpriteRenderer>().color = c;
            yield return null;
        }
        dirtySky.SetActive(false);
        yield return new WaitForSeconds(1f);
        StartCoroutine("Sheep");
    }


    IEnumerator Sheep()
    {
        for (float f = 0f; f < 1; f += 0.005f)
        {
            Color cc = sheep.GetComponent<SpriteRenderer>().color;
            cc.a = f;
            sheep.GetComponent<SpriteRenderer>().color = cc;
            yield return null;
        }
        yield return new WaitForSeconds(1f);
        StartCoroutine("Chicken");
    }

    IEnumerator Chicken()
    {
        for (float f = 0f; f < 1; f += 0.005f)
        {
            Color cc = chicken.GetComponent<SpriteRenderer>().color;
            cc.a = f;
            chicken.GetComponent<SpriteRenderer>().color = cc;
            yield return null;
        }
        yield return new WaitForSeconds(1f);
        StartCoroutine("Rabbit");
    }

    IEnumerator Rabbit()
    {
        for (float f = 0f; f < 1; f += 0.005f)
        {
            Color cc = rabbitTree.GetComponent<SpriteRenderer>().color;
            cc.a = f;
            rabbitTree.GetComponent<SpriteRenderer>().color = cc;
            Color cc2 = rabbitTree2.GetComponent<SpriteRenderer>().color;
            cc2.a = f;
            rabbitTree2.GetComponent<SpriteRenderer>().color = cc2;
            yield return null;
        }
        rabbit.SetActive(true);
        isRabbit = true;
        yield return new WaitForSeconds(1f);
        StartCoroutine("Tree");
    }

    IEnumerator Tree()
    {
        for (float f = 0f; f < 1; f += 0.005f)
        {
            Color cc = bee1.GetComponent<SpriteRenderer>().color;
            cc.a = f;
            bee1.GetComponent<SpriteRenderer>().color = cc;
            Color cc1 = bee2.GetComponent<SpriteRenderer>().color;
            cc1.a = f;
            bee2.GetComponent<SpriteRenderer>().color = cc1;
            yield return null;
        }
        yield return new WaitForSeconds(1f);
        StartCoroutine("Bowl");
    }
    IEnumerator Bowl()
    {
        for (float t = 1f; t > 0; t -= 0.005f)
        {
            Color cc = bowlWater.GetComponent<SpriteRenderer>().color;
            cc.a = t;
            bowlWater.GetComponent<SpriteRenderer>().color = cc;
        }
        for (float f = 0f; f < 1; f += 0.005f)
        {
            Color cc1 = goodFish.GetComponent<SpriteRenderer>().color;
            cc1.a = f;
            goodFish.GetComponent<SpriteRenderer>().color = cc1;
            Color cc2 = goodFishLine.GetComponent<SpriteRenderer>().color;
            cc2.a = f;
            goodFishLine.GetComponent<SpriteRenderer>().color = cc2;
            Color cc3 = goodFishLine2.GetComponent<SpriteRenderer>().color;
            cc3.a = f;
            goodFishLine2.GetComponent<SpriteRenderer>().color = cc3;
            yield return null;
        }
        yield return new WaitForSeconds(1f);
        StartCoroutine("Bee");
    }

    IEnumerator Bee()
    {
        Vector2 startPos = bee1.transform.position;
        Vector2 startPos2 = bee2.transform.position;
        Vector2 targetPos = startPos + new Vector2(0, height);
        Vector2 targetPos2 = startPos2 + new Vector2(0, height);

        float timer = 0.0f;

        while(timer < time)
        {
            timer += Time.deltaTime;
            float percent = timer / time;
            bee1.transform.position = Vector2.Lerp(startPos, targetPos, curve1.Evaluate(percent));
            bee2.transform.position = Vector2.Lerp(startPos2, targetPos2, curve1.Evaluate(percent));
            yield return null;
        }

        timer = 0.0f;
        startPos = bee1.transform.position;
        targetPos = startPos - new Vector2(0, height);
        startPos2 = bee2.transform.position;
        targetPos2 = startPos2 - new Vector2(0, height);
        while (timer < time)
        {
            timer += Time.deltaTime;
            float percent = timer / time;
            bee1.transform.position = Vector2.Lerp(startPos, targetPos, curve2.Evaluate(percent));
            bee2.transform.position = Vector2.Lerp(startPos2, targetPos2, curve2.Evaluate(percent));
            yield return null;
        }
        yield return new WaitForSeconds(1f);
        StartCoroutine("Rainbow");
    }

    IEnumerator Rainbow()
    {
        /*float timer = 0.1f;
        while (timer < time)
        {
            timer += Time.deltaTime;
            rainbow.fillAmount = timer;
            yield return null;
        }
        yield return new WaitForSeconds(1f);*/
        for (float f = 0f; f < 1; f += 0.005f)
        {
            Color cc = rainbow.GetComponent<SpriteRenderer>().color;
            cc.a = f;
            rainbow.GetComponent<SpriteRenderer>().color = cc;
            yield return null;
        }
        yield return new WaitForSeconds(1f);
        //StartCoroutine("Rabbit");
    }


    private void Update()
    {
        if(isMelon == true)
        {
            melon.transform.position = Vector2.Lerp(melon.transform.position, melonPos2.transform.position, 0.01f);
        }
        if(isWatermelon == true)
        {
            watermelon.transform.position = Vector2.Lerp(watermelon.transform.position, watermelonPos2.transform.position, 0.01f);
        }
        if(isMilk == true)
        {
            milk.transform.position = Vector2.Lerp(milk.transform.position, milkPos.transform.position, 0.01f);
        }
        if (isJuice == true)
        {
            juice.transform.position = Vector2.Lerp(juice.transform.position, juicePos.transform.position, 0.01f);
        }
        if(isRabbit == true)
        {
            rabbit.transform.position = Vector2.Lerp(rabbit.transform.position, rabbitPos1.transform.position, 0.01f);
        }

        
        
    }

    IEnumerator movingFish()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
            Vector2 startPos = moveFish.transform.position;
            Vector2 targetPos = startPos + new Vector2(0, fishHeight);

            float timer = 0.0f;

            while (timer < time)
            {
                timer += Time.deltaTime;
                float percent = timer / time;
                moveFish.transform.position = Vector2.Lerp(startPos, targetPos, curve1.Evaluate(percent));
                yield return null;

            }

            timer = 0.0f;
            startPos = moveFish.transform.position;
            targetPos = startPos - new Vector2(0, fishHeight);
            while (timer < time)
            {
                timer += Time.deltaTime;
                float percent = timer / time;
                moveFish.transform.position = Vector2.Lerp(startPos, targetPos, curve2.Evaluate(percent));
                yield return null;
            }
            
        }
    }

    IEnumerator movingBee()
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
            Vector2 startPos = bee1.transform.position;
            Vector2 targetPos = startPos + new Vector2(0, fishHeight);

            float timer = 0.0f;

            while (timer < time)
            {
                timer += Time.deltaTime;
                float percent = timer / time;
                bee1.transform.position = Vector2.Lerp(startPos, targetPos, curve1.Evaluate(percent));
                yield return null;

            }

            timer = 0.0f;
            startPos = bee1.transform.position;
            targetPos = startPos - new Vector2(0, fishHeight);
            while (timer < time)
            {
                timer += Time.deltaTime;
                float percent = timer / time;
                bee1.transform.position = Vector2.Lerp(startPos, targetPos, curve2.Evaluate(percent));
                yield return null;
            }

        }
    }
}
