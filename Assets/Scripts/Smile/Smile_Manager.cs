using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Smile_Manager : MonoBehaviour
{
    public GameObject tutorial;
    public Text tutorial_Notice;
    public GameObject tutorial_Finger;
    public GameObject tutorial_Character;
    public GameObject tutorial_BackGlow;
    public GameObject tutorial_LightEffect;
    public GameObject game;
    public GameObject character_Step1;
    public GameObject character_Step2;
    public GameObject character_Step3;
	public GameObject check;
    public GameObject backGlow;
    public GameObject lightEffect;
    public GameObject shadow;
    public GameObject success;
    public float time;
    public bool isDoubleUp;
    public bool isSmile;
    public bool isNum;
    public bool isTutorial;
    private bool isTutorial_Check;
    private bool isTutorial_Check2;
    private bool isTutorial_Cursor;
    private int tutorial_Notice_Num = 1;
    public GameObject fade;
    WaitForSeconds waitForSeconds = new (0.01f);
    public GameObject tutorial_Notice_Image;

    void Start()
    {
        StartCoroutine(nameof(FadeIn));
    }
    
    IEnumerator FadeIn()
    {
        fade.SetActive(true);
        float timer = 0;

        while (timer < 255)
        {
            timer += 500 * Time.deltaTime;
            fade.GetComponent<Image>().color = new Color(0, 0, 0, 1 - (timer / 255f));
            yield return waitForSeconds;
        }
        
        fade.SetActive(false);
    }

    void Update()
    {
        Tutorial();
        Cursor();
        Mouse();
        Timer();
    }
    
    void Tutorial()
    {
        if (!isTutorial)
        {
            if (!isTutorial_Check)
            {
                isTutorial_Check = true;

                if (PlayerPrefs.GetInt("Smile_Tutorial") == 0)
                {
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

                    if (tutorial_Notice_Num != 4)
                    {
                        Tutorial_Notice();
                    }
                }
            }
        }
        else if (isTutorial && !isTutorial_Check2)
        {
            isTutorial_Check2 = true;
            gameObject.GetComponent<Touch>().result = Result.none;
            check.transform.GetChild(0).gameObject.SetActive(false);
            isDoubleUp = false;
            isSmile = false;
            isNum = false;
            tutorial.SetActive(false);
            game.SetActive(true);
            
            if (DBManager.instance.currentStep == 1)
            {
                character_Step1.SetActive(true);
            }
            else if (DBManager.instance.currentStep == 2)
            {
                character_Step2.SetActive(true);
            }
            else if (DBManager.instance.currentStep == 3)
            {
                character_Step3.SetActive(true);
            }
        }
    }
    
    void Tutorial_Notice()
    {
        if (tutorial_Notice_Num == 1)
        {
            tutorial_Notice.text = "호흡 후에 빙그레 웃음으로 마무리 합니다.";
            BGMManager.instance.PlayBGM("Smile_Tutorial_1");
            tutorial_Notice_Image.GetComponent<Animator>().Play("Text");
        }
        else if (tutorial_Notice_Num == 2)
        {
            tutorial_Notice.text = "그림과 같이 손가락을\n빙빙이의 입꼬리에 올려주세요.";
            BGMManager.instance.PlayBGM("Smile_Tutorial_2");
            tutorial_Character.SetActive(true);
            tutorial_Finger.SetActive(true);
            tutorial_Finger.GetComponent<Animator>().Play("Finger3");
        }
        else if (tutorial_Notice_Num == 3)
        {
            tutorial_Notice_Image.SetActive(false);
            gameObject.GetComponent<Touch>().result = Result.none;
            tutorial_Notice.text = "빙빙이의 입꼬리를 위로 올려\n빙그레 미소짓게 만들어주세요.";
            BGMManager.instance.PlayBGM("Smile_Tutorial_3");
        }
    }

    public void Skip()
    {
        isTutorial = true;
        PlayerPrefs.SetInt("Smile_Tutorial", 1);
    }

    void Cursor()
    {
        if (!isTutorial)
        {
            if (!isTutorial_Cursor && tutorial_Notice_Num >= 4 && gameObject.GetComponent<Touch>().result == Result.up)
            {
                gameObject.GetComponent<Touch>().result = Result.none;
                isTutorial_Cursor = true;
                isDoubleUp = true;
                tutorial_Notice.text = "잘 하셨습니다.\n빙그레 연습을 마칩니다.";
                BGMManager.instance.PlayBGM("Smile_Tutorial_4");
                tutorial_Finger.SetActive(false);
            }
        }
        else if (isTutorial)
        {
            if (gameObject.GetComponent<Touch>().result == Result.up)
            {
                time = 0;
                isDoubleUp = true;
                gameObject.GetComponent<Touch>().result = Result.none;
            }
        }
    }

    void Mouse()
    {
        if (!isTutorial)
        {
            if (isDoubleUp && !isNum)
            {
                isSmile = true;
                isNum = true;
                BackGlow();
                tutorial_LightEffect.SetActive(false);
                tutorial_LightEffect.SetActive(true);
                transform.GetComponent<AudioSource>().Play();
                tutorial_Character.GetComponent<Animator>().Play("Smile_Step1");
            }
        }
        else if (isTutorial)
        {
            if (!isDoubleUp)
            {
                isSmile = false;
            }
            else if (isDoubleUp && !isNum)
            {
                check.transform.GetChild(0).gameObject.SetActive(true);
                isSmile = true;
                isNum = true;
                BackGlow();
                lightEffect.SetActive(false);
                lightEffect.SetActive(true);
                transform.GetComponent<AudioSource>().Play();

                if (character_Step1.activeSelf)
                {
                    character_Step1.GetComponent<Animator>().Play("Smile_Step1");
                }
                else if (character_Step2.activeSelf)
                {
                    character_Step2.GetComponent<Animator>().Play("Smile_Step2");
                }
                else if (character_Step3.activeSelf)
                {
                    character_Step3.GetComponent<Animator>().Play("Smile_Step3");
                }
            }
        }
    }

    void Timer()
    {
        if (isTutorial)
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
    
    public void Next()
    {
        if (DBManager.instance.currentStep == 1)
        {
            if (PlayerPrefs.GetInt("level") <= 1)
            {
                PlayerPrefs.SetInt("level", 2);
            }
        }
        else if (DBManager.instance.currentStep == 2)
        {
            if (PlayerPrefs.GetInt("level") <= 5)
            {
                PlayerPrefs.SetInt("level", 6);
            }
        }
        else if (DBManager.instance.currentStep == 3)
        {
            if (PlayerPrefs.GetInt("level") <= 9)
            {
                PlayerPrefs.SetInt("level", 10);
            }
        }
        
        var animator = success.GetComponent<Animator>();
        animator.Play("Close");
        Invoke("Success_Close", 0.5f);
    }

    void Success_Close()
    {
        success.SetActive(false);
        DBManager.instance.currentStage = "Main";
        SceneManager.LoadScene("Loading");
    }

    public void Restart()
    {
        DBManager.instance.currentStage = "Smile";
        SceneManager.LoadScene("Loading");
    }
    
    void BackGlow()
    {
        if (DBManager.instance.vibrateValue == 1)
        {
            Handheld.Vibrate();
        }

        if (!isTutorial)
        {
            tutorial_BackGlow.SetActive(true);
            tutorial_BackGlow.GetComponent<Animator>().Play("BackGlow");
        }
        else if (isTutorial)
        {
            backGlow.SetActive(true);
            backGlow.GetComponent<Animator>().Play("BackGlow");
        }
        
        Invoke(nameof(BackGlow2), 4.0f);
    }
    
    void BackGlow2()
    {
        if (!isTutorial)
        {
            tutorial_BackGlow.SetActive(false);
            PlayerPrefs.SetInt("Smile_Tutorial", 1);
            isTutorial = true;
        }
        else if (isTutorial)
        {
            backGlow.SetActive(false);
            shadow.SetActive(true);
            success.SetActive(true);
        }
    }
}
