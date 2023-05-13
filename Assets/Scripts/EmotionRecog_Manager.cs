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
    public GameObject tutorial_EmotionComingBtn;
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
    public GameObject emotionComingBtn;
    public GameObject emotionComing;
    public GameObject emotionCloud;
    public GameObject emotionDot;
    public GameObject shadow;
    public GameObject success;
    public GameObject fail;
    private string emotionFeel;
    private float emotionStartTime;
    private float emotionTime;
    private bool isTimer = false;
    private bool isComing = false;
    private bool isCloud = false;
    private bool isDot = false;
    private bool isDot2 = false;
    public bool isNext = false;
    GameManager gameManager;
    AnimManager animManager;
    WaitForSeconds waitForSeconds = new WaitForSeconds(0.01f);
    private float emotionColor_Fill;
    public bool isTutorial;
    private bool isTutorial_Check;
    private bool isTutorial_Check2;
    private List<string> cloud_Text = new List<string> {"너 때문이야", "다 부숴버릴거야", "잘못되면 끝이야", "다른 사람이 알면 큰일인데", "나 때문이야", "내가 원망스러워", "좋은 사람은 다 가버리네", "내 편은 아무도 없어"};

    void Awake()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        animManager = GameObject.Find("AnimManager").GetComponent<AnimManager>();
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
            isComing = false;
            isCloud = false;
            isDot = false;
            tutorial.SetActive(false);
            game.SetActive(true);
            gameManager.buttons.SetActive(true);
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
            emotionTimer.transform.GetChild(0).GetComponent<Image>().fillAmount = emotionTime * (1f / 45f);

            if (emotionTime <= 10 && isTimer == false)
            {
                isTimer = true;
                emotionTimer.GetComponent<Animator>().Play("Emotion_Timer");
            }
            
            if (emotionTimer.transform.GetChild(0).GetComponent<Image>().fillAmount == 0)
            {
                shadow.SetActive(true);
                fail.SetActive(true);
            }
        }
    }

    public void EmotionComingBtn()
    {
        if (isTutorial == false)
        {
            tutorial_EmotionComingBtn.SetActive(false);
            tutorial_EmotionComing.SetActive(true);
            isComing = true;
            Invoke("EmotionComing", 3.0f);
        }
        else if (isTutorial == true)
        {
            emotionComingBtn.SetActive(false);
            emotionComing.SetActive(true);
            isComing = true;
            Invoke("EmotionComing", 3.0f);
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
                    tutorial_EmotionColor.GetComponent<RectTransform>().localScale += new Vector3(0, 0.5f * Time.deltaTime, 0);
                    
                    if (tutorial_EmotionColor.GetComponent<RectTransform>().localScale.y >= 2.5f)
                    {
                        tutorial_EmotionComingBtn.SetActive(true);
                        tutorial_EmotionComingBtn.GetComponent<Animator>().Play("Emotion_Tutorial_Coming");
                        tutorial_Notice.GetComponent<TextMeshProUGUI>().text = "감정의 색이 머리 끝까지 차오르전에 버튼을 눌러주세요";
                    }

                    if (tutorial_EmotionColor.GetComponent<RectTransform>().localScale.y >= 5f)
                    {
                        isComing = true;
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
                                tutorial_Notice.GetComponent<TextMeshProUGUI>().text = "";
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
                    emotionColor.GetComponent<RectTransform>().localScale += new Vector3(0, 0.5f * Time.deltaTime, 0);
                    
                    if (emotionColor.GetComponent<RectTransform>().localScale.y >= 2.5f)
                    {
                        emotionComingBtn.SetActive(true);
                        emotionComingBtn.GetComponent<Animator>().Play("Emotion_Coming");
                    }

                    if (emotionColor.GetComponent<RectTransform>().localScale.y >= 5f)
                    {
                        isComing = true;
                        shadow.SetActive(true);
                        fail.SetActive(true);
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
            while (tutorial_EmotionColor.GetComponent<RectTransform>().localScale.y < 2.5f)
            {
                tutorial_EmotionColor.GetComponent<RectTransform>().localScale += new Vector3(0, 1f * Time.deltaTime, 0);
                yield return waitForSeconds;
            }
            
            tutorial_Notice.GetComponent<TextMeshProUGUI>().text = "감정의 색을 꾹 누르면 감정이 점점 줄어듭니다." + "\n" + "끝까지 내려주세요";
            tutorial_Notice.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, -200);
            isDot = true;
        }
        else if (isTutorial == true)
        {
            while (emotionColor.GetComponent<RectTransform>().localScale.y < 2.5f)
            {
                emotionColor.GetComponent<RectTransform>().localScale += new Vector3(0, 1f * Time.deltaTime, 0);
                yield return waitForSeconds;
            }

            if (isDot == false)
            {
                isDot = true;
            }
            else
            {
                isDot2 = true;
            }

        }
    }

    void EmotionComing()
    {
        if (isTutorial == false)
        {
            emotionColor_Fill = tutorial_EmotionColor.transform.localScale.y;
            tutorial_EmotionComing.transform.GetChild(1).gameObject.SetActive(false);
            tutorial_EmotionCloud.SetActive(true);
            tutorial_Notice.GetComponent<TextMeshProUGUI>().text = "감정에 맞는 말풍선을 선택하세요";
            tutorial_Notice.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, -100);
        }
        else if (isTutorial == true)
        {
            emotionColor_Fill = emotionColor.transform.localScale.y;
            emotionComing.transform.GetChild(2).gameObject.SetActive(false);
            
            for (int i = 0; i < 8; i++)
            {
                int num = Random.Range(0, cloud_Text.Count);
                emotionCloud.transform.GetChild(i).GetChild(0).GetComponent<TextMeshProUGUI>().text = cloud_Text[num];

                if (cloud_Text[num] == "너 때문이야" || cloud_Text[num] == "다 부숴버릴거야")
                {
                    emotionCloud.transform.GetChild(i).GetComponent<Button>().onClick.AddListener(() => EmotionCloud("Anger"));
                }
                else if (cloud_Text[num] == "잘못되면 끝이야" || cloud_Text[num] == "다른 사람이 알면 큰일인데")
                {
                    emotionCloud.transform.GetChild(i).GetComponent<Button>().onClick.AddListener(() => EmotionCloud("Unrest"));
                }
                else if (cloud_Text[num] == "나 때문이야" || cloud_Text[num] == "내가 원망스러워")
                {
                    emotionCloud.transform.GetChild(i).GetComponent<Button>().onClick.AddListener(() => EmotionCloud("Remorse"));
                }
                else if (cloud_Text[num] == "좋은 사람은 다 가버리네" || cloud_Text[num] == "내 편은 아무도 없어")
                {
                    emotionCloud.transform.GetChild(i).GetComponent<Button>().onClick.AddListener(() => EmotionCloud("Sadness"));
                }
                
                cloud_Text.RemoveAt(num);
            }
            
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

                    if (uiObjectName == "EmotionColor")
                    {
                        tutorial_EmotionColor.GetComponent<RectTransform>().localScale += new Vector3(0, -0.5f * Time.deltaTime, 0);
                    }
                }
            
                if (tutorial_EmotionColor.GetComponent<RectTransform>().localScale.y <= 0.5f)
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
                    string uiName = results[0].gameObject.name;

                    if (uiName == "EmotionColor")
                    {
                        emotionColor.GetComponent<RectTransform>().localScale += new Vector3(0, -0.5f * Time.deltaTime, 0);
                    }
                }
            
                if (emotionColor.GetComponent<RectTransform>().localScale.y <= 0.5f)
                {
                    if (isDot == true && isDot2 == false)
                    {
                        emotionComing.SetActive(false);
                        emotionComing.transform.GetChild(2).gameObject.SetActive(true);
                        character.SetActive(false);
                        emotionColor.SetActive(false);
                        emotionBtn.SetActive(true);
                    }
                    else if (isDot == true && isDot2 == true)
                    {
                        isDot = false;
                        isDot2 = false;
                        isNext = true;
                        animManager.Fade_Out();
                    }
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
                tutorial_EmotionBtn.transform.GetChild(0).GetComponent<Button>().interactable = false;
                tutorial_EmotionBtn.transform.GetChild(0).GetChild(1).GetComponent<Image>().color =
                    new Color(255, 255, 255, 0.3f);
            }
            else if (type == "Unrest")
            {
                emotionFeel = "Unrest";
                tutorial_EmotionColor.GetComponent<Image>().color = Color.black;
                tutorial_EmotionBtn.transform.GetChild(1).GetComponent<Button>().interactable = false;
                tutorial_EmotionBtn.transform.GetChild(1).GetChild(1).GetComponent<Image>().color =
                    new Color(255, 255, 255, 0.3f);
                
            }
            else if (type == "Sadness")
            {
                emotionFeel = "Sadness";
                tutorial_EmotionColor.GetComponent<Image>().color = Color.blue;
                tutorial_EmotionBtn.transform.GetChild(2).GetComponent<Button>().interactable = false;
                tutorial_EmotionBtn.transform.GetChild(2).GetChild(1).GetComponent<Image>().color =
                    new Color(255, 255, 255, 0.3f);
            }
            else if (type == "Remorse")
            {
                emotionFeel = "Remorse";
                tutorial_EmotionColor.GetComponent<Image>().color = Color.gray;
                tutorial_EmotionBtn.transform.GetChild(3).GetComponent<Button>().interactable = false;
                tutorial_EmotionBtn.transform.GetChild(3).GetChild(1).GetComponent<Image>().color =
                    new Color(255, 255, 255, 0.3f);
            }
        }
        else if (isTutorial == true)
        {
            if (type == "Anger")
            {
                emotionFeel = "Anger";
                emotionColor.GetComponent<Image>().color = Color.red;
                emotionBtn.transform.GetChild(0).GetComponent<Button>().interactable = false;
                emotionBtn.transform.GetChild(0).GetChild(1).GetComponent<Image>().color =
                    new Color(255, 255, 255, 0.3f);
            }
            else if (type == "Unrest")
            {
                emotionFeel = "Unrest";
                emotionColor.GetComponent<Image>().color = Color.black;
                emotionBtn.transform.GetChild(1).GetComponent<Button>().interactable = false;
                emotionBtn.transform.GetChild(1).GetChild(1).GetComponent<Image>().color =
                    new Color(255, 255, 255, 0.3f);
            }
            else if (type == "Sadness")
            {
                emotionFeel = "Sadness";
                emotionColor.GetComponent<Image>().color = Color.blue;
                emotionBtn.transform.GetChild(2).GetComponent<Button>().interactable = false;
                emotionBtn.transform.GetChild(2).GetChild(1).GetComponent<Image>().color =
                    new Color(255, 255, 255, 0.3f);
            }
            else if (type == "Remorse")
            {
                emotionFeel = "Remorse";
                emotionColor.GetComponent<Image>().color = Color.gray;
                emotionBtn.transform.GetChild(3).GetComponent<Button>().interactable = false;
                emotionBtn.transform.GetChild(3).GetChild(1).GetComponent<Image>().color =
                    new Color(255, 255, 255, 0.3f);
            }
        }
        
        Invoke("BtnCheck2", 0.5f);
    }

    void BtnCheck2()
    {
        if (isTutorial == false)
        {
            if (isDot == false)
            {
                tutorial_Notice.GetComponent<TextMeshProUGUI>().text = "감정의 색이 목까지 차오르면 그분이 등장합니다";
                tutorial_EmotionBtn.SetActive(false);
                tutorial_Character.SetActive(true);
                tutorial_EmotionColor.SetActive(true);
            }
            else if (isDot == true)
            {
                tutorial_EmotionBtn.SetActive(false);
                tutorial_Character.SetActive(true);
                tutorial_EmotionColor.SetActive(true);
                StartCoroutine("EmotionColor2");
            }
        }
        else if (isTutorial == true)
        {
            if (isDot == false)
            {
                emotionStartTime = Time.time;
                emotionTimer.SetActive(true);
                emotionBtn.SetActive(false);
                character.SetActive(true);
                emotionColor.SetActive(true); 
            }
            else if (isDot == true)
            {
                emotionStartTime = Time.time;
                isComing = false;
                isCloud = false;
                cloud_Text = new List<string> {"너 때문이야", "다 부숴버릴거야", "잘못되면 끝이야", "다른 사람이 알면 큰일인데", "나 때문이야", "내가 원망스러워", "좋은 사람은 다 가버리네", "내 편은 아무도 없어"};

                for (int i = 0; i < 8; i++)
                {
                    emotionCloud.transform.GetChild(i).gameObject.SetActive(true);
                }

                emotionBtn.SetActive(false);
                character.SetActive(true);
                emotionColor.SetActive(true);
            }
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
        tutorial_Notice.GetComponent<TextMeshProUGUI>().text = "다음의 감정 중 하나를 선택해주세요";
        tutorial_Notice.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, -300);
        tutorial_EmotionComing.SetActive(false);
        tutorial_EmotionComingBtn.SetActive(false);
        tutorial_EmotionComing.transform.GetChild(1).gameObject.SetActive(true);
        tutorial_EmotionCloud.SetActive(false);
        tutorial_EmotionBtn.SetActive(true);
        tutorial_EmotionBtn.transform.GetChild(0).GetComponent<Button>().interactable = true;
        tutorial_EmotionBtn.transform.GetChild(0).GetChild(1).GetComponent<Image>().color =
            new Color(255, 255, 255, 1);
        tutorial_EmotionBtn.transform.GetChild(1).GetComponent<Button>().interactable = true;
        tutorial_EmotionBtn.transform.GetChild(1).GetChild(1).GetComponent<Image>().color =
            new Color(255, 255, 255, 1);
        tutorial_EmotionBtn.transform.GetChild(2).GetComponent<Button>().interactable = true;
        tutorial_EmotionBtn.transform.GetChild(2).GetChild(1).GetComponent<Image>().color =
            new Color(255, 255, 255, 1);
        tutorial_EmotionBtn.transform.GetChild(3).GetComponent<Button>().interactable = true;
        tutorial_EmotionBtn.transform.GetChild(3).GetChild(1).GetComponent<Image>().color =
            new Color(255, 255, 255, 1);
        tutorial_Character.SetActive(false);
        tutorial_EmotionColor.SetActive(false);
        tutorial_EmotionColor.GetComponent<RectTransform>().localScale = new Vector3(5, 0, 5);
        tutorial_EmotionDot.SetActive(false);
        isTutorial = false;
        isTutorial_Check = false;
        isTutorial_Check2 = false;
        game.SetActive(false);
        character.SetActive(false);
        emotionTimer.SetActive(false);
        emotionTimer.transform.GetChild(0).GetComponent<Image>().fillAmount = 1;
        emotionTimer.transform.GetChild(0).GetComponent<Image>().color = Color.black;
        emotionBtn.SetActive(true);
        emotionBtn.transform.GetChild(0).GetComponent<Button>().interactable = true;
        emotionBtn.transform.GetChild(0).GetChild(1).GetComponent<Image>().color =
            new Color(255, 255, 255, 1);
        emotionBtn.transform.GetChild(1).GetComponent<Button>().interactable = true;
        emotionBtn.transform.GetChild(1).GetChild(1).GetComponent<Image>().color =
            new Color(255, 255, 255, 1);
        emotionBtn.transform.GetChild(2).GetComponent<Button>().interactable = true;
        emotionBtn.transform.GetChild(2).GetChild(1).GetComponent<Image>().color =
            new Color(255, 255, 255, 1);
        emotionBtn.transform.GetChild(3).GetComponent<Button>().interactable = true;
        emotionBtn.transform.GetChild(3).GetChild(1).GetComponent<Image>().color =
            new Color(255, 255, 255, 1);
        emotionColor.SetActive(false);
        emotionColor.GetComponent<RectTransform>().localScale = new Vector3(5, 0, 5);
        emotionComingBtn.SetActive(false);
        emotionComing.SetActive(false);
        emotionComing.transform.GetChild(2).gameObject.SetActive(true);
        cloud_Text = new List<string> {"너 때문이야", "다 부숴버릴거야", "잘못되면 끝이야", "다른 사람이 알면 큰일인데", "나 때문이야", "내가 원망스러워", "좋은 사람은 다 가버리네", "내 편은 아무도 없어"};
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
        isTimer = false;
        isComing = false;
        isCloud = false;
        isDot = false;
        isDot2 = false;
        isNext = false;
        shadow.SetActive(false);
    }
}
