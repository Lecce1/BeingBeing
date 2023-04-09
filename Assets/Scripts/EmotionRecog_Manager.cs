using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class EmotionRecog_Manager : MonoBehaviour
{
    public GameObject tutorial;
    public GameObject tutorial_Notice;
    public GameObject tutorial_EmotionComing;
    public GameObject tutorial_EmotionBtn;
    public GameObject tutorial_Character;
    public GameObject tutorial_EmotionColor;
    public GameObject tutorial_EmotionCloud;
    public GameObject tutorial_EmotionDot;
    public GameObject game;
    public GameObject character;
    public GameObject emotionTimer;
    public GameObject emotionBtn;
    public GameObject emotionColor;
    public GameObject emotionComing;
    public GameObject emotionCloud;
    public GameObject emotionDot;
    public GameObject shadow;
    public GameObject success;
    public GameObject fail;
    private string emotionFeel;
    private float emotionStartTime;
    private float emotionTime;
    private bool isComing = false;
    private bool isCloud = false;
    private bool isDot = false;
    Anim_Manager anim_Manager;
    WaitForSeconds waitForSeconds = new WaitForSeconds(0.01f);
    private float emotionColor_Fill = 5;
    public bool isTutorial;
    private bool isTutorial_Check;

    void Awake()
    {
        anim_Manager = GameObject.Find("Anim_Manager").GetComponent<Anim_Manager>();
    }

    void Update()
    {
        Tutorial();
        EmotionTimer();
        EmotionColor();
        EmotionDot();
    }
    
    void Tutorial()
    {
        if (isTutorial == true && isTutorial_Check == false)
        {
            isTutorial_Check = true;
            isComing = false;
            isCloud = false;
            isDot = false;
            emotionColor_Fill = 5;
            tutorial.SetActive(false);
            game.SetActive(true);
        }
    }

    public void Skip()
    {
        isTutorial = true;
    }
    
    void EmotionTimer()
    {
        if (emotionTimer.activeSelf == true && success.activeSelf == false)
        {
            emotionTime = 45 - (Time.time - emotionStartTime);
            emotionTimer.GetComponent<Slider>().value = emotionTime;

            if (emotionTimer.GetComponent<Slider>().value == 0)
            {
                shadow.SetActive(true);
                fail.SetActive(true);
            }
        }
    }
    
    void EmotionColor()
    {
        if (isTutorial == false)
        {
            if (tutorial_EmotionColor.activeSelf == true)
            {
                if (isComing == false)
                {
                    tutorial_EmotionColor.GetComponent<RectTransform>().localScale += new Vector3(0, 1f * Time.deltaTime, 0);

                    if (tutorial_EmotionColor.GetComponent<RectTransform>().localScale.y >= 5f)
                    {
                        tutorial_EmotionComing.SetActive(true);
                        isComing = true;
                        Invoke("EmotionComing", 3.0f);
                    }
                }
                else if (isComing == true)
                {
                    if (isCloud == true)
                    {
                        if (tutorial_EmotionColor.GetComponent<RectTransform>().localScale.y > emotionColor_Fill / 2)
                        {
                            tutorial_EmotionColor.GetComponent<RectTransform>().localScale += new Vector3(0, -1f * Time.deltaTime, 0);
                        }
                        else
                        {
                            isCloud = false;
                            emotionColor_Fill = 0;
                            
                            if (tutorial_EmotionColor.GetComponent<RectTransform>().localScale.y > 0)
                            {
                                tutorial_EmotionCloud.SetActive(true);
                            }
                            else if (tutorial_EmotionColor.GetComponent<RectTransform>().localScale.y <= 0)
                            {
                                tutorial_EmotionComing.SetActive(false);
                                isDot = true;
                                string rand = emotionFeel;

                                while (rand == emotionFeel)
                                {
                                    int randNum = Random.Range(0, 4);

                                    if (randNum == 0)
                                    {
                                        rand = "Anger";
                                        tutorial_EmotionColor.GetComponent<Image>().color = Color.red;
                                    }
                                    else if (randNum == 1)
                                    {
                                        rand = "Unrest";
                                        tutorial_EmotionColor.GetComponent<Image>().color = Color.black;
                                    }
                                    else if (randNum == 2)
                                    {
                                        rand = "Remorse";
                                        tutorial_EmotionColor.GetComponent<Image>().color = Color.gray;
                                    }
                                    else if (randNum == 3)
                                    {
                                        rand = "Sadness";
                                        tutorial_EmotionColor.GetComponent<Image>().color = Color.blue;
                                    }
                                }
                                
                                StartCoroutine("EmotionColor2");
                            }
                        }
                    }
                }
            }
        }
        else if (isTutorial == true)
        { 
            if (emotionColor.activeSelf == true)
            {
                if (isComing == false)
                {
                    emotionColor.GetComponent<RectTransform>().localScale += new Vector3(0, 1f * Time.deltaTime, 0);

                    if (emotionColor.GetComponent<RectTransform>().localScale.y >= 5f)
                    {
                        emotionStartTime = Time.time;
                        emotionTimer.SetActive(true);
                        emotionComing.SetActive(true);
                        isComing = true;
                        Invoke("EmotionComing", 3.0f);
                    }
                }
                else if (isComing == true)
                {
                    if (isCloud == true)
                    {
                        if (emotionColor.GetComponent<RectTransform>().localScale.y > emotionColor_Fill / 2)
                        {
                            emotionColor.GetComponent<RectTransform>().localScale += new Vector3(0, -1f * Time.deltaTime, 0);
                        }
                        else
                        {
                            isCloud = false;
                            emotionColor_Fill = 0;
                            
                            if (emotionColor.GetComponent<RectTransform>().localScale.y > 0)
                            {
                                emotionCloud.SetActive(true);
                            }
                            else if (emotionColor.GetComponent<RectTransform>().localScale.y <= 0)
                            {
                                emotionComing.SetActive(false);
                                isDot = true;
                                string rand = emotionFeel;

                                while (rand == emotionFeel)
                                {
                                    int randNum = Random.Range(0, 4);

                                    if (randNum == 0)
                                    {
                                        rand = "Anger";
                                        emotionColor.GetComponent<Image>().color = Color.red;
                                    }
                                    else if (randNum == 1)
                                    {
                                        rand = "Unrest";
                                        emotionColor.GetComponent<Image>().color = Color.black;
                                    }
                                    else if (randNum == 2)
                                    {
                                        rand = "Remorse";
                                        emotionColor.GetComponent<Image>().color = Color.gray;
                                    }
                                    else if (randNum == 3)
                                    {
                                        rand = "Sadness";
                                        emotionColor.GetComponent<Image>().color = Color.blue;
                                    }
                                }
                                
                                StartCoroutine("EmotionColor2");
                            }
                        }
                    }
                }
            }
        }
    }

    IEnumerator EmotionColor2()
    {
        if (isTutorial == false)
        {
            tutorial_Notice.GetComponent<TextMeshProUGUI>().text = "";
            
            while (tutorial_EmotionColor.GetComponent<RectTransform>().localScale.y < 2.5f)
            {
                tutorial_EmotionColor.GetComponent<RectTransform>().localScale += new Vector3(0, 1f * Time.deltaTime, 0);
                yield return waitForSeconds;
            }
            
            tutorial_Notice.GetComponent<TextMeshProUGUI>().text = "움직이는 점을 따라 드래그 하면 감정의 색이 내려갑니다" + "\n" + "끝까지 내려주세요";
            tutorial_Notice.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, -200);
        }
        else if (isTutorial == true)
        {
            while (emotionColor.GetComponent<RectTransform>().localScale.y < 2.5f)
            {
                emotionColor.GetComponent<RectTransform>().localScale += new Vector3(0, 1f * Time.deltaTime, 0);
                yield return waitForSeconds;
            }
        }
        
        anim_Manager.Dot();
    }

    void EmotionComing()
    {
        if (isTutorial == false)
        {
            tutorial_EmotionComing.transform.GetChild(1).gameObject.SetActive(false);
            tutorial_EmotionCloud.SetActive(true);
            tutorial_Notice.GetComponent<TextMeshProUGUI>().text = "감정에 맞는 말풍선을 선택하세요";
            tutorial_Notice.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, -100);
        }
        else if (isTutorial == true)
        {
            emotionComing.transform.GetChild(2).gameObject.SetActive(false);
            emotionCloud.SetActive(true);
        }
    }

    public void EmotionCloud(string type)
    {
        if (isTutorial == false)
        {
            if (type == emotionFeel)
            {
                tutorial_EmotionCloud.SetActive(false);
                isCloud = true;
            }
        }
        else if (isTutorial == true)
        {
            if (type == emotionFeel)
            {
                emotionCloud.SetActive(false);
                isCloud = true;
            }
        }
        
        EventSystem.current.currentSelectedGameObject.SetActive(false);
    }

    void EmotionDot()
    {
        if (isTutorial == false)
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
                        tutorial_EmotionColor.GetComponent<RectTransform>().localScale += new Vector3(0, -0.5f * Time.deltaTime, 0);
                    }
                }
            
                if (tutorial_EmotionColor.GetComponent<RectTransform>().localScale.y <= 0)
                {
                    tutorial_Notice.GetComponent<TextMeshProUGUI>().text = "잘했어요! 튜토리얼은 여기까지~";
                    Invoke("Skip", 3.0f);
                }
            }
        }
        else if (isTutorial == true)
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
                        emotionColor.GetComponent<RectTransform>().localScale += new Vector3(0, -0.5f * Time.deltaTime, 0);
                    }
                }
            
                if (emotionColor.GetComponent<RectTransform>().localScale.y <= 0)
                {
                    shadow.SetActive(true);
                    success.SetActive(true);
                }
            }
        }
    }

    public void BtnCheck(string type)
    {
        if (isTutorial == false)
        {
            if (type == "Anger")
            {
                emotionFeel = "Anger";
                tutorial_EmotionColor.GetComponent<Image>().color = Color.red;
            }
            else if (type == "Unrest")
            {
                emotionFeel = "Unrest";
                tutorial_EmotionColor.GetComponent<Image>().color = Color.black;
            }
            else if (type == "Remorse")
            {
                emotionFeel = "Remorse";
                tutorial_EmotionColor.GetComponent<Image>().color = Color.gray;
            }
            else if (type == "Sadness")
            {
                emotionFeel = "Sadness";
                tutorial_EmotionColor.GetComponent<Image>().color = Color.blue;
            }
        }
        else if (isTutorial == true)
        {
            if (type == "Anger")
            {
                emotionFeel = "Anger";
                emotionColor.GetComponent<Image>().color = Color.red;
            }
            else if (type == "Unrest")
            {
                emotionFeel = "Unrest";
                emotionColor.GetComponent<Image>().color = Color.black;
            }
            else if (type == "Remorse")
            {
                emotionFeel = "Remorse";
                emotionColor.GetComponent<Image>().color = Color.gray;
            }
            else if (type == "Sadness")
            {
                emotionFeel = "Sadness";
                emotionColor.GetComponent<Image>().color = Color.blue;
            }
        }
        
        Invoke("BtnCheck2", 0.5f);
    }

    void BtnCheck2()
    {
        if (isTutorial == false)
        {
            tutorial_Notice.GetComponent<TextMeshProUGUI>().text = "감정의 색이 끝까지 차오르면 그분이 등장합니다";
            tutorial_EmotionBtn.SetActive(false);
            tutorial_Character.SetActive(true);
            tutorial_EmotionColor.SetActive(true);
        }
        else if (isTutorial == true)
        {
            emotionBtn.SetActive(false);
            character.SetActive(true);
            emotionColor.SetActive(true);
        }
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
        
        anim_Manager.Fade_Out();
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
    
    public void Back()
    {
        anim_Manager.Fade_Out();
    }

    public void Reset()
    {
        tutorial.SetActive(true);
        tutorial_Notice.GetComponent<TextMeshProUGUI>().text = "자신의 상황에 맞는 감정을 선택해주세요";
        tutorial_Notice.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, -300);
        tutorial_EmotionComing.SetActive(false);
        tutorial_EmotionComing.transform.GetChild(1).gameObject.SetActive(true);
        tutorial_EmotionCloud.SetActive(false);
        tutorial_EmotionBtn.SetActive(true);
        tutorial_Character.SetActive(false);
        tutorial_EmotionColor.SetActive(false);
        tutorial_EmotionDot.SetActive(false);
        isTutorial = false;
        isTutorial_Check = false;
        game.SetActive(false);
        character.SetActive(false);
        emotionTimer.SetActive(false);
        emotionTimer.GetComponent<Slider>().value = 0;
        emotionBtn.SetActive(true);
        emotionColor.SetActive(false);
        emotionColor.GetComponent<RectTransform>().localScale = new Vector3(5, 0, 5);
        emotionComing.SetActive(false);
        emotionComing.transform.GetChild(2).gameObject.SetActive(true);
        emotionCloud.SetActive(false);
        emotionCloud.transform.GetChild(0).gameObject.SetActive(true);
        emotionCloud.transform.GetChild(1).gameObject.SetActive(true);
        emotionCloud.transform.GetChild(2).gameObject.SetActive(true);
        emotionCloud.transform.GetChild(3).gameObject.SetActive(true);
        emotionCloud.transform.GetChild(4).gameObject.SetActive(true);
        emotionCloud.transform.GetChild(5).gameObject.SetActive(true);
        emotionCloud.transform.GetChild(6).gameObject.SetActive(true);
        emotionCloud.transform.GetChild(7).gameObject.SetActive(true);
        emotionDot.SetActive(false);
        emotionDot.GetComponent<RectTransform>().anchoredPosition = new Vector2(-450, -900);
        isComing = false;
        isCloud = false;
        isDot = false;
        shadow.SetActive(false);
        emotionColor_Fill = 5;
    }
}
