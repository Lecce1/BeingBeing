using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Refresh_Manager : MonoBehaviour
{
    public GameObject breath;
    public GameObject breath_Character_Step1;
    public GameObject breath_Character_Step2;
    public GameObject breath_Character_Step3;
    public Image circle;
    public Image circle_Timer;
    public GameObject game_Notice;
    public GameObject shadow;
    public GameObject success;
    [SerializeField]
    private int count;
    [SerializeField]
    private float time;
    [SerializeField]
    private bool isLimit;
    public bool isCheck;
    public bool isUp;
    public bool isDown;
    public bool isBreathe;
    [SerializeField]
    private bool isFirst;
    [SerializeField]
    private bool isFirstFinish;
    public GameObject smile;
    public GameObject smile_Character_Step1;
    public GameObject smile_Character_Step2;
    public GameObject smile_Character_Step3;
    public GameObject backGlow;
    public GameObject lightEffect;
    public GameObject check;
    public bool isDoubleUp;
    public bool isSmile;
    public bool isNum;
    public string prevStage;
    WaitForSeconds waitForSeconds = new (0.01f);

    void Start()
    {
        prevStage = DBManager.instance.refresh_PrevStage;
        
        if (DBManager.instance.currentStep == 1)
        {
            breath_Character_Step1.SetActive(true);
        }
        else if (DBManager.instance.currentStep == 2)
        {
            breath_Character_Step2.SetActive(true);
        }
        else if (DBManager.instance.currentStep == 3)
        {
            breath_Character_Step3.SetActive(true);
        }

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
    
    void First_Text()
    {
        if (game_Notice.GetComponent<Text>().text == "소리를 켜서 안내말을 따라해 주세요.")
        {
            game_Notice.GetComponent<Text>().text = "숨을 들이쉬고";
        }
    }

    void Cursor()
    {
        if (!isFirst)
        {
            if (!isBreathe && gameObject.GetComponent<Touch>().result == Result.down && !isLimit)
            {
                isDown = true;
                gameObject.GetComponent<Touch>().result = Result.none;
            }
            else if (isBreathe && gameObject.GetComponent<Touch>().result == Result.up && !isLimit)
            {
                isUp = true;
                gameObject.GetComponent<Touch>().result = Result.none;
            }
            else if (isLimit)
            {
                gameObject.GetComponent<Touch>().result = Result.none;
            }
        }
        else if (isFirst)
        {
            if (gameObject.GetComponent<Touch>().result == Result.up)
            {
                time = 0;
                isDoubleUp = true;
                gameObject.GetComponent<Touch>().result = Result.none;
            }
        }
    }
    
    void Breathe()
    {
        if (!isFirst)
        {
            if (isDown && !isLimit && !isBreathe)
            {
                isBreathe = true;
                StartCoroutine(Gauge2());
                StartCoroutine(Breathe2());
            }
            else if (isUp && !isLimit && isBreathe)
            {
                isBreathe = false;
                StartCoroutine(Gauge2());
                StartCoroutine(Breathe2());
            }
        }
    }

    IEnumerator Breathe2()
    {
        if (isBreathe)
        {
            game_Notice.GetComponent<Text>().text = string.Empty;
            
            if (DBManager.instance.currentStep == 1)
            {
                breath_Character_Step1.GetComponent<Animator>().Play("Breath_Step1_1");
            }
            else if (DBManager.instance.currentStep == 2)
            {
                breath_Character_Step2.GetComponent<Animator>().Play("Breath_Step2_1");
            }
            else if (DBManager.instance.currentStep == 3)
            {
                breath_Character_Step3.GetComponent<Animator>().Play("Breath_Step3_1");
            }
            
            while (circle_Timer.fillAmount < 0.95f)
            {
                yield return null;
            }

            if (circle.fillAmount != 1)
            {
                game_Notice.GetComponent<Text>().text = "내쉬고";
            }
        }
        else if (!isBreathe)
        {
            game_Notice.GetComponent<Text>().text = string.Empty;
            
            if (DBManager.instance.currentStep == 1)
            {
                breath_Character_Step1.GetComponent<Animator>().Play("Breath_Step1_2");
            }
            else if (DBManager.instance.currentStep == 2)
            {
                breath_Character_Step2.GetComponent<Animator>().Play("Breath_Step2_2");
            }
            else if (DBManager.instance.currentStep == 3)
            {
                breath_Character_Step3.GetComponent<Animator>().Play("Breath_Step3_2");
            }
            
            while (circle_Timer.fillAmount < 0.95f)
            {
                yield return null;
            }

            if (circle.fillAmount != 1)
            {
                game_Notice.GetComponent<Text>().text = "들이쉬고";
            }
        }

        yield return null;
    }

    void Gauge()
    {
        if (!isFirst)
        {
            if ((isUp || isDown) && !isLimit)
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

        if (count >= 6)
        {
            circle.fillAmount = 1;
            isFirstFinish = true;
        }

        isCheck = true;

        yield return null;
    }

    void Timer()
    {
        if (!isFirst)
        {
            if (isLimit && isCheck)
            {
                time += Time.deltaTime;
                circle_Timer.fillAmount = time / 2;
            }

            if (time >= 2)
            {
                circle_Timer.fillAmount = 0;
                time = 0;
                isLimit = false;
                
                if (isFirstFinish)
                {
                    isFirst = true;
                    breath.SetActive(false);
                    smile.SetActive(true);
            
                    if (DBManager.instance.currentStep == 1)
                    {
                        smile_Character_Step1.SetActive(true);
                    }
                    else if (DBManager.instance.currentStep == 2)
                    {
                        smile_Character_Step2.SetActive(true);
                    }
                    else if (DBManager.instance.currentStep == 3)
                    {
                        smile_Character_Step3.SetActive(true);
                    }
                }
            }
        }
        else if (isFirst)
        {
            time += Time.deltaTime;

            if (time >= 2)
            {
                time = 0;
            
                if (!isSmile)
                {
                    isDoubleUp = false;
                }
            }
        }
    }
    
    void Mouse()
    {
        if (isDoubleUp && !isNum)
        {
            isSmile = true;
            isNum = true;
            BackGlow();
            lightEffect.SetActive(false);
            lightEffect.SetActive(true);
            transform.GetComponent<AudioSource>().Play();
            check.transform.GetChild(0).gameObject.SetActive(true);
            
            if (smile_Character_Step1.activeSelf)
            {
                smile_Character_Step1.GetComponent<Animator>().Play("Smile_Step1");
            }
            else if (smile_Character_Step2.activeSelf)
            {
                smile_Character_Step2.GetComponent<Animator>().Play("Smile_Step2");
            }
            else if (smile_Character_Step3.activeSelf)
            {
                smile_Character_Step3.GetComponent<Animator>().Play("Smile_Step3");
            }
        }
    }

    void BackGlow()
    {
        if(DBManager.instance.vibrateValue == 1)
        {
            Handheld.Vibrate();
        }
        
        backGlow.SetActive(true);
        backGlow.GetComponent<Animator>().Play("Refresh_BackGlow");
        Invoke(nameof(BackGlow2), 4.0f);
    }
    
    void BackGlow2()
    {
        if (prevStage == "Decent")
        {
            backGlow.SetActive(false);
            DBManager.instance.decent_IsRefresh = true;
            DBManager.instance.currentStage = "Decent";
            SceneManager.LoadScene("Loading");
        }
        else
        {
            backGlow.SetActive(false);
            shadow.SetActive(true);
            success.SetActive(true);
        }
    }

    public void Next()
    {
        if (prevStage == "EmotionRecog")
        {
            if (DBManager.instance.currentStep == 1)
            {
                if (PlayerPrefs.GetInt("level") <= 2)
                {
                    PlayerPrefs.SetInt("level", 3);
                    PlayerPrefs.SetInt("Recog_Step1_Clear", 1);
                }
            }
            else if (DBManager.instance.currentStep == 2)
            {
                if (PlayerPrefs.GetInt("level") <= 6)
                {
                    PlayerPrefs.SetInt("level", 7);
                    PlayerPrefs.SetInt("Recog_Step2_Clear", 1);
                }
            }
            else if (DBManager.instance.currentStep == 3)
            {
                if (PlayerPrefs.GetInt("level") <= 10)
                {
                    PlayerPrefs.SetInt("level", 11);
                    PlayerPrefs.SetInt("Recog_Step3_Clear", 1);
                }
            }
        }
        else if (prevStage == "Lovely")
        {
            if (DBManager.instance.currentStep == 1)
            {
                if (PlayerPrefs.GetInt("level") <= 3)
                {
                    PlayerPrefs.SetInt("level", 4);
                }
            }
            else if (DBManager.instance.currentStep == 2)
            {
                if (PlayerPrefs.GetInt("level") <= 7)
                {
                    PlayerPrefs.SetInt("level", 8);
                }
            }
            else if (DBManager.instance.currentStep == 3)
            {
                if (PlayerPrefs.GetInt("level") <= 11)
                {
                    PlayerPrefs.SetInt("level", 12);
                }
            }
        }

        var animator = success.GetComponent<Animator>();
        animator.Play("Close");
        Invoke("Success_Close", 0.5f);
    }

    void Success_Close()
    {
        DBManager.instance.currentStage = "Main";
        success.SetActive(false);
        SceneManager.LoadScene("Loading");
    }
}
