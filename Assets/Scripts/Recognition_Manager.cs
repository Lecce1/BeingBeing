using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Recognition_Manager : MonoBehaviour
{
    public GameObject character;
    public GameObject bodyRecog;
    public GameObject fade;
    public GameObject line;
    public GameObject choices;
    public GameObject next;
    public Text result = null;
    public GameObject emotionRecog;
    public GameObject emotionTimer;
    public GameObject emotionBtn;
    public GameObject emotionColor;
    public GameObject emotionComing;
    public GameObject emotionCloud;
    public GameObject emotionDot;
    private string emotionFeel;
    private float emotionStartTime;
    private float emotionTime;
    private bool isComing = false;
    private bool isCloud = false;
    private bool isDot = false;
    private int pointNum = 1;
    private int step = 0;
    private bool isStop = false;
    WaitForEndOfFrame waitForEndOfFrame = new WaitForEndOfFrame();
    Anim_Manager anim_Manager;
    private float emotionColorFill;
    
    void Awake()
    {
        anim_Manager = GameObject.Find("Anim_Manager").GetComponent<Anim_Manager>();
        anim_Manager.Fade_In();
    }

    void Update()
    {
        Line();
        EmotionColor();
        EmotionTimer();
        EmotionDot();
    }
    
    void Line()
    {
        if (bodyRecog.activeSelf == true)
        {
            if (isStop == false)
            {
                line.transform.Translate(new Vector3(0, -100f, 0) * Time.deltaTime);
            }

            if (pointNum == 1 && line.GetComponent<RectTransform>().anchoredPosition.y <= 660)
            {
                pointNum++;
                isStop = true;
                Point();
            }
            else if (pointNum == 2 && line.GetComponent<RectTransform>().anchoredPosition.y <= 100)
            {
                pointNum++;
                isStop = true;
                Point();
            }
            else if (pointNum == 3 && line.GetComponent<RectTransform>().anchoredPosition.y <= -75)
            {
                pointNum++;
                isStop = true;
                Point();
            }
            else if (pointNum == 4 && line.GetComponent<RectTransform>().anchoredPosition.y <= -250)
            {
                pointNum++;
                isStop = true;
                Point();
            }
            else if (pointNum == 5 && line.GetComponent<RectTransform>().anchoredPosition.y <= -570)
            {
                pointNum++;
                isStop = true;
                Point();
            }
            else if (pointNum == 6 && line.GetComponent<RectTransform>().anchoredPosition.y <= -900)
            {
                isStop = true;
                result.gameObject.SetActive(true);
                next.SetActive(true);
            }
        }
    }

    void Point()
    {
        choices.SetActive(true);
        choices.transform.GetChild(0).gameObject.SetActive(true);
        choices.transform.GetChild(0).GetChild(0).GetChild(0).GetComponent<Text>().text = "편하다";
        choices.transform.GetChild(0).GetChild(1).GetChild(0).GetComponent<Text>().text = "불편하다";
        step = 1;
    }

    public void Choice(int choiceNum)
    {
        if (step == 1)
        {
            Result(choices.transform.GetChild(0).GetChild(choiceNum - 1).GetChild(0).GetComponent<Text>().text);

            if (choiceNum == 1)
            {
                choices.transform.GetChild(0).gameObject.SetActive(false);
                choices.transform.GetChild(1).gameObject.SetActive(true);
                choices.transform.GetChild(1).GetChild(0).GetChild(0).GetComponent<Text>().text = "상쾌하다";
                choices.transform.GetChild(1).GetChild(1).GetChild(0).GetComponent<Text>().text = "가볍다";
                choices.transform.GetChild(1).GetChild(2).GetChild(0).GetComponent<Text>().text = "시원하다";
                choices.transform.GetChild(1).GetChild(3).GetChild(0).GetComponent<Text>().text = "따뜻하다";
                choices.transform.GetChild(1).GetChild(4).GetChild(0).GetComponent<Text>().text = "편안하다";
            }
            else if (choiceNum == 2)
            {
                choices.transform.GetChild(0).gameObject.SetActive(false);
                choices.transform.GetChild(1).gameObject.SetActive(true);
                choices.transform.GetChild(1).GetChild(0).GetChild(0).GetComponent<Text>().text = "불쾌하다";
                choices.transform.GetChild(1).GetChild(1).GetChild(0).GetComponent<Text>().text = "무겁다";
                choices.transform.GetChild(1).GetChild(2).GetChild(0).GetComponent<Text>().text = "갑갑하다";
                choices.transform.GetChild(1).GetChild(3).GetChild(0).GetComponent<Text>().text = "차갑다";
                choices.transform.GetChild(1).GetChild(4).GetChild(0).GetComponent<Text>().text = "불편하다";
            }

            step = 2;
        }
        else if (step == 2)
        {
            Result(choices.transform.GetChild(1).GetChild(choiceNum - 1).GetChild(0).GetComponent<Text>().text);
            choices.transform.GetChild(1).GetChild(0).GetChild(0).GetComponent<Text>().text = "매우 그렇다";
            choices.transform.GetChild(1).GetChild(1).GetChild(0).GetComponent<Text>().text = "조금 그렇다";
            choices.transform.GetChild(1).GetChild(2).GetChild(0).GetComponent<Text>().text = "보통이다";
            choices.transform.GetChild(1).GetChild(3).GetChild(0).GetComponent<Text>().text = "조금 그렇지 않다";
            choices.transform.GetChild(1).GetChild(4).GetChild(0).GetComponent<Text>().text = "매우 그렇지 않다";
            step = 3;
        }
        else if (step == 3)
        {
            Result(choices.transform.GetChild(1).GetChild(choiceNum - 1).GetChild(0).GetComponent<Text>().text);
            choices.SetActive(false);
            choices.transform.GetChild(1).gameObject.SetActive(false);
            isStop = false;
        }
    }

    void Result(string data)
    {
        if (pointNum - 1 == 1)
        {
            if (step == 1)
            {
                result.text += $"머리 : {data}, ";
            }
        }
        else if (pointNum - 1 == 2)
        {
            if (step == 1)
            {
                result.text += $"목 : {data}, ";
            }
        }
        else if (pointNum - 1 == 3)
        {
            if (step == 1)
            {
                result.text += $"배 : {data}, ";
            }
        }
        else if (pointNum - 1 == 4)
        {
            if (step == 1)
            {
                result.text += $"손 : {data}, ";
            }
        }
        else if (pointNum - 1 == 5)
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
            result.text += $"{data}\n";
        }
    }

    public void Next()
    {
        character.SetActive(false);
        bodyRecog.SetActive(false);
        emotionRecog.SetActive(true);
    }

    void EmotionTimer()
    {
        if (emotionRecog.activeSelf == true && emotionTimer.activeSelf == true)
        {
            emotionTime = Time.time - emotionStartTime;
            emotionTimer.GetComponent<Slider>().value = emotionTime;
        }
    }
    
    void EmotionColor()
    {
        if (emotionRecog.activeSelf == true && emotionColor.activeSelf == true)
        {
            if (isComing == false)
            {
                emotionColor.GetComponent<Image>().fillAmount += 0.1f * Time.deltaTime;

                if (emotionColor.GetComponent<Image>().fillAmount >= 0.7f)
                {
                    emotionComing.SetActive(true);
                }
            }
            else if (isComing == true)
            {
                if (isCloud == true)
                {
                    if (emotionColor.GetComponent<Image>().fillAmount > emotionColorFill / 2)
                    {
                        emotionColor.GetComponent<Image>().fillAmount -= 0.1f * Time.deltaTime;
                    }
                    else
                    {
                        isCloud = false;
                        emotionColorFill = 0;
                        
                        if (emotionColor.GetComponent<Image>().fillAmount != 0)
                        {
                            emotionCloud.SetActive(true);
                        }
                        else if (emotionColor.GetComponent<Image>().fillAmount == 0)
                        {
                            anim_Manager.EmotionColor();
                            isDot = true;
                            string rand = emotionFeel;

                            while (rand == emotionFeel)
                            {
                                int randNum = Random.Range(0, 4);

                                if (randNum == 0)
                                {
                                    rand = "Anger";
                                }
                                else if (randNum == 1)
                                {
                                    rand = "Unrest";
                                }
                                else if (randNum == 2)
                                {
                                    rand = "Remorse";
                                }
                                else if (randNum == 3)
                                {
                                    rand = "Sadness";
                                }
                            }
                            
                            emotionColor.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = rand;
                        }
                    }
                }
            }
        }
    }
    
    public void EmotionComing()
    {
        isComing = true;
        emotionComing.SetActive(false);
        emotionCloud.SetActive(true);
        emotionColorFill = emotionColor.GetComponent<Image>().fillAmount;
    }

    public void EmotionCloud(string type)
    {
        if (type == emotionFeel)
        {
            emotionCloud.SetActive(false);
            isCloud = true;
        }
        
        Destroy(EventSystem.current.currentSelectedGameObject);
    }

    void EmotionDot()
    {
        if (isDot == true && Input.GetMouseButton(0))
        {
            EventSystem eventSystem = EventSystem.current;
            Vector2 mousePosition = Input.mousePosition;
            PointerEventData pointerEventData = new PointerEventData(eventSystem);
            pointerEventData.position = mousePosition;
            List<RaycastResult> results = new List<RaycastResult>();
            EventSystem.current.RaycastAll(pointerEventData, results);
            
            if (results.Count > 0)
            {
                string uiObjectName = results[0].gameObject.name;

                if (uiObjectName == "Dot")
                {
                    emotionColor.GetComponent<Image>().fillAmount -= 0.1f * Time.deltaTime;
                }
            }
            
            if (emotionColor.GetComponent<Image>().fillAmount == 0)
            {
                anim_Manager.Fade_Out();
            }
        }
    }

    public void BtnCheck(string type)
    {
        if (type == "Anger")
        {
            emotionFeel = "Anger";
        }
        else if (type == "Unrest")
        {
            emotionFeel = "Unrest";
        }
        else if (type == "Remorse")
        {
            emotionFeel = "Remorse";
        }
        else if (type == "Sadness")
        {
            emotionFeel = "Sadness";
        }
        
        emotionBtn.SetActive(false);
        character.SetActive(true);
        character.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, -2.5f);
        emotionColor.SetActive(true);
        emotionColor.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = emotionFeel;
        emotionTimer.SetActive(true);
        emotionStartTime = Time.time;
    }
    
    public void Back()
    {
        anim_Manager.Fade_Out();
    }
}
