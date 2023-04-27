using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.Serialization;

public class Lovely_Manager : MonoBehaviour
{
    public GameObject tutorial;
    public GameObject game;
    public GameObject character;
    public GameObject timer;
    public GameObject emotionBtn;
    public GameObject emotionColor;
    public GameObject dot;
    public GameObject balloon;
    public GameObject shadow;
    public GameObject success;
    public GameObject fail;
    public GameObject loading;
    public GameObject bar;
    public GameObject heart;
    public int heartNum = 0;
    private string emotionFeel;
    private float emotionStartTime;
    private float emotionTime;
    private bool isFill = false;
    private bool isTimer = false;
    public int stage = 1;
    private bool isDot = false;
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
    private List<RaycastResult> results = new List<RaycastResult>();

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
    }

    void Heart()
    {
        if (isTutorial == false)
        {

        }
        else if (isTutorial == true && stage == 4)
        {
            if (heartNum >= 20)
            {
                Debug.Log("test");
            }
        }
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
                        game.transform.GetChild(0).gameObject.SetActive(false);
                        game.transform.GetChild(1).gameObject.SetActive(true);
                        Invoke("Loading", 5.0f);
                    }
                }
            }
        }
    }

    void Loading()
    {
        loading.SetActive(false);
    }

    void Check()
    {
        if (isUp == true && isDown == true && isUp2 == true && isDown2 == true)
        {
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
        if (timer.activeSelf == true && success.activeSelf == false)
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
            emotionStartTime = Time.time;
            timer.SetActive(true);
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
            
            if (PlayerPrefs.GetInt("level") <= 3)
            {
                PlayerPrefs.SetInt("level", 4);
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
        emotionBtn.SetActive(true);
        emotionColor.SetActive(false);
        emotionColor.GetComponent<RectTransform>().localScale = new Vector3(5, 0, 5);
        dot.SetActive(false);
        dot.GetComponent<RectTransform>().anchoredPosition = new Vector2(-450, -900);
        balloon.SetActive(false);
        loading.SetActive(false);
        bar.GetComponent<Image>().fillAmount = 0;
        heartNum = 0;
        isTimer = false;
        isFill = false;
        stage = 1;
        isDot = false;
        isNext = false;
        isUp = false;
        isDown = false;
        isUp2 = false;
        isDown2 = false;
        touch = 0;
        shadow.SetActive(false);
        success.SetActive(false);
        fail.SetActive(false);
    }
}
