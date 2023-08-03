using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Breath_Manager : MonoBehaviour
{
    public GameObject tutorial;
    public TMP_Text tutorial_Notice;
    public GameObject tutorial_Finger;
    public GameObject tutorial_Character_Panel;
    public GameObject tutorial_Body;
    public Image tutorial_Circle;
    public Image tutorial_Circle_Timer;
    public GameObject game;
    public GameObject game_Notice;
    public GameObject body;
    public Image circle;
    public Image circle_Timer;
    public GameObject shadow;
    [SerializeField]
    private int count = 0;
    private float time = 0;
    private bool isLimit = false;
    public bool isUp = false;
    public bool isDown = false;
    public bool isBreathe = false;
    public bool isNext = false;
    public bool isCheck = false;
    WaitForSeconds waitForSeconds = new WaitForSeconds(0.01f);
    GameManager gameManager;
    AnimManager animManager;
    public bool isTutorial;
    private bool isTutorial_Check;
    private bool isTutorial_Check2;
    private int tutorial_Notice_Num = 1;
    private bool isTouch = false;
    public GameObject fade;
    public GameObject tutorial_Notice_Image;

    void Awake()
    {
        animManager = GameObject.Find("AnimManager").GetComponent<AnimManager>();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    void Update()
    {
        Tutorial();
        Cursor();
        Breathe();
        Gauge();
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

                if (gameManager.stage_Select_Level_Num == 1 && PlayerPrefs.GetInt("Breath_Tutorial") == 0)
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

                    if (tutorial_Notice_Num != 6)
                    {
                        Tutorial_Notice();
                    }
                }
            }
        }
        else if (isTutorial == true && isTutorial_Check2 == false)
        {
            tutorial_Circle.fillAmount = 0;
            count = 0;
            isTutorial_Check2 = true;
            isUp = false;
            isDown = false;
            isBreathe = false;
            isTouch = false;
            tutorial.SetActive(false);
            game.SetActive(true);
            gameManager.buttons.SetActive(true);
            Invoke(nameof(First_Text), 5f);
        }
    }

    private void First_Text()
    {
        game_Notice.GetComponent<TMP_Text>().text = "숨을 들이쉬고";
    }

    void Tutorial_Notice()
    {
        if (tutorial_Notice_Num == 1)
        {
            tutorial_Notice.text = "안녕하세요\n호흡 연습을 시작합니다.";
            tutorial_Notice_Image.GetComponent<Animator>().Play("Text");
        }
        else if (tutorial_Notice_Num == 2)
        {
            tutorial_Notice.text = "숨을 들이쉴 때와\n숨을 내쉴 때의 느낌을\n알고 계신가요?";
        }
        else if (tutorial_Notice_Num == 3)
        {
            tutorial_Notice.text = "숨을 들이쉬고 내쉴 때의 느낌에\n주의를 기울이며\n호흡을 함께 진행봅시다.";
        }
        else if (tutorial_Notice_Num == 4)
        {
            tutorial_Notice.text = "숨을 들이쉬면서 2초\n내쉬면서 2초\n한 호흡은 4초 동안 진행됩니다.";
        }
        else if (tutorial_Notice_Num == 5)
        {
            tutorial_Notice_Image.SetActive(false);
            tutorial_Character_Panel.SetActive(true);
            tutorial_Finger.SetActive(true);
            tutorial_Finger.GetComponent<Animator>().Play("Breath_Finger");
            tutorial_Notice.text = "당신도 빙빙이와 함께\n숨을 들이쉬면서 가슴에서 배로\n손가락을 드래그 합니다.";
            isDown = false;
            isUp = false;
        }
    }

    public void Skip()
    {
        isTutorial = true;
        PlayerPrefs.SetInt("Breath_Tutorial", 1);
    }

    void Cursor()
    {
        if (isTutorial == false && isTouch == false)
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
        else if (isTutorial == true && isTouch == false)
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
    }
    
    void Breathe()
    {
        if (isTutorial == false && tutorial_Notice_Num >= 5)
        {
            if (isDown == true && isLimit == false && isBreathe == false)
            {
                isBreathe = true;
                isTouch = true;
                StartCoroutine(Gauge2());
                StartCoroutine(Breathe2());
            }
            else if (isUp == true && isLimit == false && isBreathe == true)
            {
                isBreathe = false;
                isTouch = true;
                StartCoroutine(Gauge2());
                StartCoroutine(Breathe2());
            }
        }
        else if (isTutorial == true)
        {
            if (isDown == true && isLimit == false && isBreathe == false)
            {
                isBreathe = true;
                isTouch = true;
                StartCoroutine(Gauge2());
                StartCoroutine(Breathe2());
            }
            else if (isUp == true && isLimit == false && isBreathe == true)
            {
                isBreathe = false;
                isTouch = true;
                StartCoroutine(Gauge2());
                StartCoroutine(Breathe2());
            }
        }
    }

    IEnumerator Breathe2()
    {
        if (isTutorial == false)
        {
            if (isBreathe == true)
            {
                tutorial_Notice.text = "잘했어요!";
                tutorial_Finger.SetActive(false);
                
                while (tutorial_Body.transform.localScale.x < 1.2f)
                {
                    yield return waitForSeconds;
                    tutorial_Body.transform.localScale += new Vector3(0.2f, 0.2f, 0) * Time.deltaTime;
                }
                
                tutorial_Finger.SetActive(true);
                tutorial_Finger.GetComponent<Animator>().Play("Breath_Finger2");
                tutorial_Notice.text = "이번에는 빙빙이와 함께\n숨을 내쉬면서 배에서 가슴으로\n드래그 합니다.";
                isTouch = false;
            }
            else if (isBreathe == false)
            {
                isUp = false;
                isDown = false;
                //tutorial_Notice.text = "잘 하셨습니다. 호흡 연습을 마칩니다.";
                tutorial_Notice.text = "잘 하셨습니다.";
                tutorial_Finger.SetActive(false);

                while (tutorial_Body.transform.localScale.x > 1)
                {
                    yield return waitForSeconds;
                    tutorial_Body.transform.localScale -= new Vector3(0.3f, 0.3f, 0) * Time.deltaTime;
                }
                
                Invoke("Skip", 3.0f);
                isTouch = false;
            }
        }
        else if (isTutorial == true)
        {
            if (isBreathe == true)
            {
                game_Notice.GetComponent<TMP_Text>().text = string.Empty;
                
                while (body.transform.localScale.x < 1.2f)
                {
                    yield return waitForSeconds;
                    body.transform.localScale += new Vector3(1f, 1f, 0) * Time.deltaTime;
                }
                
                game_Notice.GetComponent<TMP_Text>().text = "내쉬고";
                isTouch = false;
            }
            else if (isBreathe == false)
            {
                game_Notice.GetComponent<TMP_Text>().text = string.Empty;
                
                while (body.transform.localScale.x > 1)
                {
                    yield return waitForSeconds;
                    body.transform.localScale -= new Vector3(1f, 1f, 0) * Time.deltaTime;
                }
                
                isTouch = false;
            }
        }
        
        yield return null;
    }

    void Gauge()
    {
        if (isTutorial == true)
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
        
        if (isTutorial == false && tutorial_Notice_Num >= 5)
        {
            if (count <= 10)
            {
                count++;
            }
        
            while (tutorial_Circle.fillAmount < (count * 0.1f))
            {
                yield return waitForSeconds;
                tutorial_Circle.fillAmount += 0.5f * Time.deltaTime;
            }
        }
        else if (isTutorial == true)
        {
            if (gameManager.stage_Select_Level_Num == 1)
            {
                if (count < 10)
                {
                    count++;
                }
        
                while (circle.fillAmount < (count * 0.1f))
                {
                    yield return waitForSeconds;
                    circle.fillAmount += 0.5f * Time.deltaTime;

                    if (circle.fillAmount == 1)
                    {
                        break;
                    }
                }
            }
            else if (gameManager.stage_Select_Level_Num == 2)
            {
                if (count < 14)
                {
                    count++;
                }
        
                while (circle.fillAmount < (count * 0.07142857f))
                {
                    yield return waitForSeconds;
                    circle.fillAmount += 0.5f * Time.deltaTime;
                    
                    if (circle.fillAmount == 1)
                    {
                        break;
                    }
                }
            }
            else if (gameManager.stage_Select_Level_Num == 3)
            {
                if (count < 20)
                {
                    count++;
                }
        
                while (circle.fillAmount < (count * 0.05f))
                {
                    yield return waitForSeconds;
                    circle.fillAmount += 0.5f * Time.deltaTime;
                    
                    if (circle.fillAmount == 1)
                    {
                        break;
                    }
                }
            }

            if (circle.fillAmount == 1)
            {
                isNext = true;
                game_Notice.GetComponent<TMP_Text>().text = string.Empty;
                StartCoroutine(nameof(FadeOut));
            }
        }

        isCheck = true;
        
        yield return null;
    }

    private IEnumerator FadeOut()
    {
        fade.SetActive(true);
        float timer = 0;

        while (timer < 255)
        {
            timer += 250 * Time.deltaTime;
            fade.GetComponent<Image>().color = new Color(0, 0, 0, timer / 255f);
            Debug.Log("timer + " + timer);
            yield return waitForSeconds;
        }
        
        Reset();
        gameManager.breath.SetActive(false);
        gameManager.smile.SetActive(true);
    }

    void Timer()
    {
        if (isTutorial == false)
        {
            if (isLimit == true && isCheck == true && tutorial_Circle.fillAmount != 1)
            {
                time += Time.deltaTime;
                tutorial_Circle_Timer.fillAmount = time / 4;
            }
            
            if (time >= 4)
            {
                tutorial_Notice.GetComponent<TMP_Text>().text = "숨을 들이쉬고";
                tutorial_Circle_Timer.fillAmount = 0;
                time = 0;
                isLimit = false;
            }
        }
        else if (isTutorial == true)
        {
            if (isLimit == true && isCheck == true && circle.fillAmount != 1)
            {
                time += Time.deltaTime;
                circle_Timer.fillAmount = time / 4;
            }
            
            if (time >= 4)
            {
                game_Notice.GetComponent<TMP_Text>().text = "숨을 들이쉬고";
                circle_Timer.fillAmount = 0;
                time = 0;
                isLimit = false;
            }
        }
    }
    
    public void ReStart()
    {
        if (gameManager.pause.activeSelf == true)
        {
            var animator = gameManager.pause.GetComponent<Animator>();
            animator.Play("Close");
            Reset();
            Invoke("Pause_Close", 0.5f);
        }
        else
        {
            Reset();
        }
    }

    public void Help()
    {
        PlayerPrefs.SetInt("Breath_Tutorial", 0);
        var animator = gameManager.pause.GetComponent<Animator>();
        animator.Play("Close");
        Reset();
        Invoke("Pause_Close", 0.5f);
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
        tutorial_Notice.text = "안녕하세요\n호흡 연습을 시작합니다.";
        tutorial_Character_Panel.SetActive(false);
        tutorial_Finger.SetActive(false);
        tutorial_Notice_Num = 1;
        isTouch = false;
        isTutorial = false;
        isTutorial_Check = false;
        isTutorial_Check2 = false;
        tutorial.SetActive(true);
        game.SetActive(false);
        game_Notice.GetComponent<TMP_Text>().text = "소리를 켜서 안내말을 따라해 주세요.";
        tutorial_Body.transform.localScale = new Vector3(1, 1, 1);
        body.transform.localScale = new Vector3(1, 1, 1);
        count = 0;
        time = 0;
        isLimit = false;
        isUp = false; 
        isDown = false;
        isBreathe = false;
        isNext = false;
        isCheck = false;
        circle.fillAmount = 0;
        circle_Timer.fillAmount = 0;
        shadow.SetActive(false);
        gameManager.buttons.SetActive(true);
        fade.SetActive(false);
        fade.GetComponent<Image>().color = new Color(0, 0, 0, 0);
        tutorial_Notice_Image.SetActive(true);
    }
}
