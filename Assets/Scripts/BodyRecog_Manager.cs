using TMPro;
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
    public Sprite[] choices_Color = new Sprite[6];
    public GameObject shadow;
    public GameObject success;
    public TMP_Text result = null;
    public int pointNum = 1;
    private int choiceNum;
    public int step = 0;
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
            gameManager.Set2();
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
            tutorial_Choices.transform.GetChild(0).GetChild(0).GetChild(2).GetComponent<TextMeshProUGUI>().text = "편안하다";
            tutorial_Choices.transform.GetChild(0).GetChild(1).GetChild(2).GetComponent<TextMeshProUGUI>().text = "불편하다";
            step = 1;
        }
        else if (isTutorial == true)
        {
            if (pointNum == 1 || pointNum == 3 || pointNum == 5 || pointNum == 7 || pointNum == 9 || pointNum == 11 || pointNum == 13)
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
            else if (pointNum == 2 || pointNum == 4 || pointNum == 6 || pointNum == 8 || pointNum == 10 || pointNum == 12)
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
            choices.transform.GetChild(0).GetChild(0).GetChild(2).GetComponent<TextMeshProUGUI>().text = "편안하다";
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
                choices.transform.GetChild(1).GetChild(0).GetChild(1).GetComponent<Image>().sprite = choices_Color[0];
                choices.transform.GetChild(1).GetChild(1).GetChild(1).GetComponent<Image>().sprite = choices_Color[1];
                choices.transform.GetChild(1).GetChild(2).GetChild(1).GetComponent<Image>().sprite = choices_Color[2];
                choices.transform.GetChild(1).GetChild(3).GetChild(1).GetComponent<Image>().sprite = choices_Color[3];
                choices.transform.GetChild(1).GetChild(4).GetChild(1).GetComponent<Image>().sprite = choices_Color[4];
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
                choices.transform.GetChild(1).GetChild(0).GetChild(1).GetComponent<Image>().sprite = choices_Color[0];
                choices.transform.GetChild(1).GetChild(1).GetChild(1).GetComponent<Image>().sprite = choices_Color[1];
                choices.transform.GetChild(1).GetChild(2).GetChild(1).GetComponent<Image>().sprite = choices_Color[2];
                choices.transform.GetChild(1).GetChild(3).GetChild(1).GetComponent<Image>().sprite = choices_Color[3];
                choices.transform.GetChild(1).GetChild(4).GetChild(1).GetComponent<Image>().sprite = choices_Color[4];
            }

            step = 2;
        }
        else if (step == 2)
        {
            Result(choices.transform.GetChild(1).GetChild(choiceNum - 1).GetChild(2).GetComponent<TextMeshProUGUI>().text);
            choices.transform.GetChild(1).GetChild(0).GetChild(2).GetComponent<TextMeshProUGUI>().text = "매우 그렇다";
            choices.transform.GetChild(1).GetChild(1).GetChild(2).GetComponent<TextMeshProUGUI>().text = "거의 그렇다";
            choices.transform.GetChild(1).GetChild(2).GetChild(2).GetComponent<TextMeshProUGUI>().text = "그렇다";
            choices.transform.GetChild(1).GetChild(3).GetChild(2).GetComponent<TextMeshProUGUI>().text = "다소 그렇다";
            choices.transform.GetChild(1).GetChild(4).GetChild(2).GetComponent<TextMeshProUGUI>().text = "조금 그렇다";
            choices.transform.GetChild(1).GetChild(0).GetChild(1).GetComponent<Image>().sprite = choices_Color[5];
            choices.transform.GetChild(1).GetChild(1).GetChild(1).GetComponent<Image>().sprite = choices_Color[5];
            choices.transform.GetChild(1).GetChild(2).GetChild(1).GetComponent<Image>().sprite = choices_Color[5];
            choices.transform.GetChild(1).GetChild(3).GetChild(1).GetComponent<Image>().sprite = choices_Color[5];
            choices.transform.GetChild(1).GetChild(4).GetChild(1).GetComponent<Image>().sprite = choices_Color[5];
            step = 3;
        }
        else if (step == 3)
        {
            Result(choices.transform.GetChild(1).GetChild(choiceNum - 1).GetChild(2).GetComponent<TextMeshProUGUI>().text);
            choices.SetActive(false);
            choices.transform.GetChild(1).gameObject.SetActive(false);
            isStop = false;

            if (gameManager.stage_Select_Level_Num == 1)
            {
                if (pointNum == 1)
                {
                    points.transform.GetChild(0).gameObject.SetActive(false);
                    points.transform.GetChild(5).gameObject.SetActive(true);
                }
                else if (pointNum == 2)
                {
                    points.transform.GetChild(5).gameObject.SetActive(false);
                    points.transform.GetChild(6).gameObject.SetActive(true);
                }
                else if (pointNum == 3)
                {
                    points.transform.GetChild(6).gameObject.SetActive(false);
                    points.transform.GetChild(7).gameObject.SetActive(true);
                }
                else if (pointNum == 4)
                {
                    points.transform.GetChild(7).gameObject.SetActive(false);
                    points.transform.GetChild(11).gameObject.SetActive(true);
                }
                else if (pointNum == 5)
                {
                    points.transform.GetChild(11).gameObject.SetActive(false);
                    points.transform.GetChild(12).gameObject.SetActive(true);
                }
                else if (pointNum == 6)
                {
                    points.transform.GetChild(12).gameObject.SetActive(false);
                    points.transform.GetChild(13).gameObject.SetActive(true);
                }
            }
            else if (gameManager.stage_Select_Level_Num == 2)
            {
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
                }
                else if (pointNum == 4)
                {
                    points.transform.GetChild(3).gameObject.SetActive(false);
                    points.transform.GetChild(4).gameObject.SetActive(true);
                }
                else if (pointNum == 5)
                {
                    points.transform.GetChild(4).gameObject.SetActive(false);
                    points.transform.GetChild(8).gameObject.SetActive(true);
                }
                else if (pointNum == 6)
                {
                    points.transform.GetChild(8).gameObject.SetActive(false);
                    points.transform.GetChild(9).gameObject.SetActive(true);
                }
                else if (pointNum == 7)
                {
                    points.transform.GetChild(9).gameObject.SetActive(false);
                    points.transform.GetChild(10).gameObject.SetActive(true);
                }
                else if (pointNum == 8)
                {
                    points.transform.GetChild(10).gameObject.SetActive(false);
                    points.transform.GetChild(12).gameObject.SetActive(true);
                }
                else if (pointNum == 9)
                {
                    points.transform.GetChild(12).gameObject.SetActive(false);
                    points.transform.GetChild(13).gameObject.SetActive(true);
                }
            }
            else if (gameManager.stage_Select_Level_Num == 3)
            {
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
                }
                else if (pointNum == 4)
                {
                    points.transform.GetChild(3).gameObject.SetActive(false);
                    points.transform.GetChild(4).gameObject.SetActive(true);
                }
                else if (pointNum == 5)
                {
                    points.transform.GetChild(4).gameObject.SetActive(false);
                    points.transform.GetChild(5).gameObject.SetActive(true);
                }
                else if (pointNum == 6)
                {
                    points.transform.GetChild(5).gameObject.SetActive(false);
                    points.transform.GetChild(6).gameObject.SetActive(true);
                }
                else if (pointNum == 7)
                {
                    points.transform.GetChild(6).gameObject.SetActive(false);
                    points.transform.GetChild(7).gameObject.SetActive(true);
                }
                else if (pointNum == 8)
                {
                    points.transform.GetChild(7).gameObject.SetActive(false);
                    points.transform.GetChild(8).gameObject.SetActive(true);
                }
                else if (pointNum == 9)
                {
                    points.transform.GetChild(8).gameObject.SetActive(false);
                    points.transform.GetChild(9).gameObject.SetActive(true);
                }
                else if (pointNum == 10)
                {
                    points.transform.GetChild(9).gameObject.SetActive(false);
                    points.transform.GetChild(10).gameObject.SetActive(true);
                }
                else if (pointNum == 11)
                {
                    points.transform.GetChild(10).gameObject.SetActive(false);
                    points.transform.GetChild(11).gameObject.SetActive(true);
                }
                else if (pointNum == 12)
                {
                    points.transform.GetChild(11).gameObject.SetActive(false);
                    points.transform.GetChild(12).gameObject.SetActive(true);
                }
                else if (pointNum == 13)
                {
                    points.transform.GetChild(12).gameObject.SetActive(false);
                    points.transform.GetChild(13).gameObject.SetActive(true);
                }
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
        if (gameManager.stage_Select_Level_Num == 1)
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
                    result.text += $"어깨 : {data}, ";
                }
            }
            else if (pointNum == 3)
            {
                if (step == 1)
                {
                    result.text += $"가슴 : {data}, ";
                }
            }
            else if (pointNum == 4)
            {
                if (step == 1)
                {
                    result.text += $"배 : {data}, ";
                }
            }
            else if (pointNum == 5)
            {
                if (step == 1)
                {
                    result.text += $"무릎 : {data}, ";
                }
            }
            else if (pointNum == 6)
            {
                if (step == 1)
                {
                    result.text += $"발 : {data}, ";
                }
            }
        }
        else if (gameManager.stage_Select_Level_Num == 2)
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
                    result.text += $"눈 : {data}, ";
                }
            }
            else if (pointNum == 3)
            {
                if (step == 1)
                {
                    result.text += $"코 : {data}, ";
                }
            }
            else if (pointNum == 4)
            {
                if (step == 1)
                {
                    result.text += $"입 : {data}, ";
                }
            }
            else if (pointNum == 5)
            {
                if (step == 1)
                {
                    result.text += $"목 : {data}, ";
                }
            }
            else if (pointNum == 6)
            {
                if (step == 1)
                {
                    result.text += $"손 : {data}, ";
                }
            }
            else if (pointNum == 7)
            {
                if (step == 1)
                {
                    result.text += $"엉덩이 : {data}, ";
                }
            }
            else if (pointNum == 8)
            {
                if (step == 1)
                {
                    result.text += $"허벅지 : {data}, ";
                }
            }
            else if (pointNum == 9)
            {
                if (step == 1)
                {
                    result.text += $"발 : {data}, ";
                }
            }
        }
        else if (gameManager.stage_Select_Level_Num == 3)
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
                    result.text += $"눈 : {data}, ";
                }
            }
            else if (pointNum == 3)
            {
                if (step == 1)
                {
                    result.text += $"코 : {data}, ";
                }
            }
            else if (pointNum == 4)
            {
                if (step == 1)
                {
                    result.text += $"입 : {data}, ";
                }
            }
            else if (pointNum == 5)
            {
                if (step == 1)
                {
                    result.text += $"목 : {data}, ";
                }
            }
            else if (pointNum == 6)
            {
                if (step == 1)
                {
                    result.text += $"어깨 : {data}, ";
                }
            }
            else if (pointNum == 7)
            {
                if (step == 1)
                {
                    result.text += $"가슴 : {data}, ";
                }
            }
            else if (pointNum == 8)
            {
                if (step == 1)
                {
                    result.text += $"배 : {data}, ";
                }
            }
            else if (pointNum == 9)
            {
                if (step == 1)
                {
                    result.text += $"손 : {data}, ";
                }
            }
            else if (pointNum == 10)
            {
                if (step == 1)
                {
                    result.text += $"엉덩이 : {data}, ";
                }
            }
            else if (pointNum == 11)
            {
                if (step == 1)
                {
                    result.text += $"허벅지 : {data}, ";
                }
            }
            else if (pointNum == 12)
            {
                if (step == 1)
                {
                    result.text += $"무릎 : {data}, ";
                }
            }
            else if (pointNum == 13)
            {
                if (step == 1)
                {
                    result.text += $"발 : {data}, ";
                }
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
        points.transform.GetChild(8).gameObject.SetActive(false);
        points.transform.GetChild(9).gameObject.SetActive(false);
        points.transform.GetChild(10).gameObject.SetActive(false);
        points.transform.GetChild(11).gameObject.SetActive(false);
        points.transform.GetChild(12).gameObject.SetActive(false);
        points.transform.GetChild(13).gameObject.SetActive(false);
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
