using System.Collections;
using UnityEngine;
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
    public float time = 0;
    public bool isDoubleUp;
    public bool isSmile = false;
    public bool isNum = false;
    GameManager gameManager;
    AnimManager animManager;
    public bool isTutorial;
    private bool isTutorial_Check;
    private bool isTutorial_Check2;
    private bool isTutorial_Cursor;
    private int tutorial_Notice_Num = 1;
    public GameObject fade;
    WaitForSeconds waitForSeconds = new WaitForSeconds(0.01f);
    public GameObject tutorial_Notice_Image;

    void Awake()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        animManager = GameObject.Find("AnimManager").GetComponent<AnimManager>();
    }

    private void OnEnable()
    {
        StartCoroutine(nameof(FadeIn));
    }
    
    private IEnumerator FadeIn()
    {
        fade.SetActive(true);
        float timer = 0;

        while (timer < 255)
        {
            timer += 250 * Time.deltaTime;
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
        if (isTutorial == false)
        {
            if (isTutorial_Check == false)
            {
                isTutorial_Check = true;
                gameManager.Set2();

                if (PlayerPrefs.GetInt("Smile_Tutorial") == 0)
                {
                    gameManager.buttons.SetActive(false);
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
        else if (isTutorial == true && isTutorial_Check2 == false)
        {
            check.transform.GetChild(0).gameObject.SetActive(false);
            isDoubleUp = false;
            isSmile = false;
            isNum = false;
            isTutorial_Check2 = true;
            tutorial.SetActive(false);
            game.SetActive(true);
            
            if (gameManager.stage_Select_Level_Num == 1)
            {
                character_Step1.SetActive(true);
            }
            else if (gameManager.stage_Select_Level_Num == 2)
            {
                character_Step2.SetActive(true);
            }
            else if (gameManager.stage_Select_Level_Num == 3)
            {
                character_Step3.SetActive(true);
            }
            
            gameManager.buttons.SetActive(true);
        }
    }
    
    void Tutorial_Notice()
    {
        if (tutorial_Notice_Num == 1)
        {
            tutorial_Notice.text = "호흡 후에 빙그레 웃음으로 마무리를 합니다.";
            tutorial_Notice_Image.GetComponent<Animator>().Play("Text");
        }
        else if (tutorial_Notice_Num == 2)
        {
            tutorial_Notice.text = "그림과 같이 두 손가락을\n빙빙이의 양 입꼬리를 터치하여\n위로 올려 빙그레 미소를 만들어주세요.";
            tutorial_Character.SetActive(true);
            tutorial_Finger.SetActive(true);
            tutorial_Finger.GetComponent<Animator>().Play("Finger3");
        }
        else if (tutorial_Notice_Num == 3)
        {
            tutorial_Notice_Image.SetActive(false);
            gameObject.GetComponent<Touch>().result = Result.none;
            tutorial_Notice.text = "빙빙이를 따라\n당신의 입꼬리도 올려\n미소를 빙그레 지어보세요.";
        }
    }

    public void Skip()
    {
        isTutorial = true;
        PlayerPrefs.SetInt("Smile_Tutorial", 1);
    }

    void Cursor()
    {
        if (isTutorial == false)
        {
            if (isTutorial_Cursor == false && tutorial_Notice_Num >= 4 && gameObject.GetComponent<Touch>().result == Result.up)
            {
                isTutorial_Cursor = true;
                isDoubleUp = true;
                tutorial_Notice.text = "잘했어요!\n호흡과 빙그레 연습을 마칩니다.";
                tutorial_Finger.SetActive(false);
                gameObject.GetComponent<Touch>().result = Result.none;
            }
        }
        else if (isTutorial == true) // ((Input.touches[0].position.x < (gameManager.screen_Width / 2) && Input.touches[1].position.x > (gameManager.screen_Width / 2)) || (Input.touches[0].position.x > (gameManager.screen_Width / 2) && Input.touches[1].position.x < (gameManager.screen_Width / 2)))
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
        if (isTutorial == false)
        {
            if (isDoubleUp == true && isNum == false)
            {
                isSmile = true;
                isNum = true;
                animManager.BackGlow();
                tutorial_LightEffect.SetActive(false);
                tutorial_LightEffect.SetActive(true);
                transform.GetComponent<AudioSource>().Play();
            }
        }
        else if (isTutorial == true)
        {
            if (isDoubleUp == false)
            {
                isSmile = false;
            }
            else if (isDoubleUp == true && isNum == false)
            {
                check.transform.GetChild(0).gameObject.SetActive(true);
                isSmile = true;
                isNum = true;
                animManager.BackGlow();
                lightEffect.SetActive(false);
                lightEffect.SetActive(true);
                transform.GetComponent<AudioSource>().Play();
            }
        }
    }

    void Timer()
    {
        if (isTutorial == true)
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

    public void ReStart()
    {
        if (gameManager.pause.activeSelf == true)
        {
            var animator = gameManager.pause.GetComponent<Animator>();
            animator.Play("Close");
            Invoke("Pause_Close", 0.5f);
            Reset();
        }
        else
        {
            var animator = success.GetComponent<Animator>();
            animator.Play("Close");
            Invoke("Success_Close", 0.5f);
            Reset();
        }
    }
    
    public void Next()
    {
        if (gameManager.stage_Select_Level_Num == 1)
        {
            if (PlayerPrefs.GetInt("level") <= 1)
            {
                PlayerPrefs.SetInt("level", 2);
            }
        }
        else if (gameManager.stage_Select_Level_Num == 2)
        {
            if (PlayerPrefs.GetInt("level") <= 5)
            {
                PlayerPrefs.SetInt("level", 6);
            }
        }
        else if (gameManager.stage_Select_Level_Num == 3)
        {
            if (PlayerPrefs.GetInt("level") <= 9)
            {
                PlayerPrefs.SetInt("level", 10);
            }
        }
        
        var animator = success.GetComponent<Animator>();
        animator.Play("Close");
        animManager.Fade_Out();
        Invoke("Success_Close", 0.5f);
        gameManager.Set();
    }
    
    public void Help()
    {
        PlayerPrefs.SetInt("Smile_Tutorial", 0);
        var animator = gameManager.pause.GetComponent<Animator>();
        animator.Play("Close");
        Reset();
        Invoke("Pause_Close", 0.5f);
    }
    
    void Success_Close()
    {
        success.SetActive(false);
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
        tutorial_LightEffect.SetActive(false);
        tutorial_Notice.text = "호흡 후에 빙그레 웃음으로 마무리를 합니다.";
        tutorial_Character.SetActive(false);
        tutorial_Finger.SetActive(false);
        tutorial_BackGlow.SetActive(false);
        game.SetActive(false);
        character_Step1.SetActive(false);
        character_Step2.SetActive(false);
        character_Step3.SetActive(false);
        lightEffect.SetActive(false);
        shadow.SetActive(false);
        time = 0;
        isDoubleUp = false;
        isSmile = false;
        isNum = false;
        isTutorial = false;
        isTutorial_Check = false;
        isTutorial_Check2 = false;
        isTutorial_Cursor = false;
        tutorial_Notice_Num = 1;
        check.transform.GetChild(0).gameObject.SetActive(false);
        gameManager.buttons.SetActive(true);
        fade.SetActive(false);
        fade.GetComponent<Image>().color = new Color(0, 0, 0, 1);
        tutorial_Notice_Image.SetActive(true);
    }
}
