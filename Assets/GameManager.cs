using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
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
    bool isBox = false;
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
    public GameObject bowlColor;

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
    public GameObject housePos;
    public GameObject tree;
    public GameObject sea;
    public GameObject truck;
    bool isTruck;
    public GameObject truckScore;
    public GameObject PlaneScore;
    public GameObject[] treeScore;
    public GameObject seaScore;

    public GameObject planeObj;
    public GameObject plane;
    public GameObject planeColor;
    bool isPlane;

    public GameObject tableColor;
    public GameObject refColor2;

    bool isCo;
    
    
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
        //yield return new WaitForSeconds(1.3f);
        //door.SetActive(false);
        /*for (int i = 0; i < refObj.Length; i++)
        {
            refObj[i].SetActive(true);
        }*/
        yield return new WaitForSeconds(1f);;
    }


    IEnumerator Melon()
    {
        yield return new WaitForSeconds(1f);;
        isBox = true;

    }

    IEnumerator Melon2()
    {
        yield return new WaitForSeconds(1f);;
        isMelon = true;
        isWatermelon = true;
        
        isMilk = true;
        isJuice = true;
    }

    IEnumerator Scene()
    {
        
        FadeInChilds(newScene);
        yield return null;
    }

    IEnumerator Info()
    {
        changeWater.SetActive(false);
        changeMelon.SetActive(false);
        newWater.SetActive(true);
        newMelon.SetActive(true);
        underBoxCover.SetActive(false);

        FadeInChilds(newWater);
        house.SetActive(true);
        FadeInChilds(house);
        tree.SetActive(true);
        FadeInChilds(tree);

        seaScore.SetActive(true);
        FadeInChilds(seaScore);
        for (int i = 0; i < treeScore.Length; i++)
        {
            treeScore[i].SetActive(true);
            FadeInChilds(treeScore[i]);
        }
        yield return new WaitForSecondsRealtime(0.3f);

    }

    IEnumerator addMelon()
    {
        melonLens.SetActive(true);
        FadeInChilds(melonLens);
        truck.SetActive(true);
        FadeInChilds(truck);
        isTruck = true;
        yield return new WaitForSeconds(1f);
    }

    IEnumerator MelonTruck()
    {
        //FadeInChilds(truck);
        truck.SetActive(false);

        truckScore.SetActive(true);
        for (int i = 0; i < 2; i++)
        {
            treeScore[i].SetActive(true);
            for (float t = 1f; t > 0; t -= 0.01f)
            {
                Color c = treeScore[i].GetComponent<SpriteRenderer>().color;
                c.a = t;
                treeScore[i].GetComponent<SpriteRenderer>().color = c;
                yield return null;
            }
            yield return null;
        }
        sea.SetActive(true);
        FadeInChilds(sea);
        yield return new WaitForSeconds(1f);
    }




    IEnumerator AddWater()
    {
        melonLens.SetActive(false);

        truckScore.SetActive(false);
        seaScore.SetActive(true);
        sea.SetActive(false);
        for (int k = 0; k < treeScore.Length; k++)
        {
            Color cc = treeScore[k].GetComponent<SpriteRenderer>().color;
            cc.a = 255f;
            treeScore[k].GetComponent<SpriteRenderer>().color = cc;
        }
        yield return null;
    }


    IEnumerator Plane()
    {
        waterLens.SetActive(true);
        FadeInChilds(waterLens);
        planeObj.SetActive(true);
        plane.SetActive(true);
        planeColor.SetActive(true);
        FadeInChilds(planeColor);
        
        isPlane = true;
        //yield return new WaitForSecondsRealtime(0.1f);
        yield return new WaitForSeconds(1f);
    }

    IEnumerator AddWaterTree()
    {
        yield return null;
        planeObj.SetActive(false);

        PlaneScore.SetActive(true);

        for (int i = 0; i < treeScore.Length; i++)
        {
            treeScore[i].SetActive(true);
            for (float t = 1f; t > 0; t -= 0.01f)
            {
                Color c = treeScore[i].GetComponent<SpriteRenderer>().color;
                c.a = t;
                treeScore[i].GetComponent<SpriteRenderer>().color = c;
                yield return null;
            }
            yield return null;
        }
        sea.SetActive(true);
        FadeInChilds(sea);
        yield return null;
    }

    IEnumerator DelScene()
    {

        truck.SetActive(false);
        doorAnim.SetActive(false);
        refColor.SetActive(false);
        refColor2.SetActive(true);

        yield return null;
        FadeOutChilds(newScene);
    }

    IEnumerator Food()
    {
        FadeInChilds(tableColor);
        //StartCoroutine("FadeIn", tableColor);
        FadeInChilds(bowlColor);
        for (int i = 0; i < food.Length; i++)
        {
            for (float f = 0f; f < 1; f += 0.01f)
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
            for (float t = 1f; t > 0; t -= 0.01f)
            {
                Color c = factory[i].GetComponent<SpriteRenderer>().color;
                c.a = t;
                factory[i].GetComponent<SpriteRenderer>().color = c;

                yield return null;
            }

        }

    }

    IEnumerator Window2() {
        for (float t = 1f; t > 0; t -= 0.01f)
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
        for (float f = 0f; f < 1; f += 0.01f)
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
            FadeInChilds(flowers[i]);
        }
        yield return null;
    }

    IEnumerator Window()
    {
        
        for (float f = 0f; f < 1; f += 0.01f)
        {
            Color c = clearSky.GetComponent<SpriteRenderer>().color;
            c.a = f;
            clearSky.GetComponent<SpriteRenderer>().color = c;
            yield return null;
        }
        dirtySky.SetActive(false);
        yield return new WaitForSeconds(1f);
        for (float f = 0f; f < 1; f += 0.01f)
        {
            Color cc = sheep.GetComponent<SpriteRenderer>().color;
            cc.a = f;
            sheep.GetComponent<SpriteRenderer>().color = cc;
            yield return null;
        }
        yield return new WaitForSeconds(1f);
        for (float f = 0f; f < 1; f += 0.01f)
        {
            Color cc = chicken.GetComponent<SpriteRenderer>().color;
            cc.a = f;
            chicken.GetComponent<SpriteRenderer>().color = cc;
            yield return null;
        }
        yield return new WaitForSeconds(1f);
        FadeInChilds(rabbitTree);
        FadeInChilds(rabbitTree2);
        yield return null;
        rabbit.SetActive(true);
        FadeInChilds(rabbit);
        yield return null;
        isRabbit = true;
        yield return new WaitForSecondsRealtime(2f);
        StartCoroutine("Tree");
    }

    IEnumerator Tree()
    {
        for (float f = 0f; f < 1; f += 0.01f)
        {
            Color cc = bee1.GetComponent<SpriteRenderer>().color;
            cc.a = f;
            bee1.GetComponent<SpriteRenderer>().color = cc;
            Color cc1 = bee2.GetComponent<SpriteRenderer>().color;
            cc1.a = f;
            bee2.GetComponent<SpriteRenderer>().color = cc1;
            yield return null;
        }

        yield return new WaitForSeconds(1f);;
        StartCoroutine("Bowl");
    }
    IEnumerator Bowl()
    {
        for (float t = 1f; t > 0; t -= 0.01f)
        {
            Color cc = bowlWater.GetComponent<SpriteRenderer>().color;
            cc.a = t;
            bowlWater.GetComponent<SpriteRenderer>().color = cc;
        }
        for (float f = 0f; f < 1; f += 0.01f)
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
        yield return new WaitForSeconds(1f);;
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
        for (float t = 1f; t > 0; t -= 0.01f)
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
        for (float f = 0f; f < 1; f += 0.01f)
        {
            Color cc = child.GetComponent<SpriteRenderer>().color;
            cc.a = f;
            child.GetComponent<SpriteRenderer>().color = cc;
            yield return null;
        }
    }

    IEnumerator FadeIn(GameObject GO)
    {
        for (float f = 0f; f < 1; f += 0.01f)
        {
            Color cc = GO.GetComponent<SpriteRenderer>().color;
            cc.a = f;
            GO.GetComponent<SpriteRenderer>().color = cc;
            yield return new WaitForSeconds(0.1f);
        }

    }

    IEnumerator FadeOut(GameObject GO)
    {
        for (float t = 1f; t > 0; t -= 0.01f)
        {
            Color cc = GO.GetComponent<SpriteRenderer>().color;
            cc.a = t;
            GO.GetComponent<SpriteRenderer>().color = cc;
            yield return null;
        }
    }

    // 1. 애니메이션으로 바꾸기
    // 2. 냉장고 애니메이션 변경
    // 3. 코루틴 제거
    // 4. 
    
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
            StartCoroutine("Melon2");

        }
        else if(stage == 5)
        {
            StartCoroutine("Scene");

        }
        else if(stage == 6)
        {
            StartCoroutine("Info");

        }
        else if(stage == 7)
        {
            StartCoroutine("addMelon");
        }
        else if(stage == 8)
        {

            StartCoroutine("MelonTruck");
        }
        else if(stage == 9)
        {

            StartCoroutine("AddWater");
        }
        else if(stage == 10)
        {

            StartCoroutine("Plane");
        }
        else if(stage == 11)
        {

            StartCoroutine("AddWaterTree");
        }
        else if (stage == 12)
        {

            Destroy(sea);
            StartCoroutine("DelScene");

        }
        else if(stage == 13)
        {

            StartCoroutine("Food");
        }
        else if (stage == 14)
        {

            StartCoroutine("Factory");
        }
        else if(stage == 15)
        {

            StartCoroutine("Window2");
        }
        else if(stage == 16)
        {

            StartCoroutine("Window3");
        }
        else if(stage == 17)
        {

            StartCoroutine("Flower");
        }
        else if(stage == 18)
        {

            StartCoroutine("Window");
        }
        else if(stage == 19)
        {
            FadeInChilds(rainbow);
        }

        if (isBox == true)
        {
            melon.transform.position = Vector2.Lerp(melon.transform.position, melonPos.transform.position, 0.05f);
            melonPlate.transform.position = Vector2.Lerp(melonPlate.transform.position, melonPlatePos.transform.position, 0.05f);
            under1.transform.position = Vector2.Lerp(under1.transform.position, under1Pos.transform.position, 0.05f);
            under2.transform.position = Vector2.Lerp(under2.transform.position, under2Pos.transform.position, 0.05f);
            watermelon.transform.position = Vector2.Lerp(watermelon.transform.position, watermelonPos.transform.position, 0.05f);
        }
        if (isMelon == true)
        {
            melon.transform.position = Vector2.Lerp(melon.transform.position, melonPos2.transform.position, 0.05f);
        }
        if(isWatermelon == true)
        {
            watermelon.transform.position = Vector2.Lerp(watermelon.transform.position, watermelonPos2.transform.position, 0.05f);
        }
        if(isMilk == true)
        {
            milk.transform.position = Vector2.Lerp(milk.transform.position, milkPos.transform.position, 0.05f);
        }
        if (isJuice == true)
        {
            juice.transform.position = Vector2.Lerp(juice.transform.position, juicePos.transform.position, 0.05f);
        }
        if(isTruck == true)
        {
            truck.transform.position = Vector2.Lerp(truck.transform.position, housePos.transform.position, 0.05f);
        }
        if (isPlane == true)
        {
            planeObj.transform.position = Vector2.Lerp(planeObj.transform.position, housePos.transform.position, 0.05f);
        }
        if(isRabbit == true)
        {
            rabbit.transform.position = Vector2.Lerp(rabbit.transform.position, rabbitPos1.transform.position, 0.01f);
        }
        if(isCo == true)
        {
            sea.SetActive(false);
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
            yield return new WaitForSeconds(1f);;
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
            yield return new WaitForSeconds(1f);;
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
