using NUnit.Framework.Constraints;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class BodyRecog_Manager : MonoBehaviour
{
    public GameObject tutorial;
    public GameObject tutorial_Notice;
    public GameObject tutorial_Line;
    public GameObject tutorial_Choices;
    public GameObject game;
    public GameObject line;
    public GameObject points;
    public GameObject choices;
    public GameObject shadow;
    public GameObject success;
    public TMP_Text result = null;
    public int pointNum = 1;
    private int choiceNum;
    private int step = 0;
    public bool isStop = false;
    public bool isNext = false;
    GameManager gameManager;
    AnimManager animManager;
    public bool isTutorial = true;
    private bool isTutorial_Check = true;
    private bool isTutorial_Check2;

    void Awake()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        animManager = GameObject.Find("AnimManager").GetComponent<AnimManager>();
        points.GetComponent<Animator>().Play("Point");
    }

    void Update()
    {
        Tutorial();
        Line();
    }
    
    void Tutorial()
    {
        if (isTutorial == false && isTutorial_Check == false)
        {
            isTutorial_Check = true;
            gameManager.buttons.SetActive(false);
        }
        else if (isTutorial == true && isTutorial_Check2 == false)
        {
            isTutorial_Check2 = true;
            isStop = false;
            tutorial.SetActive(false);
            game.SetActive(true);
            gameManager.buttons.SetActive(true);
        }
    }

    public void Skip()
    {
        isTutorial = true;
    }
    
    void Line()
    {
        if (isTutorial == false)
        {
            if (isStop == false)
            {
                tutorial_Line.transform.Translate(new Vector3(0, -0.5f, 0) * Time.deltaTime);
            }
        }
        else if (isTutorial == true)
        {
            if (isStop == false)
            {
                line.transform.Translate(new Vector3(0, -0.5f, 0) * Time.deltaTime);
            }
        }
    }

    public void Point()
    {
        if (isTutorial == false)
        {
            tutorial_Notice.GetComponent<TextMeshProUGUI>().text = "자신의 상황에 맞게 버튼을 눌러요";
            tutorial_Choices.SetActive(true);
            tutorial_Choices.transform.GetChild(0).gameObject.SetActive(true);
            tutorial_Choices.transform.GetChild(0).GetChild(0).GetChild(2).GetComponent<TextMeshProUGUI>().text = "편하다";
            tutorial_Choices.transform.GetChild(0).GetChild(1).GetChild(2).GetComponent<TextMeshProUGUI>().text = "불편하다";
            step = 1;
        }
        else if (isTutorial == true)
        {
            if (pointNum == 1 || pointNum == 3 || pointNum == 5)
            {
                choices.transform.GetChild(0).GetChild(0).GetComponent<RectTransform>().anchoredPosition =
                    new Vector2(375, 550);
                choices.transform.GetChild(0).GetChild(1).GetComponent<RectTransform>().anchoredPosition =
                    new Vector2(375, 350);
                choices.transform.GetChild(1).GetChild(0).GetComponent<RectTransform>().anchoredPosition =
                    new Vector2(375, 800);
                choices.transform.GetChild(1).GetChild(1).GetComponent<RectTransform>().anchoredPosition =
                    new Vector2(375, 675);
                choices.transform.GetChild(1).GetChild(2).GetComponent<RectTransform>().anchoredPosition =
                    new Vector2(375, 550);
                choices.transform.GetChild(1).GetChild(3).GetComponent<RectTransform>().anchoredPosition =
                    new Vector2(375, 425);
                choices.transform.GetChild(1).GetChild(4).GetComponent<RectTransform>().anchoredPosition =
                    new Vector2(375, 300);
            }
            else if (pointNum == 2 || pointNum == 4 || pointNum == 6)
            {
                choices.transform.GetChild(0).GetChild(0).GetComponent<RectTransform>().anchoredPosition =
                    new Vector2(-375, 550);
                choices.transform.GetChild(0).GetChild(1).GetComponent<RectTransform>().anchoredPosition =
                    new Vector2(-375, 350);
                choices.transform.GetChild(1).GetChild(0).GetComponent<RectTransform>().anchoredPosition =
                    new Vector2(-375, 800);
                choices.transform.GetChild(1).GetChild(1).GetComponent<RectTransform>().anchoredPosition =
                    new Vector2(-375, 675);
                choices.transform.GetChild(1).GetChild(2).GetComponent<RectTransform>().anchoredPosition =
                    new Vector2(-375, 550);
                choices.transform.GetChild(1).GetChild(3).GetComponent<RectTransform>().anchoredPosition =
                    new Vector2(-375, 425);
                choices.transform.GetChild(1).GetChild(4).GetComponent<RectTransform>().anchoredPosition =
                    new Vector2(-375, 300);
            }
            choices.SetActive(true);
            choices.transform.GetChild(0).gameObject.SetActive(true);
            choices.transform.GetChild(0).GetChild(0).GetChild(2).GetComponent<TextMeshProUGUI>().text = "편하다";
            choices.transform.GetChild(0).GetChild(1).GetChild(2).GetComponent<TextMeshProUGUI>().text = "불편하다";
            step = 1;
        }
    }

    public void Choice(int num)
    {
        if (isTutorial == false)
        {
            tutorial_Choices.SetActive(false);
            tutorial_Notice.GetComponent<TextMeshProUGUI>().text = "잘했어요! 튜토리얼은 여기까지 ~";
            Invoke("Skip", 3.0f);
        }
        else if (isTutorial == true)
        {
            choiceNum = num;
            choices.transform.GetChild(0).GetChild(0).GetComponent<Button>().interactable = false;
            choices.transform.GetChild(0).GetChild(1).GetComponent<Button>().interactable = false;
            choices.transform.GetChild(1).GetChild(0).GetComponent<Button>().interactable = false;
            choices.transform.GetChild(1).GetChild(1).GetComponent<Button>().interactable = false;
            choices.transform.GetChild(1).GetChild(2).GetComponent<Button>().interactable = false;
            choices.transform.GetChild(1).GetChild(3).GetComponent<Button>().interactable = false;
            choices.transform.GetChild(1).GetChild(4).GetComponent<Button>().interactable = false;
            Invoke("Choice2", 0.5f); 
        }
    }
    
    public void Choice2()
    {
        if (step == 1)
        {
            Result(choices.transform.GetChild(0).GetChild(choiceNum - 1).GetChild(2).GetComponent<TextMeshProUGUI>().text);

            if (choiceNum == 1)
            {
                choices.transform.GetChild(0).gameObject.SetActive(false);
                choices.transform.GetChild(1).gameObject.SetActive(true);
                choices.transform.GetChild(1).GetChild(0).GetChild(2).GetComponent<TextMeshProUGUI>().text = "상쾌하다";
                choices.transform.GetChild(1).GetChild(1).GetChild(2).GetComponent<TextMeshProUGUI>().text = "가볍다";
                choices.transform.GetChild(1).GetChild(2).GetChild(2).GetComponent<TextMeshProUGUI>().text = "시원하다";
                choices.transform.GetChild(1).GetChild(3).GetChild(2).GetComponent<TextMeshProUGUI>().text = "따뜻하다";
                choices.transform.GetChild(1).GetChild(4).GetChild(2).GetComponent<TextMeshProUGUI>().text = "편안하다";
            }
            else if (choiceNum == 2)
            {
                choices.transform.GetChild(0).gameObject.SetActive(false);
                choices.transform.GetChild(1).gameObject.SetActive(true);
                choices.transform.GetChild(1).GetChild(0).GetChild(2).GetComponent<TextMeshProUGUI>().text = "불쾌하다";
                choices.transform.GetChild(1).GetChild(1).GetChild(2).GetComponent<TextMeshProUGUI>().text = "무겁다";
                choices.transform.GetChild(1).GetChild(2).GetChild(2).GetComponent<TextMeshProUGUI>().text = "갑갑하다";
                choices.transform.GetChild(1).GetChild(3).GetChild(2).GetComponent<TextMeshProUGUI>().text = "차갑다";
                choices.transform.GetChild(1).GetChild(4).GetChild(2).GetComponent<TextMeshProUGUI>().text = "불편하다";
            }

            step = 2;
        }
        else if (step == 2)
        {
            Result(choices.transform.GetChild(1).GetChild(choiceNum - 1).GetChild(2).GetComponent<TextMeshProUGUI>().text);
            choices.transform.GetChild(1).GetChild(0).GetChild(2).GetComponent<TextMeshProUGUI>().text = "매우 그렇다";
            choices.transform.GetChild(1).GetChild(1).GetChild(2).GetComponent<TextMeshProUGUI>().text = "조금 그렇다";
            choices.transform.GetChild(1).GetChild(2).GetChild(2).GetComponent<TextMeshProUGUI>().text = "보통이다";
            choices.transform.GetChild(1).GetChild(3).GetChild(2).GetComponent<TextMeshProUGUI>().text = "조금 그렇지 않다";
            choices.transform.GetChild(1).GetChild(4).GetChild(2).GetComponent<TextMeshProUGUI>().text = "매우 그렇지 않다";
            step = 3;
        }
        else if (step == 3)
        {
            Result(choices.transform.GetChild(1).GetChild(choiceNum - 1).GetChild(2).GetComponent<TextMeshProUGUI>().text);
            choices.SetActive(false);
            choices.transform.GetChild(1).gameObject.SetActive(false);
            isStop = false;

            if (pointNum == 1)
            {
                points.transform.GetChild(0).gameObject.SetActive(false);
                points.transform.GetChild(1).gameObject.SetActive(true);
            }
            else if (pointNum == 2)
            {
                points.transform.GetChild(1).gameObject.SetActive(false);
                points.transform.GetChild(2).gameObject.SetActive(true);
            }
            else if (pointNum == 3)
            {
                points.transform.GetChild(2).gameObject.SetActive(false);
                points.transform.GetChild(3).gameObject.SetActive(true);
                points.transform.GetChild(4).gameObject.SetActive(true);
            }
            else if (pointNum == 4)
            {
                points.transform.GetChild(3).gameObject.SetActive(false);
                points.transform.GetChild(4).gameObject.SetActive(false);
                points.transform.GetChild(5).gameObject.SetActive(true);
                points.transform.GetChild(6).gameObject.SetActive(true);
            }
            else if (pointNum == 5)
            {
                points.transform.GetChild(5).gameObject.SetActive(false);
                points.transform.GetChild(6).gameObject.SetActive(false);
                points.transform.GetChild(7).gameObject.SetActive(true);
            }

            pointNum++;
        }
        
        choices.transform.GetChild(0).GetChild(0).GetComponent<Button>().interactable = true;
        choices.transform.GetChild(0).GetChild(1).GetComponent<Button>().interactable = true;
        choices.transform.GetChild(1).GetChild(0).GetComponent<Button>().interactable = true;
        choices.transform.GetChild(1).GetChild(1).GetComponent<Button>().interactable = true;
        choices.transform.GetChild(1).GetChild(2).GetComponent<Button>().interactable = true;
        choices.transform.GetChild(1).GetChild(3).GetComponent<Button>().interactable = true;
        choices.transform.GetChild(1).GetChild(4).GetComponent<Button>().interactable = true;
    }

    void Result(string data)
    {
        if (pointNum == 1)
        {
            if (step == 1)
            {
                result.text += $"머리 : {data}, ";
            }
        }
        else if (pointNum == 2)
        {
            if (step == 1)
            {
                result.text += $"목 : {data}, ";
            }
        }
        else if (pointNum == 3)
        {
            if (step == 1)
            {
                result.text += $"배 : {data}, ";
            }
        }
        else if (pointNum == 4)
        {
            if (step == 1)
            {
                result.text += $"손 : {data}, ";
            }
        }
        else if (pointNum == 5)
        {
            if (step == 1)
            {
                result.text += $"발 : {data}, ";
            }
        }
        
        if (step == 2)
        {
            result.text += $"{data}, ";
        }
        else if (step == 3)
        {
            result.text += $"{data}\n\n";
        }
    }

    public void ReStart()
    {
        var animator = success.GetComponent<Animator>();
        animator.Play("Close");
        Reset();
        Invoke("Success_Close", 0.5f);
    }
    
    public void Next()
    {
        isNext = true;
        var animator = success.GetComponent<Animator>();
        animator.Play("Close");
        animManager.Fade_Out();
        Invoke("Success_Close", 0.5f);
    }
    
    void Success_Close()
    {
        success.SetActive(false);
    }

    public void Reset()
    {
        tutorial_Notice.GetComponent<TextMeshProUGUI>().text = "선이 포인트에 도착할때까지 기다려요";
        tutorial_Line.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, -100);
        tutorial_Choices.SetActive(false);
        tutorial_Choices.transform.GetChild(0).gameObject.SetActive(false);
        line.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, -100);
        points.transform.GetChild(0).gameObject.SetActive(true);
        points.transform.GetChild(1).gameObject.SetActive(false);
        points.transform.GetChild(2).gameObject.SetActive(false);
        points.transform.GetChild(3).gameObject.SetActive(false);
        points.transform.GetChild(4).gameObject.SetActive(false);
        points.transform.GetChild(5).gameObject.SetActive(false);
        points.transform.GetChild(6).gameObject.SetActive(false);
        points.transform.GetChild(7).gameObject.SetActive(false);
        choices.SetActive(false);
        choices.transform.GetChild(0).gameObject.SetActive(false);
        choices.transform.GetChild(1).gameObject.SetActive(false);
        pointNum = 1;
        step = 0;
        isStop = false;
        result.text = "";
        shadow.SetActive(false);
        tutorial.SetActive(true);
        game.SetActive(false);
        isTutorial = true;
        isTutorial_Check = true;
        isTutorial_Check2 = false;
        gameManager.buttons.SetActive(true);
    }
}
