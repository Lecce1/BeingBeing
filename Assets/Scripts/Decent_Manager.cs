using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class Decent_Manager : MonoBehaviour
{
    public GameObject tutorial;
    public GameObject tutorial_Notice;
    public GameObject tutorial_True;
    public GameObject tutorial_Interpret;
    public GameObject tutorial_Sentence;
    public GameObject sentence;
    public GameObject game;
    public GameObject[] stage1_Buttons;
    private string stage2_Emotion;
    public GameObject shadow;
    public GameObject success;
    public GameObject fail;
    public bool isNext = false;
    private bool isSentence = false;
    public int stage = 1;
    GameManager gameManager;
    AnimManager animManager;
    WaitForSeconds waitForSeconds = new WaitForSeconds(0.01f);
    public bool isTutorial;
    private bool isTutorial_Check;
    private bool isTutorial_Check2;
    private List<string> sentence_Text = new List<string> {"우리 할머니의 머리는 점점 백발이 되고 있다", "오늘 아침에 내 짝이 나를 보고 미소를 지었다", "나는 생각하고 느끼는 존재이다", "우리 엄마는 잔소리를 많이 한다", "우리 아빠는 집안일을 잘 하지 않는다", "내 동생은 다소 이기적이다", "우리 반 친구들은 나를 싫어한다", "내 친구들은 나를 보고도 모른 체 한다", "내 초등학교 절친은 사회성이 부족하다", "선생님들은 우리를 힘들게 한다", "우리 회사의 사장님은 권위적이다", "공부든 일이든 모두 나를 위한 것이다", "적성을 아는 거이 진로 선택에 도움이 된다", "나는 타인의 눈치를 많이 본다", "나는 왕따이다", "나는 자신감이 부족하다", "운전하면서 중간에 끼어들면 안 된다", "운전하면서 중간에 끼어들어도 괜찮다", "경상도 남자들은 말이 별로 없다", "안중근 의사는 애국자이다"};
    private List<string> stage1_Text = new List<string> { "화난", "그리운", "불안한", "사랑스러운", "슬픈", "뿌듯한", "든든한", "괴로운", "열정적인" };

    void Awake()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        animManager = GameObject.Find("AnimManager").GetComponent<AnimManager>();
    }

    void Update()
    {
        Tutorial();
        Sentence();
    }
    
    void Tutorial()
    {
        if (isTutorial == false && isTutorial_Check == false)
        {
            isTutorial_Check = true;
            gameManager.Set();
            gameManager.buttons.SetActive(false);
            
            if (gameManager.stage_Select_Level_Num == 1)
            {
                isTutorial = false;
            }
            else
            {
                isTutorial = true;
            }
        }
        else if (isTutorial == true && isTutorial_Check2 == false)
        {
            isTutorial_Check2 = true;
            tutorial.SetActive(false);
            game.SetActive(true);
            gameManager.buttons.SetActive(true);
        }
    }
    
    public void Stage1_Btn(int num)
    {
        if (num == 0)
        {
            shadow.SetActive(true);
            fail.SetActive(true);
        }
        else if (num == 1)
        {
            EventSystem.current.currentSelectedGameObject.GetComponent<Button>().interactable = false;
        }

        int count = 0;

        for (int i = 0; i < stage1_Buttons.Length; i++)
        {
            if (stage1_Buttons[i].transform.GetComponent<Button>().interactable == false)
            {
                count++;

                if (count >= 4)
                {
                    stage = 2;
                    game.transform.GetChild(0).gameObject.SetActive(false);
                    game.transform.GetChild(1).gameObject.SetActive(true);
                }
            }
        }
    }

    public void Stage2_Btn(string type)
    {
        stage2_Emotion = type;
    }

    void Check()
    {
        if (isTutorial == false)
        {
            isTutorial = true;

            for (int i = 0; i < stage1_Buttons.Length; i++)
            {
                int num = Random.Range(0, stage1_Text.Count);
                stage1_Buttons[i].transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = stage1_Text[num];
                stage1_Text.RemoveAt(num);

                if (stage1_Buttons[i].transform.GetChild(0).GetComponent<TextMeshProUGUI>().text == "화난" ||
                    stage1_Buttons[i].transform.GetChild(0).GetComponent<TextMeshProUGUI>().text == "슬픈" ||
                    stage1_Buttons[i].transform.GetChild(0).GetComponent<TextMeshProUGUI>().text == "괴로운" ||
                    stage1_Buttons[i].transform.GetChild(0).GetComponent<TextMeshProUGUI>().text == "불안한")
                {
                    stage1_Buttons[i].transform.GetComponent<Button>().onClick.AddListener(() => Stage1_Btn(1));
                }
                else
                {
                    stage1_Buttons[i].transform.GetComponent<Button>().onClick.AddListener(() => Stage1_Btn(0));
                }
            }
        }
    }

    void Sentence()
    {
        if (isTutorial == false && isSentence == false)
        {
            if (sentence_Text.Count != 0)
            {
                isSentence = true;
                StartCoroutine("SentenceGenerator");
            }
            else if (sentence_Text.Count == 0)
            {
                if (tutorial.transform.GetChild(5).childCount == 0)
                {
                    tutorial_Notice.SetActive(true);
                    tutorial_True.SetActive(false);
                    tutorial_Interpret.SetActive(false);
                    Invoke("Check", 2.5f);
                }
            }
        }
    }
    
    IEnumerator SentenceGenerator()
    {
        GameObject temp = Instantiate(sentence);
        temp.transform.SetParent(tutorial.transform.GetChild(5));
        temp.transform.GetComponent<RectTransform>().anchoredPosition =
            new Vector2(0, -200);
        temp.transform.localScale = new Vector3(1, 1, 1);
        int num = Random.Range(0, sentence_Text.Count);
        temp.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = sentence_Text[num];
        sentence_Text.RemoveAt(num);

        float delay = 0;

        while (delay < 0.75f)
        {
            delay += Time.deltaTime;
            yield return waitForSeconds;
        }
    
        isSentence = false;
    }

    public void Skip()
    {
        Check();
    }

    public void ReStart()
    {
        if (success.activeSelf == true)
        {
            var animator = success.GetComponent<Animator>();
            animator.Play("Close");
        }
        else if (fail.activeSelf == true)
        {
            var animator = fail.GetComponent<Animator>();
            animator.Play("Close");
        }

        Reset();
        Invoke("Success_Fail_Close", 0.5f);
    }
    
    public void Next()
    {
        if (success.activeSelf == true)
        {
            var animator = success.GetComponent<Animator>();
            animator.Play("Close");
        }
        else if (fail.activeSelf == true)
        {
            var animator = fail.GetComponent<Animator>();
            animator.Play("Close");
        }
        
        animManager.Fade_Out();
        Invoke("Success_Fail_Close", 0.5f);
    }
    
    void Success_Fail_Close()
    {
        if (success.activeSelf == true)
        {
            success.SetActive(false);
        }
        else if (fail.activeSelf == true)
        {
            fail.SetActive(false);
        }
    }

    public void Reset()
    {
        tutorial.SetActive(true);
        isTutorial = false;
        isTutorial_Check = false;
        isTutorial_Check2 = false;
        tutorial_Notice.SetActive(false);
        tutorial_True.SetActive(true);
        tutorial_Interpret.SetActive(true);

        for (int i = 0; i < tutorial_Sentence.transform.childCount; i++)
        {
            Destroy(tutorial_Sentence.transform.GetChild(i).gameObject);
        }
        
        for (int i = 0; i < stage1_Buttons.Length; i++)
        {
            stage1_Buttons[i].GetComponent<Button>().interactable = true;
            stage1_Buttons[i].GetComponent<Button>().onClick.RemoveAllListeners();
        }

        stage = 1;
        game.SetActive(false);
        game.transform.GetChild(0).gameObject.SetActive(true);
        game.transform.GetChild(1).gameObject.SetActive(false);
        sentence_Text = new List<string> {"우리 할머니의 머리는 점점 백발이 되고 있다", "오늘 아침에 내 짝이 나를 보고 미소를 지었다", "나는 생각하고 느끼는 존재이다", "우리 엄마는 잔소리를 많이 한다", "우리 아빠는 집안일을 잘 하지 않는다", "내 동생은 다소 이기적이다", "우리 반 친구들은 나를 싫어한다", "내 친구들은 나를 보고도 모른 체 한다", "내 초등학교 절친은 사회성이 부족하다", "선생님들은 우리를 힘들게 한다", "우리 회사의 사장님은 권위적이다", "공부든 일이든 모두 나를 위한 것이다", "적성을 아는 거이 진로 선택에 도움이 된다", "나는 타인의 눈치를 많이 본다", "나는 왕따이다", "나는 자신감이 부족하다", "운전하면서 중간에 끼어들면 안 된다", "운전하면서 중간에 끼어들어도 괜찮다", "경상도 남자들은 말이 별로 없다", "안중근 의사는 애국자이다"};
        stage1_Text = new List<string> { "화난", "그리운", "불안한", "사랑스러운", "슬픈", "뿌듯한", "든든한", "괴로운", "열정적인" };
        isNext = false;
        shadow.SetActive(false);
    }
}
