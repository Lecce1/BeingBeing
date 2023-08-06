using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Refresh_Manager : MonoBehaviour
{
    public GameObject breath;
    public GameObject body;
    public Image circle;
    public Image circle_Timer;
    public GameObject game_Notice;
    public GameObject shadow;
    public GameObject success;
    private int count = 0;
    private float time = 0;
    private bool isLimit = false;
    public bool isCheck = false;
    public bool isUp = false;
    public bool isDown = false;
    public bool isBreathe = false;
    private bool isFirst = false;
    public GameObject smile;
    public GameObject mouse;
    public GameObject backGlow;
    public GameObject lightEffect;
    public GameObject check;
    public bool isDoubleUp = false;
    public bool isSmile = false;
    public bool isNum = false;
    public string prevStage;
    WaitForSeconds waitForSeconds = new WaitForSeconds(0.01f);
    GameManager gameManager;
    AnimManager animManager;
    public Decent_Manager decent_Manager;

    void Awake()
    {
        animManager = GameObject.Find("AnimManager").GetComponent<AnimManager>();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        Invoke(nameof(First_Text), 5f);
    }

    void Update()
    {
        Cursor();
        Breathe();
        Gauge();
        Timer();
        Mouse();
    }
    
    private void First_Text()
    {
        game_Notice.GetComponent<Text>().text = "숨을 들이쉬고";
    }

    void Cursor()
    {
        if (isFirst == false)
        {
            if (gameObject.GetComponent<Touch>().result == Result.down && isLimit == false)
            {
                isDown = true;
                gameObject.GetComponent<Touch>().result = Result.none;
            }
            else if (isBreathe == true && gameObject.GetComponent<Touch>().result == Result.up && isLimit == false)
            {
                isUp = true;
                gameObject.GetComponent<Touch>().result = Result.none;
            }
            else if (isLimit == true)
            {
                gameObject.GetComponent<Touch>().result = Result.none;
            }
        }
        else if (isFirst == true)
        {
            if (gameObject.GetComponent<Touch>().result == Result.up && Input.touchCount == 2 && ((Input.touches[0].position.x < (gameManager.screen_Width / 2) && Input.touches[1].position.x > (gameManager.screen_Width / 2)) || (Input.touches[0].position.x > (gameManager.screen_Width / 2) && Input.touches[1].position.x < (gameManager.screen_Width / 2))))
            {
                time = 0;
                isDoubleUp = true;
                gameObject.GetComponent<Touch>().result = Result.none;
            }
        }
    }
    
    void Breathe()
    {
        if (isFirst == false)
        {
            if (isDown == true && isLimit == false && isBreathe == false)
            {
                isBreathe = true;
                StartCoroutine(Gauge2());
                StartCoroutine(Breathe2());
            }
            else if (isUp == true && isLimit == false && isBreathe == true)
            {
                isBreathe = false;
                StartCoroutine(Gauge2());
                StartCoroutine(Breathe2());
            }
        }
    }

    IEnumerator Breathe2()
    {
        if (isBreathe == true)
        {
            game_Notice.GetComponent<Text>().text = string.Empty;
            
            while (body.transform.localScale.x < 1.2f)
            {
                yield return waitForSeconds;
                body.transform.localScale += new Vector3(1f, 1f, 0) * Time.deltaTime;
            }
            
            game_Notice.GetComponent<Text>().text = "내쉬고";
        }
        else if (isBreathe == false)
        {
            game_Notice.GetComponent<Text>().text = string.Empty;
            
            while (body.transform.localScale.x > 1)
            {
                yield return waitForSeconds;
                body.transform.localScale -= new Vector3(1f, 1f, 0) * Time.deltaTime;
            }
        }

        yield return null;
    }

    void Gauge()
    {
        if (isFirst == false)
        {
            if (isUp == true && isDown == true && isLimit == false)
            {
                time = 0;
                isUp = false;
                isDown = false;
                isLimit = true;
            }
        }
    }

    IEnumerator Gauge2()
    {
        isCheck = false;
        
        if (count < 6)
        {
            count++;
        }
        
        while (circle.fillAmount < (count * 0.166f))
        {
            yield return waitForSeconds;
            circle.fillAmount += 0.5f * Time.deltaTime;
        }

        if (circle.fillAmount >= 0.996f)
        {
            isFirst = true;
            breath.SetActive(false);
            smile.SetActive(true);
        }
        
        isCheck = true;

        yield return null;
    }

    void Timer()
    {
        if (isFirst == false)
        {
            if (isLimit == true && isCheck == true)
            {
                time += Time.deltaTime;
                circle_Timer.fillAmount = time / 4;
            }

            if (time >= 4)
            {
                game_Notice.GetComponent<Text>().text = "숨을 들이쉬고";
                circle_Timer.fillAmount = 0;
                time = 0;
                isLimit = false;
            }
        }
        else if (isFirst == true)
        {
            time += Time.deltaTime;

            if (time >= 2)
            {
                time = 0;
            
                if (isSmile == false)
                {
                    isDoubleUp = false;
                }
            }
        }
    }
    
    void Mouse()
    {
        if (isDoubleUp == true && isNum == false)
        {
            mouse.GetComponent<Image>().sprite = Resources.Load<Sprite>("mouse4");
            isSmile = true;
            isNum = true;
            animManager.Refresh_BackGlow();
            lightEffect.SetActive(false);
            lightEffect.SetActive(true);
            transform.GetComponent<AudioSource>().Play();
            check.transform.GetChild(0).gameObject.SetActive(true);
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
        if (prevStage == "emotionRecog")
        {
            if (gameManager.stage_Select_Level_Num == 1)
            {
                if (PlayerPrefs.GetInt("level") <= 2)
                {
                    PlayerPrefs.SetInt("level", 3);
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
                if (PlayerPrefs.GetInt("level") <= 10)
                {
                    PlayerPrefs.SetInt("level", 11);
                }
            }
        }
        else if (prevStage == "lovely")
        {
            if (gameManager.stage_Select_Level_Num == 1)
            {
                if (PlayerPrefs.GetInt("level") <= 3)
                {
                    PlayerPrefs.SetInt("level", 4);
                }
            }
            else if (gameManager.stage_Select_Level_Num == 2)
            {
                if (PlayerPrefs.GetInt("level") <= 7)
                {
                    PlayerPrefs.SetInt("level", 8);
                }
            }
            else if (gameManager.stage_Select_Level_Num == 3)
            {
                if (PlayerPrefs.GetInt("level") <= 11)
                {
                    PlayerPrefs.SetInt("level", 12);
                }
            }
        }

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
        breath.SetActive(true);
        body.transform.localScale = new Vector3(1, 1, 1);
        circle.fillAmount = 0;
        circle_Timer.fillAmount = 0;
        count = 0;
        time = 0;
        game_Notice.GetComponent<Text>().text = "소리를 켜서 안내말을 따라해 주세요.";
        isDoubleUp = false;
        isLimit = false;
        isCheck = false;
        isUp = false; 
        isDown = false;
        isBreathe = false;
        smile.SetActive(false);
        backGlow.SetActive(false);
        lightEffect.SetActive(false);
        isDoubleUp = false;
        isSmile = false;
        isNum = false;
        isFirst = false;
        shadow.SetActive(false);
        success.SetActive(false);
        gameManager.buttons.SetActive(true);
        mouse.GetComponent<Image>().sprite = Resources.Load<Sprite>("mouse");
        check.transform.GetChild(0).gameObject.SetActive(false);
    }
}
