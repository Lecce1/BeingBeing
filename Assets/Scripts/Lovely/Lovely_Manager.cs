using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class Lovely_Manager : MonoBehaviour
{
    public GameObject tutorial;
    public TMP_Text tutorial_Notice;
    public GameObject game;
    public GameObject first;
    public GameObject first_Character_Step1;
    public GameObject first_Character_Step2;
    public GameObject first_Character_Step3;
    public GameObject dragArea;
    public GameObject second;
    public GameObject second_Character_Step1;
    public GameObject second_Character_Step2;
    public GameObject second_Character_Step3;
    public GameObject character;
    public GameObject timer;
    public Text notice;
    public GameObject emotionBtn;
    public GameObject emotionColor;
    public List<Sprite> emotionColor_Sprite;
    public GameObject dot;
    public GameObject balloon;
    public GameObject backGlow;
    public GameObject shadow;
    public GameObject success;
    public GameObject fail;
    public GameObject loading;
    public GameObject bar;
    public GameObject heart;
    public GameObject heart2;
    public int heartNum;
    private string emotionFeel;
    private float emotionStartTime;
    private float emotionTime;
    private bool isFill;
    private bool isTimer;
    public int stage = 1;
    private bool isDot;
    private bool isHeart;
    public bool isNext;
    private bool isUp;
    private bool isDown;
    private bool isUp2;
    private bool isDown2;
    public bool isTutorial = true;
    private bool isTutorial_Check;
    private bool isTutorial_Check2;
    private Vector2 startPos;
    private Vector2 currentPos;
    public int touch = 0;
    private List<string> heart_Text = new List<string> {"고마워", "힘이나", "편안해", "기분이 좋아", "사랑해", "잘했어", "최고야", "힘빠져", "기분 나빠", "불편해", "뭘 잘해?", "잘못 했네", "최악이야"};
    public int heart_Fail = 0;
    public List<GameObject> lifes;
    private List<RaycastResult> results = new ();
    WaitForSeconds waitForSeconds = new (0.01f);
    private int tutorial_Notice_Num = 1;
    
    void Update()
    {
        Tutorial();
        EmotionTimer();
        EmotionColor();
        EmotionDot();
        Cursor();
        Touch();
        Heart();
        Heart2();
    }
    
    void Tutorial()
    {
        if (!isTutorial && !isTutorial_Check)
        {
            if (!isTutorial_Check)
            {
                isTutorial_Check = true;

                if (PlayerPrefs.GetInt("Lovely_Tutorial") == 0)
                {
                    isTutorial = false;
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

                    if (tutorial_Notice_Num != 6)
                    {
                        Tutorial_Notice();
                    }
                }
            }
        }
        else if (isTutorial && !isTutorial_Check2)
        {
            isTutorial_Check2 = true;
            tutorial.SetActive(false);
            game.SetActive(true);
            
            if (DBManager.instance.currentStep == 1)
            {
                first_Character_Step1.SetActive(true);
            }
            else if (DBManager.instance.currentStep == 2)
            {
                first_Character_Step2.SetActive(true);
            }
            else if (DBManager.instance.currentStep == 3)
            {
                first_Character_Step3.SetActive(true);
            }
        }
    }
    
    void Tutorial_Notice()
    {
        if (tutorial_Notice_Num == 1)
        {
            tutorial_Notice.text = "지금부터 러블리어테션 연습을 시작합니다.";
        }
        else if (tutorial_Notice_Num == 2)
        {
            tutorial_Notice.text = "러블리어텐션은 자기 자신의 마음을 사랑스러운 눈으로 바라봐주는 것입니다.";
        }
        else if (tutorial_Notice_Num == 3)
        {
            tutorial_Notice.text = "자신의 마음을 사랑스럽게 지켜보듯이 자신의 마음의 윤곽을 따라 손가락으로 천천히 그려보세요.";
        }
        else if (tutorial_Notice_Num == 4)
        {
            tutorial_Notice.text = "불편한 마음이 줄어들면, 손가락으로 가슴에서 배로 쓰다듬어 주세요.(드래그)";
        }
        else if (tutorial_Notice_Num == 5)
        {
            tutorial_Notice.text = "“그래도 화가 나＂라고 말을 하면 그 말풍선에 손가락으로 토닥토닥 두드려주세요(터치터치)";
        }
    }

    public void Skip()
    {
        isTutorial = true;
        PlayerPrefs.SetInt("Lovely_Tutorial", 1);
    }
    
    void Heart2()
    {
        if (isTutorial && stage == 5)
        {
            if (!isHeart && (!success.activeSelf || !fail.activeSelf))
            {
                isHeart = true;
                StartCoroutine("HeartGenerator2");
            }
        }
    }
    
    IEnumerator HeartGenerator2()
    {
        if (!fail.activeSelf)
        {
            GameObject temp = Instantiate(heart2);
            temp.transform.SetParent(second.transform);
            temp.transform.GetComponent<RectTransform>().anchoredPosition = new Vector2(Random.Range(-300, 400), 800);
            temp.transform.localScale = new Vector3(0.7f, 0.7f, 0.7f);
            int num = Random.Range(0, heart_Text.Count);
            temp.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = heart_Text[num];
            heart_Text.RemoveAt(num);

            float delay = 0;

            while (delay < 1)
            {
                delay += Time.deltaTime;
                yield return waitForSeconds;
            }
    
            isHeart = false;
        }
    }

    void Heart()
    {
        if (isTutorial && stage == 4)
        {
            if (!isHeart && second.activeSelf && (!success.activeSelf || !fail.activeSelf))
            {
                isHeart = true;
                StartCoroutine("HeartGenerator");
            }
        }
    }

    IEnumerator HeartGenerator()
    {
        if (!fail.activeSelf)
        {
            GameObject temp = Instantiate(heart);
            temp.transform.SetParent(second.transform);
            temp.transform.GetComponent<RectTransform>().anchoredPosition =
                new Vector2(Random.Range(-300, 400), 800);
            temp.transform.localScale = new Vector3(0.3f, 0.3f, 0.3f);

            float delay = 0;

            while (delay < 0.5f)
            {
                delay += Time.deltaTime;
                yield return waitForSeconds;
            }
    
            isHeart = false;
        }
    }

    void Touch()
    {
        if (isTutorial)
        {
            if (stage == 3)
            {
                if (Input.GetMouseButtonUp(0))
                {
                    if (touch >= 2)
                    {
                        stage = 4;
                        balloon.SetActive(false);
                        Invoke("Loading_SetActive", 1.5f);
                        Invoke("Loading", 5.0f);
                    }
                }
            }
        }
    }

    public void TouchCount()
    {
        if (stage == 3)
        {
            touch++; 
        }
    }

    void Loading_SetActive()
    {
        loading.SetActive(true);
    }

    void Loading()
    {
        first.SetActive(false);
        second.SetActive(true);
        
        if (DBManager.instance.currentStep == 1)
        {
            second_Character_Step1.SetActive(true);
        }
        else if (DBManager.instance.currentStep == 2)
        {
            second_Character_Step2.SetActive(true);
        }
        else if (DBManager.instance.currentStep == 3)
        {
            second_Character_Step3.SetActive(true);
        }
        
        loading.SetActive(false);

        if (DBManager.instance.currentStep == 1 || DBManager.instance.currentStep == 2)
        {
            lifes[2].SetActive(false);
        }
        else
        {
            lifes[2].SetActive(true);
        }
    }

    void Check()
    {
        if (isUp && isDown && isUp2 && isDown2)
        {
            Balloon();
        }
        
        isUp = false;
        isDown = false;
        isUp2 = false;
        isDown2 = false;
    }

    void Balloon()
    {
        dragArea.SetActive(false);
        
        if (emotionFeel == "Anger")
        {
            notice.text = "\"그래도 화가 나\" 문구를 터치해주세요.";
            balloon.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "그래도 화가 나";
        }
        else if (emotionFeel == "Unrest")
        {
            notice.text = "\"아직도 무서워\" 문구를 터치해주세요.";
            balloon.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "아직도 무서워";
        }
        else if (emotionFeel == "Sadness")
        {
            notice.text = "\"그래도 우울해\" 문구를 터치해주세요.";
            balloon.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "그래도 우울해";
        }
        else if (emotionFeel == "Remorse")
        {
            notice.text = "\"여전히 내 탓인 것 같아\" 문구를 터치해주세요.";
            balloon.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "여전히 내 탓인 것 같아";
        }
        
        if (DBManager.instance.vibrateValue == 1)
        {
            Handheld.Vibrate();
        }
        
        balloon.SetActive(true);
    }

    public void BalloonClick()
    {
        notice.text = "아직 감정과 분리되지 못했어요.\n남아있는 감정을 토닥토닥 해주세요.";
        stage = 3;
        balloon.SetActive(false);
        dragArea.SetActive(true);
    }

    void Cursor()
    {
        if (isTutorial && stage == 2)
        {
            if (Input.GetMouseButtonDown(0))
            {
                EventSystem eventSystem = EventSystem.current;
                Vector2 mousePosition = Input.mousePosition;
                PointerEventData pointerEventData = new PointerEventData(eventSystem);
                pointerEventData.position = mousePosition;
                EventSystem.current.RaycastAll(pointerEventData, results);
                startPos = Input.mousePosition;
            }
            
            if (Input.GetMouseButton(0))
            {
                if (!isUp || !isDown)
                {
                    if (Input.mousePosition.y <= startPos.y)
                    {
                        isDown = true;
                        currentPos = Input.mousePosition;
                    }

                    if (Input.mousePosition.y > currentPos.y && isDown)
                    {
                        isUp = true;
                        startPos = Input.mousePosition;
                    }
                }
                else
                {
                    if (Input.mousePosition.y <= startPos.y)
                    {
                        isDown2 = true;
                        currentPos = Input.mousePosition;
                    }

                    if (Input.mousePosition.y > currentPos.y && isDown2)
                    {
                        isUp2 = true;
                    }
                }
            }

            if (Input.GetMouseButtonUp(0))
            {
                Check();
            }
        }
    }

    void EmotionTimer()
    {
        if (timer.activeSelf && !success.activeSelf && (stage == 1 || stage == 2 || stage == 3))
        {
            emotionTime = Time.time - emotionStartTime;
            timer.transform.GetChild(0).GetComponent<Image>().fillAmount = emotionTime * (1f / 45f);

            if (emotionTime >= 35 && !isTimer)
            {
                isTimer = true;
                timer.GetComponent<Animator>().Play("Emotion_Timer");
            }
            
            if (timer.transform.GetChild(0).GetComponent<Image>().fillAmount == 1)
            {
                shadow.SetActive(true);
                fail.SetActive(true);
            }
        }
    }

    void EmotionColor()
    {
        if (isTutorial)
        { 
            if (emotionColor.activeSelf && !isFill)
            {
                emotionColor.GetComponent<RectTransform>().localScale += new Vector3(0, 0.5f * Time.deltaTime, 0);

                if (emotionColor.GetComponent<RectTransform>().localScale.y >= 2.7f)
                {
                    isFill = true;
                    dot.SetActive(true);
                    dot.transform.GetComponent<Animator>().Play("Dot");
                    isDot = true;
                }
            }
        }
    }

    void EmotionDot()
    {
        if (isTutorial)
        {
            if (isDot && stage == 1 && Input.GetMouseButton(0))
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
                        emotionColor.GetComponent<RectTransform>().localScale += new Vector3(0, -0.1f * Time.deltaTime, 0);
                    }
                }
            
                if (emotionColor.GetComponent<RectTransform>().localScale.y <= 2)
                {
                    stage = 2;
                    isDot = false;
                    dot.SetActive(false);
                    notice.text = "남아있는 감정을 쓰담쓰담하며 어루만져 주세요.";
                    dragArea.SetActive(true);
                
                    switch (DBManager.instance.currentStep)
                    {
                        case 1:
                            dragArea.GetComponent<RectTransform>().anchoredPosition =
                                new Vector2(dragArea.GetComponent<RectTransform>().anchoredPosition.x, 100);
                            break;
                        case 2:
                            dragArea.GetComponent<RectTransform>().anchoredPosition =
                                new Vector2(dragArea.GetComponent<RectTransform>().anchoredPosition.x, 150);
                            break;
                        case 3:
                            dragArea.GetComponent<RectTransform>().anchoredPosition =
                                new Vector2(dragArea.GetComponent<RectTransform>().anchoredPosition.x, 200);
                            break;
                    }
                }
            }
        }
    }

    public void BtnCheck(string type)
    {
        if (isTutorial)
        {
            if (type == "Anger")
            {
                emotionFeel = "Anger";
                emotionColor.GetComponent<Image>().sprite = emotionColor_Sprite[0];
            }
            else if (type == "Unrest")
            {
                emotionFeel = "Unrest";
                emotionColor.GetComponent<Image>().sprite = emotionColor_Sprite[1];
            }
            else if (type == "Sadness")
            {
                emotionFeel = "Sadness";
                emotionColor.GetComponent<Image>().sprite = emotionColor_Sprite[2];
            }
            else if (type == "Remorse")
            {
                emotionFeel = "Remorse";
                emotionColor.GetComponent<Image>().sprite = emotionColor_Sprite[3];
            }
        }
        
        Invoke("BtnCheck2", 0.5f);
    }

    void BtnCheck2()
    {
        if (isTutorial)
        {
            notice.text = "움직이는 포인트를 따라 감정을 따라가주세요.";
            emotionStartTime = Time.time;
            timer.SetActive(true);
            emotionBtn.SetActive(false);
            character.SetActive(true);
            emotionColor.SetActive(true);
        }
    }

    public void BackGlow()
    {
        if (isTutorial)
        {
            backGlow.SetActive(true);
            backGlow.GetComponent<Animator>().Play("Lovely_BackGlow");
        }
        
        Invoke(nameof(BackGlow2), 3f);
    }
    
    void BackGlow2()
    {
        if (isTutorial)
        {
            backGlow.SetActive(false);
            
            if (bar.GetComponent<Slider>().value >= 1f)
            {
                isNext = true;
                DBManager.instance.refresh_PrevStage = "Lovely";
                DBManager.instance.currentStage = "Refresh";
                SceneManager.LoadScene("Loading");
            }
        }
    }
} 
