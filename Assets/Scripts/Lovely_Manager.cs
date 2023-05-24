using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Lovely_Manager : MonoBehaviour
{
    public GameObject tutorial;
    public TMP_Text tutorial_Notice;
    public GameObject game;
    public GameObject character;
    public GameObject timer;
    public TMP_Text notice;
    public GameObject emotionBtn;
    public GameObject emotionColor;
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
    public int heartNum = 0;
    private string emotionFeel;
    private float emotionStartTime;
    private float emotionTime;
    private bool isFill = false;
    private bool isTimer = false;
    public int stage = 1;
    private bool isDot = false;
    private bool isHeart = false;
    public bool isNext = false;
    private bool isUp = false;
    private bool isDown = false;
    private bool isUp2 = false;
    private bool isDown2 = false;
    GameManager gameManager;
    AnimManager animManager;
    public bool isTutorial = true;
    private bool isTutorial_Check;
    private bool isTutorial_Check2;
    private Vector2 startPos;
    private Vector2 currentPos;
    public int touch = 0;
    private List<string> heart_Text = new List<string> {"고마워", "힘이나", "편안해", "기분이 좋아", "사랑해", "잘했어", "최고야", "힘빠져", "기분 나빠", "불편해", "뭘 잘해?", "잘못 했네", "최악이야"};
    public int heart_Fail = 0;
    private List<RaycastResult> results = new List<RaycastResult>();
    WaitForEndOfFrame waitForEndOfFrame = new WaitForEndOfFrame();
    private int tutorial_Notice_Num = 1;

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
        Cursor();
        Touch();
        Heart();
        Heart2();
    }
    
    void Tutorial()
    {
        if (isTutorial == false && isTutorial_Check == false)
        {
            if (isTutorial_Check == false)
            {
                isTutorial_Check = true;
                gameManager.Set2();
                
                if (gameManager.stage_Select_Level_Num == 1 && PlayerPrefs.GetInt("Lovely_Tutorial") == 0)
                {
                    gameManager.buttons.SetActive(false);
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
        else if (isTutorial == true && isTutorial_Check2 == false)
        {
            isTutorial_Check2 = true;
            tutorial.SetActive(false);
            game.SetActive(true);
            gameManager.buttons.SetActive(true);
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
        if (isTutorial == false)
        {

        }
        else if (isTutorial == true && stage == 5)
        {
            if (isHeart == false)
            {
                isHeart = true;
                StartCoroutine("HeartGenerator2");
            }
        }
    }
    
    IEnumerator HeartGenerator2()
    {
        GameObject temp = Instantiate(heart2);
        temp.transform.SetParent(game.transform.GetChild(1));
        temp.transform.GetComponent<RectTransform>().anchoredPosition = new Vector2(Random.Range(-300, 400), 800);
        temp.transform.localScale = new Vector3(1f, 1f, 1f);
        int num = Random.Range(0, heart_Text.Count);
        temp.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = heart_Text[num];
        heart_Text.RemoveAt(num);

        float delay = 0;

        while (delay < 3f)
        {
            delay += Time.deltaTime;
            yield return waitForEndOfFrame;
        }
    
        isHeart = false;
    }

    void Heart()
    {
        if (isTutorial == false)
        {

        }
        else if (isTutorial == true && stage == 4)
        {
            if (isHeart == false && game.transform.GetChild(1).gameObject.activeSelf == true)
            {
                isHeart = true;
                StartCoroutine("HeartGenerator");
            }
        }
    }

    IEnumerator HeartGenerator()
    {
        GameObject temp = Instantiate(heart);
        temp.transform.SetParent(game.transform.GetChild(1));
        temp.transform.GetComponent<RectTransform>().anchoredPosition =
            new Vector2(Random.Range(-300, 400), 800);
        temp.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);

        float delay = 0;

        while (delay < 1f)
        {
            delay += Time.deltaTime;
            yield return waitForEndOfFrame;
        }
    
        isHeart = false;
    }

    void Touch()
    {
        if (isTutorial == false)
        {

        }
        else if (isTutorial == true)
        {
            if (balloon.activeSelf == true && stage == 3)
            {
                if (Input.GetMouseButtonUp(0))
                {
                    touch++;

                    if (touch >= 3)
                    {
                        stage = 4;
                        balloon.SetActive(false);
                        loading.SetActive(true);
                        Invoke("Loading", 5.0f);
                    }
                }
            }
        }
    }

    void Loading()
    {
        game.transform.GetChild(0).gameObject.SetActive(false);
        game.transform.GetChild(1).gameObject.SetActive(true);
        loading.SetActive(false);
    }

    void Check()
    {
        if (isUp == true && isDown == true && isUp2 == true && isDown2 == true)
        {
            notice.GetComponent<TextMeshProUGUI>().text = "아직 감정과 분리되지 못했어요\n남아있는 감정을 토닥토닥 해주세요";
            stage = 3;
            Balloon();
        }
        
        isUp = false;
        isDown = false;
        isUp2 = false;
        isDown2 = false;
    }

    void Balloon()
    {
        if (emotionFeel == "Anger")
        {
            balloon.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "그래도 화가 나";
        }
        else if (emotionFeel == "Unrest")
        {
            balloon.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "아직도 무서워";
        }
        else if (emotionFeel == "Sadness")
        {
            balloon.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "그래도 우울해";
        }
        else if (emotionFeel == "Remorse")
        {
            balloon.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = "여전히 내 탓인 것 같아";
        }
        
        Handheld.Vibrate();
        balloon.SetActive(true);
    }

    void Cursor()
    {
        if (isTutorial == false)
        {

        }
        else if (isTutorial == true && stage == 2)
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
                for (int i = 0; i < results.Count; i++)
                {
                    if (results[i].gameObject.name == "Body")
                    {
                        if (isUp == false || isDown == false)
                        {
                            if (Input.mousePosition.y <= startPos.y - 50)
                            {
                                isDown = true;
                                currentPos = Input.mousePosition;
                            }

                            if (Input.mousePosition.y > currentPos.y + 50 && isDown == true)
                            {
                                isUp = true;
                                startPos = Input.mousePosition;
                            }
                        }
                        else
                        {
                            if (Input.mousePosition.y <= startPos.y - 50)
                            {
                                isDown2 = true;
                                currentPos = Input.mousePosition;
                            }

                            if (Input.mousePosition.y > currentPos.y + 50 && isDown2 == true)
                            {
                                isUp2 = true;
                            }
                        }

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
        if (timer.activeSelf == true && success.activeSelf == false && (stage == 1 || stage == 2 || stage == 3))
        {
            emotionTime = 45 - (Time.time - emotionStartTime);
            timer.transform.GetChild(0).GetComponent<Image>().fillAmount = emotionTime * (1f / 45f);

            if (emotionTime <= 10 && isTimer == false)
            {
                isTimer = true;
                timer.GetComponent<Animator>().Play("Emotion_Timer");
            }
            
            if (timer.transform.GetChild(0).GetComponent<Image>().fillAmount == 0)
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
           
        }
        else if (isTutorial == true)
        { 
            if (emotionColor.activeSelf == true && isFill == false)
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
        if (isTutorial == false)
        {
            
        }
        else if (isTutorial == true)
        {
            if (isDot == true && stage == 1 && Input.GetMouseButton(0))
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
                    notice.GetComponent<TextMeshProUGUI>().text = "남아있는 감정을 쓰담쓰담하며 어루 만져 주세요";
                }
            }
        }
    }

    public void BtnCheck(string type)
    {
        if (isTutorial == false)
        {

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
            else if (type == "Sadness")
            {
                emotionFeel = "Sadness";
                emotionColor.GetComponent<Image>().color = Color.blue;
            }
            else if (type == "Remorse")
            {
                emotionFeel = "Remorse";
                emotionColor.GetComponent<Image>().color = Color.gray;
            }
        }
        
        Invoke("BtnCheck2", 0.5f);
    }

    void BtnCheck2()
    {
        if (isTutorial == false)
        {
            
        }
        else if (isTutorial == true)
        {
            notice.GetComponent<TextMeshProUGUI>().text = "움직이는 포인트를 따라 감정을 따라가주세요";
            emotionStartTime = Time.time;
            timer.SetActive(true);
            emotionBtn.SetActive(false);
            character.SetActive(true);
            emotionColor.SetActive(true);
        }
    }
    
    public void ReStart()
    {
        if (gameManager.pause.activeSelf == true)
        {
            var animator = gameManager.pause.GetComponent<Animator>();
            animator.Play("Close");
            Invoke("Pause_Close", 0.5f);
        }
        else
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
    }
    
    public void Next()
    {
        if (success.activeSelf == true)
        {
            var animator = success.GetComponent<Animator>();
            animator.Play("Close");
            
            if (gameManager.stage_Select_Level_Num == 1)
            {
                if (PlayerPrefs.GetInt("level") <= 3)
                {
                    PlayerPrefs.SetInt("level", 4);
                }
            }
            else if (gameManager.stage_Select_Level_Num == 2)
            {
                if (PlayerPrefs.GetInt("level") <= 6)
                {
                    PlayerPrefs.SetInt("level", 7);
                }
            }
            else if (gameManager.stage_Select_Level_Num == 3)
            {
                if (PlayerPrefs.GetInt("level") <= 9)
                {
                    PlayerPrefs.SetInt("level", 9);
                }
            }
        }
        else if (fail.activeSelf == true)
        {
            var animator = fail.GetComponent<Animator>();
            animator.Play("Close");
        }
        
        animManager.Fade_Out();
        Invoke("Success_Fail_Close", 0.5f);
    }
    
    public void Help()
    {
        PlayerPrefs.SetInt("Lovely_Tutorial", 0);
        var animator = gameManager.pause.GetComponent<Animator>();
        animator.Play("Close");
        Reset();
        Invoke("Pause_Close", 0.5f);
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
    
    void Pause_Close()
    {
        gameManager.buttons.transform.GetChild(0).gameObject.SetActive(false);
        gameManager.buttons.transform.GetChild(1).gameObject.SetActive(true);
        gameManager.buttons.transform.GetChild(2).gameObject.SetActive(false);
        gameManager.pause.SetActive(false);
    }

    public void Reset()
    {
        tutorial.SetActive(true);
        tutorial_Notice_Num = 1;
        isTutorial = true;
        isTutorial_Check = false;
        isTutorial_Check2 = false;
        game.SetActive(false);
        game.transform.GetChild(0).gameObject.SetActive(true);
        game.transform.GetChild(1).gameObject.SetActive(false);
        character.SetActive(false);
        timer.SetActive(false);
        timer.transform.GetChild(0).GetComponent<Image>().fillAmount = 1;
        timer.transform.GetChild(0).GetComponent<Image>().color = Color.black;
        notice.GetComponent<TextMeshProUGUI>().text = "";
        emotionBtn.SetActive(true);
        emotionColor.SetActive(false);
        emotionColor.GetComponent<RectTransform>().localScale = new Vector3(5, 0, 5);
        dot.SetActive(false);
        dot.GetComponent<RectTransform>().anchoredPosition = new Vector2(-450, -900);
        balloon.SetActive(false);
        loading.SetActive(false);
        bar.transform.GetChild(0).GetComponent<Image>().fillAmount = 0;
        heartNum = 0;
        isTimer = false;
        isFill = false;
        stage = 1;
        isDot = false;
        isHeart = false;
        isNext = false;
        isUp = false;
        isDown = false;
        isUp2 = false;
        isDown2 = false;
        touch = 0;
        heart_Text = new List<string> {"고마워", "힘이나", "편안해", "기분이 좋아", "사랑해", "잘했어", "최고야", "힘빠져", "기분 나빠", "불편해", "뭘 잘해?", "잘못 했네", "최악이야"};
        heart_Fail = 0;
        shadow.SetActive(false);
        success.SetActive(false);
        fail.SetActive(false);
    }
}
