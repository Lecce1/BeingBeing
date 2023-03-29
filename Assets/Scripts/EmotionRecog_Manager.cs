using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class EmotionRecog_Manager : MonoBehaviour
{
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
    WaitForEndOfFrame waitForEndOfFrame = new WaitForEndOfFrame();
    GameManager gameManager;
    Anim_Manager anim_Manager;
    private float emotionColor_Fill = 1;

    void Awake()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        anim_Manager = GameObject.Find("Anim_Manager").GetComponent<Anim_Manager>();
    }

    void Update()
    {
        EmotionTimer();
        EmotionColor();
        EmotionDot();
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
        if (emotionColor.activeSelf == true)
        {
            if (isComing == false)
            {
                emotionColor.GetComponent<Image>().fillAmount += 0.1f * Time.deltaTime;

                if (emotionColor.GetComponent<Image>().fillAmount == 1f)
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
                    if (emotionColor.GetComponent<Image>().fillAmount > emotionColor_Fill / 2)
                    {
                        emotionColor.GetComponent<Image>().fillAmount -= 0.1f * Time.deltaTime;
                    }
                    else
                    {
                        isCloud = false;
                        emotionColor_Fill = 0;
                        
                        if (emotionColor.GetComponent<Image>().fillAmount != 0)
                        {
                            emotionCloud.SetActive(true);
                        }
                        else if (emotionColor.GetComponent<Image>().fillAmount == 0)
                        {
                            emotionComing.SetActive(false);
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
    
    void EmotionComing()
    {
        emotionComing.transform.GetChild(2).gameObject.SetActive(false);
        emotionCloud.SetActive(true);
    }

    public void EmotionCloud(string type)
    {
        if (type == emotionFeel)
        {
            emotionCloud.SetActive(false);
            isCloud = true;
        }
        
        EventSystem.current.currentSelectedGameObject.SetActive(false);
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
                shadow.SetActive(true);
                success.SetActive(true);
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
        
        Invoke("BtnCheck2", 0.5f);
    }

    void BtnCheck2()
    {
        emotionBtn.SetActive(false);
        character.SetActive(true);
        emotionColor.SetActive(true);
        emotionColor.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = emotionFeel;
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
        
        gameManager.isLevel_Start = false;
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
        gameManager.isLevel_Start = false;
        anim_Manager.Fade_Out();
    }

    public void Reset()
    {
        character.SetActive(false);
        emotionTimer.SetActive(false);
        emotionTimer.GetComponent<Slider>().value = 0;
        emotionBtn.SetActive(true);
        emotionColor.SetActive(false);
        emotionColor.GetComponent<Image>().fillAmount = 0;
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
        emotionColor_Fill = 1;
    }
}
