using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class BodyRecog_Manager : MonoBehaviour
{
    public GameObject tutorial;
    public GameObject tutorial_Character_Panel;
    public GameObject tutorial_Points;
    public Text tutorial_Notice;
    public GameObject tutorial_Line;
    public GameObject tutorial_Choices;
    public GameObject tutorial_Results;
    public GameObject game;
    public GameObject character_Step1;
    public GameObject character_Step2;
    public GameObject character_Step3;
    public GameObject character_Step1_Points;
    public GameObject character_Step2_Points;
    public GameObject character_Step3_Points;
    public GameObject line;
    public Text notice;
    public GameObject points;
    public GameObject choices;
    public Sprite[] choices_Color = new Sprite[6];
    public GameObject shadow;
    public GameObject success;
    public GameObject success2;
    public GameObject success_Results_Step1;
    public GameObject success_Results_Step2;
    public GameObject success_Results_Step3;
    public string result;
    public int pointNum = 1;
    private int choiceNum;
    public int step;
    public bool isStop;
    public bool isNext;
    public bool isTutorial;
    private bool isTutorial_Check;
    private bool isTutorial_Check2;
    private int tutorial_Notice_Num = 1;
    WaitForSeconds waitForSeconds = new (0.01f);
    public GameObject tutorial_Notice_Image;
    public Image stepline;
    public List<Sprite> step1Line;
    public List<Sprite> step2Line;
    public List<Sprite> step3Line;
    public List<GameObject> results;
    public List<Sprite> results_Sprite;
    
    void Update()
    {
        Tutorial();
        Line();
    }
    
    void Tutorial()
    {
        if (!isTutorial)
        {
            if (!isTutorial_Check)
            {
                isTutorial_Check = true;

                if (PlayerPrefs.GetInt("BodyRecog_Tutorial") == 0)
                {
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
        else if (isTutorial && !isTutorial_Check2)
        {
            isTutorial_Check2 = true;
            isStop = false;
            result = "";
            tutorial.SetActive(false);
            game.SetActive(true);
            
            if (DBManager.instance.currentStep == 1)
            {
                character_Step1.SetActive(true);
                character_Step1_Points.SetActive(true);
                stepline.sprite = step1Line[0];
            }
            else if (DBManager.instance.currentStep == 2)
            {
                character_Step2.SetActive(true);
                character_Step2_Points.SetActive(true);
                stepline.sprite = step2Line[0];
            }
            else if (DBManager.instance.currentStep == 3)
            {
                character_Step3.SetActive(true);
                character_Step3_Points.SetActive(true);
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
        if (!isTutorial)
        {
            if (!isStop)
            {
                tutorial_Line.transform.Translate(new Vector3(0, -0.5f, 0) * Time.deltaTime);
            }
        }
        else if (isTutorial)
        {
            if (!isStop)
            {
                line.transform.Translate(new Vector3(0, -0.5f, 0) * Time.deltaTime);
            }
        }
    }

    public void Point()
    {
        if (!isTutorial)
        {
            tutorial_Notice.text = "현재 당신의 머리는 편한가요, 불편한가요?";
            tutorial_Choices.SetActive(true);
            tutorial_Choices.transform.GetChild(0).gameObject.SetActive(true);
            tutorial_Choices.transform.GetChild(0).GetChild(0).GetChild(2).GetComponent<TextMeshProUGUI>().text = "편하다";
            tutorial_Choices.transform.GetChild(0).GetChild(1).GetChild(2).GetComponent<TextMeshProUGUI>().text = "불편하다";
            step = 1;
        }
        else if (isTutorial)
        {
            if (DBManager.instance.currentStep == 1)
            {
                stepline.sprite = step1Line[pointNum - 1];
            }
            else if (DBManager.instance.currentStep == 2)
            {
                stepline.sprite = step2Line[pointNum - 1];
            }
            else if (DBManager.instance.currentStep == 3)
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
        if (!isTutorial)
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
        else if (isTutorial)
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
        if (!isTutorial)
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
                tutorial_Notice.text = "선택한 감정이 느껴지는 정도를 확인해주세요.\n가장 많이 느껴지면 5점\n아주 적게 느껴지면 1점입니다.";
                step = 3;
            }
            else if (step == 3)
            {
                Result(tutorial_Choices.transform.GetChild(1).GetChild(choiceNum - 1).GetChild(2).GetComponent<TextMeshProUGUI>().text);
                tutorial_Notice.text = "잘 하셨습니다.\n당신의 전체 몸 상태는 다음과 같습니다.\n SKIP 버튼을 누르면 튜토리얼은 마무리 됩니다.";
                tutorial_Choices.SetActive(false);
                tutorial_Choices.transform.GetChild(1).gameObject.SetActive(false);
                tutorial_Points.SetActive(false);
                tutorial_Line.SetActive(false);
                tutorial_Results.SetActive(true);
                string[] temp = result.Split(',');

                if (temp[0] == "머리")
                {
                    if (temp[1] == "편하다")
                    {
                        switch (temp[2])
                        {
                            case "1":
                                tutorial_Results.transform.GetChild(0).GetComponent<Image>().sprite = results_Sprite[0];
                                break;
                            case "2":
                                tutorial_Results.transform.GetChild(0).GetComponent<Image>().sprite = results_Sprite[1];
                                break;
                            case "3":
                                tutorial_Results.transform.GetChild(0).GetComponent<Image>().sprite = results_Sprite[2];
                                break;
                            case "4":
                                tutorial_Results.transform.GetChild(0).GetComponent<Image>().sprite = results_Sprite[3];
                                break;
                            case "5":
                                tutorial_Results.transform.GetChild(0).GetComponent<Image>().sprite = results_Sprite[4];
                                break;
                        }
                    }

                    if (temp[1] == "불편하다")
                    {
                        switch (temp[2])
                        {
                            case "1":
                                tutorial_Results.transform.GetChild(0).GetComponent<Image>().sprite = results_Sprite[5];
                                break;
                            case "2":
                                tutorial_Results.transform.GetChild(0).GetComponent<Image>().sprite = results_Sprite[6];
                                break;
                            case "3":
                                tutorial_Results.transform.GetChild(0).GetComponent<Image>().sprite = results_Sprite[7];
                                break;
                            case "4":
                                tutorial_Results.transform.GetChild(0).GetComponent<Image>().sprite = results_Sprite[8];
                                break;
                            case "5":
                                tutorial_Results.transform.GetChild(0).GetComponent<Image>().sprite = results_Sprite[9];
                                break;
                        }
                    }
                }
            }
            
            tutorial_Choices.transform.GetChild(0).GetChild(0).GetComponent<Button>().interactable = true;
            tutorial_Choices.transform.GetChild(0).GetChild(1).GetComponent<Button>().interactable = true;
            tutorial_Choices.transform.GetChild(1).GetChild(0).GetComponent<Button>().interactable = true;
            tutorial_Choices.transform.GetChild(1).GetChild(1).GetComponent<Button>().interactable = true;
            tutorial_Choices.transform.GetChild(1).GetChild(2).GetComponent<Button>().interactable = true;
            tutorial_Choices.transform.GetChild(1).GetChild(3).GetComponent<Button>().interactable = true;
            tutorial_Choices.transform.GetChild(1).GetChild(4).GetComponent<Button>().interactable = true;
        }
        else if (isTutorial)
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
                notice.text = string.Empty;

                if (DBManager.instance.currentStep == 1)
                {
                    if (pointNum == 1)
                    {
                        character_Step1_Points.transform.GetChild(0).gameObject.SetActive(false);
                        character_Step1_Points.transform.GetChild(1).gameObject.SetActive(true);
                    }
                    else if (pointNum == 2)
                    {
                        character_Step1_Points.transform.GetChild(1).gameObject.SetActive(false);
                        character_Step1_Points.transform.GetChild(2).gameObject.SetActive(true);
                    }
                    else if (pointNum == 3)
                    {
                        character_Step1_Points.transform.GetChild(2).gameObject.SetActive(false);
                        character_Step1_Points.transform.GetChild(3).gameObject.SetActive(true);
                    }
                    else if (pointNum == 4)
                    {
                        character_Step1_Points.transform.GetChild(3).gameObject.SetActive(false);
                        character_Step1_Points.transform.GetChild(4).gameObject.SetActive(true);
                    }
                    else if (pointNum == 5)
                    {
                        character_Step1_Points.transform.GetChild(4).gameObject.SetActive(false);
                        character_Step1_Points.transform.GetChild(5).gameObject.SetActive(true);
                    }
                    else if (pointNum == 6)
                    {
                        character_Step1_Points.transform.GetChild(5).gameObject.SetActive(false);
                        character_Step1_Points.transform.GetChild(6).gameObject.SetActive(true);
                    }
                }
                else if (DBManager.instance.currentStep == 2)
                {
                    if (pointNum == 1)
                    {
                        character_Step2_Points.transform.GetChild(0).gameObject.SetActive(false);
                        character_Step2_Points.transform.GetChild(1).gameObject.SetActive(true);
                    }
                    else if (pointNum == 2)
                    {
                        character_Step2_Points.transform.GetChild(1).gameObject.SetActive(false);
                        character_Step2_Points.transform.GetChild(2).gameObject.SetActive(true);
                    }
                    else if (pointNum == 3)
                    {
                        character_Step2_Points.transform.GetChild(2).gameObject.SetActive(false);
                        character_Step2_Points.transform.GetChild(3).gameObject.SetActive(true);
                    }
                    else if (pointNum == 4)
                    {
                        character_Step2_Points.transform.GetChild(3).gameObject.SetActive(false);
                        character_Step2_Points.transform.GetChild(4).gameObject.SetActive(true);
                    }
                    else if (pointNum == 5)
                    {
                        character_Step2_Points.transform.GetChild(4).gameObject.SetActive(false);
                        character_Step2_Points.transform.GetChild(5).gameObject.SetActive(true);
                    }
                    else if (pointNum == 6)
                    {
                        character_Step2_Points.transform.GetChild(5).gameObject.SetActive(false);
                        character_Step2_Points.transform.GetChild(6).gameObject.SetActive(true);
                    }
                    else if (pointNum == 7)
                    {
                        character_Step2_Points.transform.GetChild(6).gameObject.SetActive(false);
                        character_Step2_Points.transform.GetChild(7).gameObject.SetActive(true);
                    }
                    else if (pointNum == 8)
                    {
                        character_Step2_Points.transform.GetChild(7).gameObject.SetActive(false);
                        character_Step2_Points.transform.GetChild(8).gameObject.SetActive(true);
                    }
                    else if (pointNum == 9)
                    {
                        character_Step2_Points.transform.GetChild(8).gameObject.SetActive(false);
                        character_Step2_Points.transform.GetChild(9).gameObject.SetActive(true);
                    }
                }
                else if (DBManager.instance.currentStep == 3)
                {
                    if (pointNum == 1)
                    {
                        character_Step3_Points.transform.GetChild(0).gameObject.SetActive(false);
                        character_Step3_Points.transform.GetChild(1).gameObject.SetActive(true);
                    }
                    else if (pointNum == 2)
                    {
                        character_Step3_Points.transform.GetChild(1).gameObject.SetActive(false);
                        character_Step3_Points.transform.GetChild(2).gameObject.SetActive(true);
                    }
                    else if (pointNum == 3)
                    {
                        character_Step3_Points.transform.GetChild(2).gameObject.SetActive(false);
                        character_Step3_Points.transform.GetChild(3).gameObject.SetActive(true);
                    }
                    else if (pointNum == 4)
                    {
                        character_Step3_Points.transform.GetChild(3).gameObject.SetActive(false);
                        character_Step3_Points.transform.GetChild(4).gameObject.SetActive(true);
                    }
                    else if (pointNum == 5)
                    {
                        character_Step3_Points.transform.GetChild(4).gameObject.SetActive(false);
                        character_Step3_Points.transform.GetChild(5).gameObject.SetActive(true);
                    }
                    else if (pointNum == 6)
                    {
                        character_Step3_Points.transform.GetChild(5).gameObject.SetActive(false);
                        character_Step3_Points.transform.GetChild(6).gameObject.SetActive(true);
                    }
                    else if (pointNum == 7)
                    {
                        character_Step3_Points.transform.GetChild(6).gameObject.SetActive(false);
                        character_Step3_Points.transform.GetChild(7).gameObject.SetActive(true);
                    }
                    else if (pointNum == 8)
                    {
                        character_Step3_Points.transform.GetChild(7).gameObject.SetActive(false);
                        character_Step3_Points.transform.GetChild(8).gameObject.SetActive(true);
                    }
                    else if (pointNum == 9)
                    {
                        character_Step3_Points.transform.GetChild(8).gameObject.SetActive(false);
                        character_Step3_Points.transform.GetChild(9).gameObject.SetActive(true);
                    }
                    else if (pointNum == 10)
                    {
                        character_Step3_Points.transform.GetChild(9).gameObject.SetActive(false);
                        character_Step3_Points.transform.GetChild(10).gameObject.SetActive(true);
                    }
                    else if (pointNum == 11)
                    {
                        character_Step3_Points.transform.GetChild(10).gameObject.SetActive(false);
                        character_Step3_Points.transform.GetChild(11).gameObject.SetActive(true);
                    }
                    else if (pointNum == 12)
                    {
                        character_Step3_Points.transform.GetChild(11).gameObject.SetActive(false);
                        character_Step3_Points.transform.GetChild(12).gameObject.SetActive(true);
                    }
                    else if (pointNum == 13)
                    {
                        character_Step3_Points.transform.GetChild(12).gameObject.SetActive(false);
                        character_Step3_Points.transform.GetChild(13).gameObject.SetActive(true);
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
        if (DBManager.instance.currentStep == 1)
        {
            if (pointNum == 1)
            {
                if (step == 1)
                {
                    result += $"머리,{data},";
                }
            }
            else if (pointNum == 2)
            {
                if (step == 1)
                {
                    result += $"어깨,{data},";
                }
            }
            else if (pointNum == 3)
            {
                if (step == 1)
                {
                    result += $"가슴,{data},";
                }
            }
            else if (pointNum == 4)
            {
                if (step == 1)
                {
                    result += $"배,{data},";
                }
            }
            else if (pointNum == 5)
            {
                if (step == 1)
                {
                    result += $"무릎,{data},";
                }
            }
            else if (pointNum == 6)
            {
                if (step == 1)
                {
                    result += $"발,{data},";
                }
            }
        }
        else if (DBManager.instance.currentStep == 2)
        {
            if (pointNum == 1)
            {
                if (step == 1)
                {
                    result += $"머리,{data},";
                }
            }
            else if (pointNum == 2)
            {
                if (step == 1)
                {
                    result += $"눈,{data},";
                }
            }
            else if (pointNum == 3)
            {
                if (step == 1)
                {
                    result += $"코,{data},";
                }
            }
            else if (pointNum == 4)
            {
                if (step == 1)
                {
                    result += $"입,{data},";
                }
            }
            else if (pointNum == 5)
            {
                if (step == 1)
                {
                    result += $"목,{data},";
                }
            }
            else if (pointNum == 6)
            {
                if (step == 1)
                {
                    result += $"손,{data},";
                }
            }
            else if (pointNum == 7)
            {
                if (step == 1)
                {
                    result += $"엉덩이,{data},";
                }
            }
            else if (pointNum == 8)
            {
                if (step == 1)
                {
                    result += $"허벅지,{data},";
                }
            }
            else if (pointNum == 9)
            {
                if (step == 1)
                {
                    result += $"발,{data},";
                }
            }
        }
        else if (DBManager.instance.currentStep == 3)
        {
            if (pointNum == 1)
            {
                if (step == 1)
                {
                    result += $"머리,{data},";
                }
            }
            else if (pointNum == 2)
            {
                if (step == 1)
                {
                    result += $"눈,{data},";
                }
            }
            else if (pointNum == 3)
            {
                if (step == 1)
                {
                    result += $"코,{data},";
                }
            }
            else if (pointNum == 4)
            {
                if (step == 1)
                {
                    result += $"입,{data},";
                }
            }
            else if (pointNum == 5)
            {
                if (step == 1)
                {
                    result += $"목,{data},";
                }
            }
            else if (pointNum == 6)
            {
                if (step == 1)
                {
                    result += $"어깨,{data},";
                }
            }
            else if (pointNum == 7)
            {
                if (step == 1)
                {
                    result += $"가슴,{data},";
                }
            }
            else if (pointNum == 8)
            {
                if (step == 1)
                {
                    result += $"배,{data},";
                }
            }
            else if (pointNum == 9)
            {
                if (step == 1)
                {
                    result += $"손,{data},";
                }
            }
            else if (pointNum == 10)
            {
                if (step == 1)
                {
                    result += $"엉덩이,{data},";
                }
            }
            else if (pointNum == 11)
            {
                if (step == 1)
                {
                    result += $"허벅지,{data},";
                }
            }
            else if (pointNum == 12)
            {
                if (step == 1)
                {
                    result += $"무릎,{data},";
                }
            }
            else if (pointNum == 13)
            {
                if (step == 1)
                {
                    result += $"발,{data},";
                }
            }
        }

        if (step == 3)
        {
            result += $"{data},";
        }
    }

    public void Next()
    {
        isNext = true;
        var animator = success.GetComponent<Animator>();
        animator.Play("Close");
        Invoke("Success_Close", 0.5f);
    }

    public void Restart()
    {
        DBManager.instance.currentStage = "BodyRecog";
        SceneManager.LoadScene("Loading");
    }

    void Success_Close()
    {
        success.SetActive(false);
        success2.SetActive(false);
        DBManager.instance.currentStage = "EmotionRecog";
        SceneManager.LoadScene("Loading");
    }
}
