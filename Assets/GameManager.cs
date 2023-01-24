using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int stage;
    public GameObject g;
    public GameObject ref1;
    public GameObject ref2;
    public GameObject ref3;
    public GameObject[] refObj;
    public GameObject doorAnim;

    public GameObject melon;
    public GameObject melonPos;
    public GameObject melonPos2;
    bool isMelon = false;
    bool isStart = false;
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

    public GameObject newScene;

    public GameObject changeMelon;
    public GameObject newMelon;
    private Vector2 originMelon;
    public GameObject changeWater;
    public GameObject newWater;
    private Vector2 originWater;
    public GameObject underBoxCover;
    public GameObject refColor;
    public GameObject melonLens;
    public GameObject waterLens;
    public GameObject house;
    public GameObject tree;
    public GameObject sea;
    public GameObject truck;
    bool isTruck;
    public GameObject truckScore;
    public GameObject PlaneScore;
    public GameObject[] treeScore;
    public GameObject[] seaScore;

    public GameObject planeObj;
    public GameObject plane;
    public GameObject planeColor;
    bool isPlane;

    public GameObject tableColor;
    public GameObject refColor2;

    
    
    private void Awake()
    {
        anim = door.GetComponent<Animator>();
        originMelon = changeMelon.transform.localScale;
        originWater = changeWater.transform.localScale;
    }
    void Start()
    {
        //GetChilds(g);
        StartCoroutine("movingBee", bee1);
        StartCoroutine("movingBee", bee2);
        StartCoroutine("movingFish");

    }

    IEnumerator Ref()
    {
        yield return null;
        FadeInChilds(refColor);
    }
    IEnumerator GameStart()
    {
        anim.SetBool("isStart", true);
        yield return new WaitForSeconds(1.3f);
        door.SetActive(false);
        for (int i = 0; i < refObj.Length; i++)
        {
            refObj[i].SetActive(true);
        }
        yield return new WaitForSeconds(1f);
    }


    IEnumerator Melon()
    {
        yield return new WaitForSeconds(1f);
        if (isStart == false)
        {
            melon.transform.position = Vector2.Lerp(melon.transform.position, melonPos.transform.position, 1f);
            melonPlate.transform.position = Vector2.Lerp(melonPlate.transform.position, melonPlatePos.transform.position, 1f);
            under1.transform.position = Vector2.Lerp(under1.transform.position, under1Pos.transform.position, 1f);
            under2.transform.position = Vector2.Lerp(under2.transform.position, under2Pos.transform.position, 1f);
            watermelon.transform.position = Vector2.Lerp(watermelon.transform.position, watermelonPos.transform.position, 1f);
            isStart = true;
        }
        
        
        StartCoroutine("Melon2");

    }

    IEnumerator Melon2()
    {
        yield return new WaitForSeconds(1f);
        isMelon = true;
        isWatermelon = true;
        
        isMilk = true;
        isJuice = true;
    }

    IEnumerator Scene()
    {
        yield return null;
        FadeInChilds(newScene);

    }

    IEnumerator Info()
    {
        changeWater.SetActive(false);
        changeMelon.SetActive(false);
        newWater.SetActive(true);
        newMelon.SetActive(true);
        underBoxCover.SetActive(false);
        for (float f = 0f; f < 1; f += 0.005f)
        {
            Color c = newWater.GetComponent<SpriteRenderer>().color;
            c.a = f;
            newWater.GetComponent<SpriteRenderer>().color = c;
            yield return null;
        }
        house.SetActive(true);
        StartCoroutine("FadeIn", house);
        tree.SetActive(true);
        StartCoroutine("FadeIn", tree);
        for(int i = 0; i < treeScore.Length; i++)
        {
            treeScore[i].SetActive(true);
            StartCoroutine("FadeIn", treeScore[i]);
        }
        yield return new WaitForSeconds(0.3f);

    }

    IEnumerator addMelon()
    {
        yield return null;
        melonLens.SetActive(true);
        StartCoroutine("FadeIn", melonLens);
        yield return null;
        truck.SetActive(true);
        StartCoroutine("FadeInChilds",truck);
        yield return new WaitForSeconds(1f);
        isTruck = true;
    }

    IEnumerator MelonTruck()
    {
        yield return null;
        StartCoroutine("FadeOutChilds", truck);
        yield return null;
        truckScore.SetActive(true);
        StartCoroutine("AddMelonTree");
    }
    IEnumerator AddMelonTree()
    {
        for (int i = 0; i < 2; i++)
        {
            treeScore[i].SetActive(true);
            for (float t = 1f; t > 0; t -= 0.005f)
            {
                Color c = treeScore[i].GetComponent<SpriteRenderer>().color;
                c.a = t;
                treeScore[i].GetComponent<SpriteRenderer>().color = c;
                yield return null;
            }
            yield return null;
        }
        sea.SetActive(true);
        StartCoroutine("FadeInChilds",sea);
    }

    IEnumerator Sea()
    {
        for (int i = 0; i < seaScore.Length; i++)
        {
            seaScore[i].SetActive(true);
            for (float f = 0f; f < 1; f += 0.005f)
            {
                Color c = seaScore[i].GetComponent<SpriteRenderer>().color;
                c.a = f;
                seaScore[i].GetComponent<SpriteRenderer>().color = c;
                yield return null;
            }
        }
    }

    IEnumerator AddWater()
    {
        yield return null;
        melonLens.SetActive(false);

        truckScore.SetActive(false);
        StartCoroutine("DelSea");
        
    }

    IEnumerator DelSea()
    {
        yield return null;
        for (int i = 0; i < seaScore.Length; i++)
        {
            Color cs = seaScore[i].GetComponent<SpriteRenderer>().color;
            cs.a = 0f;
            seaScore[i].GetComponent<SpriteRenderer>().color = cs;
        }
        for (int k = 0; k < treeScore.Length; k++)
        {
            Color cc = treeScore[k].GetComponent<SpriteRenderer>().color;
            cc.a = 255f;
            treeScore[k].GetComponent<SpriteRenderer>().color = cc;
        }
    }

    IEnumerator Plane()
    {
        waterLens.SetActive(true);
        StartCoroutine("FadeIn", waterLens);
        planeObj.SetActive(true);
        plane.SetActive(true);
        planeColor.SetActive(true);
        StartCoroutine("FadeIn", planeColor);
        isPlane = true;
        yield return new WaitForSeconds(0.1f);
        PlaneScore.SetActive(true);
        
    }

    IEnumerator AddWaterTree()
    {
        yield return null;
        planeObj.SetActive(false);
        sea.SetActive(true);
        for (int i = 0; i < treeScore.Length; i++)
        {
            treeScore[i].SetActive(true);
            for (float t = 1f; t > 0; t -= 0.005f)
            {
                Color c = treeScore[i].GetComponent<SpriteRenderer>().color;
                c.a = t;
                treeScore[i].GetComponent<SpriteRenderer>().color = c;
                yield return null;
            }
            yield return null;
        }
        
        StartCoroutine("FadeInChilds", sea);
    }

    IEnumerator DelScene()
    {
        truck.SetActive(false);
        doorAnim.SetActive(false);
        refColor.SetActive(false);
        refColor2.SetActive(true);
        yield return null;
        sea.SetActive(false);

        FadeOutChilds(newScene);
    }

    IEnumerator Food()
    {
        StartCoroutine("FadeIn", tableColor);
        for (int i = 0; i < food.Length; i++)
        {
            for (float f = 0f; f < 1; f += 0.005f)
            {
                Color c = food[i].GetComponent<SpriteRenderer>().color;
                c.a = f;
                food[i].GetComponent<SpriteRenderer>().color = c;
                yield return null;
            }
        }
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
        }

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

    }

    IEnumerator Flower()
    {
        for (int i = 0; i < flowers.Length; i++)
        {
            StartCoroutine("FadeIn", flowers[i]);
        }
        yield return null;
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
        StartCoroutine("FadeIn", rabbitTree);
        StartCoroutine("FadeIn", rabbitTree2);
        yield return null;
        rabbit.SetActive(true);
        StartCoroutine("FadeIn", rabbit);
        yield return null;
        isRabbit = true;
        yield return new WaitForSeconds(2f);
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
        //StartCoroutine("Bee");
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
        
        yield return new WaitForSeconds(1f);
        //StartCoroutine("Rabbit");
    }
    void FadeOutChilds(GameObject g)
    {
        SpriteRenderer[] childList = g.GetComponentsInChildren<SpriteRenderer>();
        foreach (SpriteRenderer child in childList)
        {
            StartCoroutine("FadeOutChild", child);
        }
    }
    IEnumerator FadeOutChild(SpriteRenderer child)
    {
        for (float t = 1f; t > 0; t -= 0.005f)
        {
            Color cc = child.GetComponent<SpriteRenderer>().color;
            cc.a = t;
            child.GetComponent<SpriteRenderer>().color = cc;
            yield return null;
        }
    }
    void FadeInChilds(GameObject g)
    {
        SpriteRenderer[] childList = g.GetComponentsInChildren<SpriteRenderer>();
        foreach (SpriteRenderer child in childList)
        {
            StartCoroutine("FadeInChild", child);
        }
    }
    IEnumerator FadeInChild(SpriteRenderer child)
    {
        for (float f = 0f; f < 1; f += 0.005f)
        {
            Color cc = child.GetComponent<SpriteRenderer>().color;
            cc.a = f;
            child.GetComponent<SpriteRenderer>().color = cc;
            yield return null;
        }
    }

    IEnumerator FadeIn(GameObject GO)
    {
        for (float f = 0f; f < 1; f += 0.005f)
        {
            Color cc = GO.GetComponent<SpriteRenderer>().color;
            cc.a = f;
            GO.GetComponent<SpriteRenderer>().color = cc;
            yield return null;
        }
    }

    IEnumerator FadeOut(GameObject GO)
    {
        for (float t = 1f; t > 0; t -= 0.005f)
        {
            Color cc = GO.GetComponent<SpriteRenderer>().color;
            cc.a = t;
            GO.GetComponent<SpriteRenderer>().color = cc;
            yield return null;
        }
    }

    private void Update()
    {
        if(stage == 1)
        {
            StartCoroutine("Ref");
        }
        else if(stage == 2)
        {
            StartCoroutine("GameStart");
        }
        else if (stage == 3)
        {
            StartCoroutine("Melon");
        }
        else if(stage == 4)
        {
            StartCoroutine("Scene");
        }
        else if(stage == 5)
        {
            StartCoroutine("Info");
        }
        else if(stage == 6)
        {
            StartCoroutine("addMelon");
        }
        else if(stage == 7)
        {
            StartCoroutine("MelonTruck");
        }
        else if(stage == 8)
        {
            StartCoroutine("AddWater");
        }
        else if(stage == 9)
        {
            StartCoroutine("Plane");
        }
        else if(stage == 10)
        {
            StartCoroutine("AddWaterTree");
        }
        else if(stage == 11)
        {
            StartCoroutine("DelScene");
        }
        else if (stage == 12)
        {
            StartCoroutine("Food");
        }
        else if(stage == 13)
        {
            StartCoroutine("Factory");
        }
        else if (stage == 14)
        {
            StartCoroutine("Window2");
        }
        else if(stage == 15)
        {
            StartCoroutine("Window3");
        }
        else if(stage == 16)
        {
            StartCoroutine("Flower");
        }
        else if(stage == 17)
        {
            StartCoroutine("Window");
        }

        if (isMelon == true)
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
        if(isTruck == true)
        {
            truck.transform.position = Vector2.Lerp(truck.transform.position, house.transform.position, 0.01f);
        }
        if (isPlane == true)
        {
            planeObj.transform.position = Vector2.Lerp(planeObj.transform.position, house.transform.position, 0.01f);
        }
        if(isRabbit == true)
        {
            rabbit.transform.position = Vector2.Lerp(rabbit.transform.position, rabbitPos1.transform.position, 0.01f);
        }

        
        
    }

    public void ButtonClick()
    {
        stage++;
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

    IEnumerator movingBee(GameObject bee)
    {
        while (true)
        {
            yield return new WaitForSeconds(1f);
            Vector2 startPos = bee.transform.position;
            Vector2 targetPos = startPos + new Vector2(0, fishHeight);

            float timer = 0.0f;

            while (timer < time)
            {
                timer += Time.deltaTime;
                float percent = timer / time;
                bee.transform.position = Vector2.Lerp(startPos, targetPos, curve1.Evaluate(percent));
                yield return null;

            }

            timer = 0.0f;
            startPos = bee.transform.position;
            targetPos = startPos - new Vector2(0, fishHeight);
            while (timer < time)
            {
                timer += Time.deltaTime;
                float percent = timer / time;
                bee.transform.position = Vector2.Lerp(startPos, targetPos, curve2.Evaluate(percent));
                yield return null;
            }

        }
    }
}
