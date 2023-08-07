using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BodyRecog_Manager : MonoBehaviour
{
    public GameObject tutorial;
    public GameObject tutorial_Character_Panel;
    public GameObject tutorial_Points;
    public Text tutorial_Notice;
    public GameObject tutorial_Line;
    public GameObject tutorial_Choices;
    public GameObject game;
    public GameObject line;
    public GameObject points;
    public GameObject choices;
    public Sprite[] choices_Color = new Sprite[6];
    public GameObject shadow;
    public GameObject success;
    public Text result = null;
    public int pointNum = 1;
    private int choiceNum;
    public int step = 0;
    public bool isStop = false;
    public bool isNext = false;
    GameManager gameManager;
    AnimManager animManager;
    public bool isTutorial = false;
    private bool isTutorial_Check = false;
    private bool isTutorial_Check2 = false;
    private int tutorial_Notice_Num = 1;
    WaitForSeconds waitForSeconds = new WaitForSeconds(0.01f);
    public GameObject tutorial_Notice_Image;
    public Image stepline;
    public List<Sprite> step1Line;
    public List<Sprite> step2Line;
    public List<Sprite> step3Line;
    

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
        if (isTutorial == false)
        {
            if (isTutorial_Check == false)
            {
                isTutorial_Check = true;
                gameManager.Set2();

                if (gameManager.stage_Select_Level_Num == 1 && PlayerPrefs.GetInt("BodyRecog_Tutorial") == 0)
                {
                    gameManager.buttons.SetActive(false);
                    isStop = true;
                    isTutorial = false;
                    Tutorial_Notice();
                }
                else
                {
                    isTutorial = true;
                }
            }
            else
            {
                if (Input.GetMouseButtonUp(0))
                {
                    tutorial_Notice_Num++;

                    if (tutorial_Notice_Num != 5)
                    {
                        Tutorial_Notice();
                    }
                }
            }
        }
        else if (isTutorial == true && isTutorial_Check2 == false)
        {
            isTutorial_Check2 = true;
            isStop = false;
            result.text = "";
            tutorial.SetActive(false);
            game.SetActive(true);
            gameManager.buttons.SetActive(true);

            if (gameManager.stage_Select_Level_Num == 1)
            {
                stepline.sprite = step1Line[0];
            }
            else if (gameManager.stage_Select_Level_Num == 2)
            {
                stepline.sprite = step2Line[0];
            }
            else if (gameManager.stage_Select_Level_Num == 3)
            {
                stepline.sprite = step2Line[0];
            }
        }
    }

    void Tutorial_Notice()
    {
        if (tutorial_Notice_Num == 1)
        {
            tutorial_Notice.text = "신체자각과 감정자각을 시작합니다.";
            tutorial_Notice_Image.GetComponent<Animator>().Play("Text");
        }
        else if (tutorial_Notice_Num == 2)
        {
            tutorial_Notice.text = "신체자각은\n현재 자신의 몸 상태에 대해\n알아차리는 것입니다.";
        }
        else if (tutorial_Notice_Num == 3)
        {
            tutorial_Notice.text = "머리부터 시작하여 발까지\n신체자각을 통하여 상태를 알아차려 봅시다.";
        }
        else if (tutorial_Notice_Num == 4)
        {
            tutorial_Notice_Image.SetActive(false);
            tutorial_Notice.text = "이제부터 시작해볼까요?";
            StartCoroutine("Start_Delay");
        }
    }

    IEnumerator Start_Delay()
    {
        float delay = 0;

        while (delay < 5)
        {
            delay += 5 * Time.deltaTime;
            yield return waitForSeconds;
        }
        
        tutorial_Notice.text = "";
        tutorial_Character_Panel.SetActive(true);
        tutorial_Points.SetActive(true);
        tutorial_Line.SetActive(true);
        isStop = false;
    }
    
    public void Skip()
    {
        isTutorial = true;
        PlayerPrefs.SetInt("BodyRecog_Tutorial", 1);
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
            tutorial_Notice.text = "현재 당신의 머리는 편한가요, 불편한가요?";
            tutorial_Choices.SetActive(true);
            tutorial_Choices.transform.GetChild(0).gameObject.SetActive(true);
            tutorial_Choices.transform.GetChild(0).GetChild(0).GetChild(2).GetComponent<TextMeshProUGUI>().text = "편하다";
            tutorial_Choices.transform.GetChild(0).GetChild(1).GetChild(2).GetComponent<TextMeshProUGUI>().text = "불편하다";
            step = 1;
        }
        else if (isTutorial == true)
        {
            if (gameManager.stage_Select_Level_Num == 1)
            {
                stepline.sprite = step1Line[pointNum - 1];
            }
            else if (gameManager.stage_Select_Level_Num == 2)
            {
                stepline.sprite = step2Line[pointNum - 1];
            }
            else if (gameManager.stage_Select_Level_Num == 3)
            {
                stepline.sprite = step3Line[pointNum - 1];
            }

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
            choices.transform.GetChild(0).GetChild(0).GetChild(2).GetComponent<TextMeshProUGUI>().text = "편하다";
            choices.transform.GetChild(0).GetChild(1).GetChild(2).GetComponent<TextMeshProUGUI>().text = "불편하다";
            step = 1;
        }
    }

    public void Choice(int num)
    {
        if (isTutorial == false)
        {
            choiceNum = num;
            tutorial_Choices.transform.GetChild(0).GetChild(0).GetComponent<Button>().interactable = false;
            tutorial_Choices.transform.GetChild(0).GetChild(1).GetComponent<Button>().interactable = false;
            tutorial_Choices.transform.GetChild(1).GetChild(0).GetComponent<Button>().interactable = false;
            tutorial_Choices.transform.GetChild(1).GetChild(1).GetComponent<Button>().interactable = false;
            tutorial_Choices.transform.GetChild(1).GetChild(2).GetComponent<Button>().interactable = false;
            tutorial_Choices.transform.GetChild(1).GetChild(3).GetComponent<Button>().interactable = false;
            tutorial_Choices.transform.GetChild(1).GetChild(4).GetComponent<Button>().interactable = false;
            Invoke("Choice2", 0.5f); 
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
        if (isTutorial == false)
        {
            if (step == 1)
            {
                Result(tutorial_Choices.transform.GetChild(0).GetChild(choiceNum - 1).GetChild(2).GetComponent<TextMeshProUGUI>().text);

                if (choiceNum == 1)
                {
                    tutorial_Choices.transform.GetChild(0).gameObject.SetActive(false);
                    tutorial_Choices.transform.GetChild(1).gameObject.SetActive(true);
                    tutorial_Choices.transform.GetChild(1).GetChild(0).GetChild(2).GetComponent<TextMeshProUGUI>().text = "상쾌하다";
                    tutorial_Choices.transform.GetChild(1).GetChild(1).GetChild(2).GetComponent<TextMeshProUGUI>().text = "가볍다";
                    tutorial_Choices.transform.GetChild(1).GetChild(2).GetChild(2).GetComponent<TextMeshProUGUI>().text = "시원하다";
                    tutorial_Choices.transform.GetChild(1).GetChild(3).GetChild(2).GetComponent<TextMeshProUGUI>().text = "따뜻하다";
                    tutorial_Choices.transform.GetChild(1).GetChild(4).GetChild(2).GetComponent<TextMeshProUGUI>().text = "편안하다";
                    tutorial_Choices.transform.GetChild(1).GetChild(0).GetChild(1).GetComponent<Image>().sprite = choices_Color[0];
                    tutorial_Choices.transform.GetChild(1).GetChild(1).GetChild(1).GetComponent<Image>().sprite = choices_Color[1];
                    tutorial_Choices.transform.GetChild(1).GetChild(2).GetChild(1).GetComponent<Image>().sprite = choices_Color[2];
                    tutorial_Choices.transform.GetChild(1).GetChild(3).GetChild(1).GetComponent<Image>().sprite = choices_Color[3];
                    tutorial_Choices.transform.GetChild(1).GetChild(4).GetChild(1).GetComponent<Image>().sprite = choices_Color[4];
                }
                else if (choiceNum == 2)
                {
                    tutorial_Choices.transform.GetChild(0).gameObject.SetActive(false);
                    tutorial_Choices.transform.GetChild(1).gameObject.SetActive(true);
                    tutorial_Choices.transform.GetChild(1).GetChild(0).GetChild(2).GetComponent<TextMeshProUGUI>().text = "불쾌하다";
                    tutorial_Choices.transform.GetChild(1).GetChild(1).GetChild(2).GetComponent<TextMeshProUGUI>().text = "무겁다";
                    tutorial_Choices.transform.GetChild(1).GetChild(2).GetChild(2).GetComponent<TextMeshProUGUI>().text = "갑갑하다";
                    tutorial_Choices.transform.GetChild(1).GetChild(3).GetChild(2).GetComponent<TextMeshProUGUI>().text = "차갑다";
                    tutorial_Choices.transform.GetChild(1).GetChild(4).GetChild(2).GetComponent<TextMeshProUGUI>().text = "불편하다";
                    tutorial_Choices.transform.GetChild(1).GetChild(0).GetChild(1).GetComponent<Image>().sprite = choices_Color[0];
                    tutorial_Choices.transform.GetChild(1).GetChild(1).GetChild(1).GetComponent<Image>().sprite = choices_Color[1];
                    tutorial_Choices.transform.GetChild(1).GetChild(2).GetChild(1).GetComponent<Image>().sprite = choices_Color[2];
                    tutorial_Choices.transform.GetChild(1).GetChild(3).GetChild(1).GetComponent<Image>().sprite = choices_Color[3];
                    tutorial_Choices.transform.GetChild(1).GetChild(4).GetChild(1).GetComponent<Image>().sprite = choices_Color[4];
                }

                tutorial_Notice.text = "다음의 5가지 감각 중에\n지금 머리에서 느껴지는 감각과\n가장 유사한 것을 한 가지 선택하세요.";
                step = 2;
            }
            else if (step == 2)
            {
                Result(tutorial_Choices.transform.GetChild(1).GetChild(choiceNum - 1).GetChild(2).GetComponent<TextMeshProUGUI>().text);
                tutorial_Choices.transform.GetChild(1).GetChild(0).GetChild(2).GetComponent<TextMeshProUGUI>().text = "5";
                tutorial_Choices.transform.GetChild(1).GetChild(1).GetChild(2).GetComponent<TextMeshProUGUI>().text = "4";
                tutorial_Choices.transform.GetChild(1).GetChild(2).GetChild(2).GetComponent<TextMeshProUGUI>().text = "3";
                tutorial_Choices.transform.GetChild(1).GetChild(3).GetChild(2).GetComponent<TextMeshProUGUI>().text = "2";
                tutorial_Choices.transform.GetChild(1).GetChild(4).GetChild(2).GetComponent<TextMeshProUGUI>().text = "1";
                tutorial_Choices.transform.GetChild(1).GetChild(0).GetChild(1).GetComponent<Image>().sprite = choices_Color[5];
                tutorial_Choices.transform.GetChild(1).GetChild(1).GetChild(1).GetComponent<Image>().sprite = choices_Color[5];
                tutorial_Choices.transform.GetChild(1).GetChild(2).GetChild(1).GetComponent<Image>().sprite = choices_Color[5];
                tutorial_Choices.transform.GetChild(1).GetChild(3).GetChild(1).GetComponent<Image>().sprite = choices_Color[5];
                tutorial_Choices.transform.GetChild(1).GetChild(4).GetChild(1).GetComponent<Image>().sprite = choices_Color[5];
                tutorial_Notice.text = "선택한 감정이 느껴지는 정도를 확인해주세요\n가장 많이 느껴지면 5점\n아주 적게 느껴지면 1점입니다";
                step = 3;
            }
            else if (step == 3)
            {
                Result(tutorial_Choices.transform.GetChild(1).GetChild(choiceNum - 1).GetChild(2).GetComponent<TextMeshProUGUI>().text);
                tutorial_Notice.text = "잘 하셨습니다\n당신의 전체 몸 상태는 다음과 같습니다\n SKIP 버튼을 누르면 튜토리얼은 마무리 됩니다";
                tutorial_Choices.SetActive(false);
                tutorial_Choices.transform.GetChild(1).gameObject.SetActive(false);
                tutorial_Points.SetActive(false);
                tutorial_Line.SetActive(false);
            }
            
            tutorial_Choices.transform.GetChild(0).GetChild(0).GetComponent<Button>().interactable = true;
            tutorial_Choices.transform.GetChild(0).GetChild(1).GetComponent<Button>().interactable = true;
            tutorial_Choices.transform.GetChild(1).GetChild(0).GetComponent<Button>().interactable = true;
            tutorial_Choices.transform.GetChild(1).GetChild(1).GetComponent<Button>().interactable = true;
            tutorial_Choices.transform.GetChild(1).GetChild(2).GetComponent<Button>().interactable = true;
            tutorial_Choices.transform.GetChild(1).GetChild(3).GetComponent<Button>().interactable = true;
            tutorial_Choices.transform.GetChild(1).GetChild(4).GetComponent<Button>().interactable = true;
        }
        else if (isTutorial == true)
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
                choices.transform.GetChild(1).GetChild(0).GetChild(2).GetComponent<TextMeshProUGUI>().text = "5";
                choices.transform.GetChild(1).GetChild(1).GetChild(2).GetComponent<TextMeshProUGUI>().text = "4";
                choices.transform.GetChild(1).GetChild(2).GetChild(2).GetComponent<TextMeshProUGUI>().text = "3";
                choices.transform.GetChild(1).GetChild(3).GetChild(2).GetComponent<TextMeshProUGUI>().text = "2";
                choices.transform.GetChild(1).GetChild(4).GetChild(2).GetComponent<TextMeshProUGUI>().text = "1";
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
        if (gameManager.pause.activeSelf == true)
        {
            var animator = gameManager.pause.GetComponent<Animator>();
            animator.Play("Close");
            Reset();
            Invoke("Pause_Close", 0.5f);
        }
        else
        {
            var animator = success.GetComponent<Animator>();
            animator.Play("Close");
            Reset();
            Invoke("Success_Close", 0.5f);
        }
    }
    
    public void Next()
    {
        isNext = true;
        var animator = success.GetComponent<Animator>();
        animator.Play("Close");
        animManager.Fade_Out();
        Invoke("Success_Close", 0.5f);
    }
    
    public void Help()
    {
        PlayerPrefs.SetInt("BodyRecog_Tutorial", 0);
        var animator = gameManager.pause.GetComponent<Animator>();
        animator.Play("Close");
        Reset();
        Invoke("Pause_Close", 0.5f);
    }
    
    void Success_Close()
    {
        success.SetActive(false);
    }

    void Pause_Close()
    {
        gameManager.buttons.transform.GetChild(0).gameObject.SetActive(false);
        gameManager.buttons.transform.GetChild(1).gameObject.SetActive(true);
        gameManager.buttons.transform.GetChild(2).gameObject.SetActive(false);
        gameManager.pause.SetActive(false);
    }
    
    public void Reset()
    {
        tutorial_Character_Panel.SetActive(false);
        tutorial_Points.SetActive(false);
        tutorial_Line.SetActive(false);
        tutorial_Notice.text = "신체자각과 감정자각을 시작합니다.";
        tutorial_Line.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 0);
        tutorial_Choices.SetActive(false);
        tutorial_Choices.transform.GetChild(0).gameObject.SetActive(false);
        line.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 200);
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
        tutorial_Notice_Num = 1;
        tutorial_Notice_Image.SetActive(true);
        gameManager.buttons.SetActive(true);
    }
}
