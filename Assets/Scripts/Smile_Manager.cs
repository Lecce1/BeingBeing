using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Smile_Manager : MonoBehaviour
{
    public GameObject tutorial;
    public GameObject tutorial_Notice;
    public GameObject tutorial_Finger;
    public GameObject tutorial_Mouse;
    public GameObject tutorial_BackGlow;
    public GameObject tutorial_LightEffect;
    public GameObject game;
    public GameObject mouse;
    public GameObject backGlow;
    public GameObject lightEffect;
    public GameObject checks;
    public GameObject shadow;
    public GameObject success;
    public float time = 0;
    public int num = 0;
    public bool isLeftUp = false;
    public bool isRightUp = false;
    public bool isDoubleUp;
    public bool isSmile = false;
    public bool isNum = false;
    GameManager gameManager;
    AnimManager animManager;
    public bool isTutorial;
    private bool isTutorial_Check;
    private bool isTutorial_Check2;
    private bool isTutorial_Cursor;

    void Awake()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        animManager = GameObject.Find("AnimManager").GetComponent<AnimManager>();
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
        if (isTutorial == false && isTutorial_Check == false)
        {
            isTutorial_Check = true;
            gameManager.Set();
            tutorial_Finger.GetComponent<Animator>().Play("Finger");
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
            if (gameManager.stage_Select_Level_Num == 1)
            {
                checks.transform.GetChild(0).gameObject.SetActive(true);
                checks.transform.GetChild(1).gameObject.SetActive(false);
                checks.transform.GetChild(2).gameObject.SetActive(false);
            }
            else if (gameManager.stage_Select_Level_Num == 2)
            {
                checks.transform.GetChild(0).gameObject.SetActive(false);
                checks.transform.GetChild(1).gameObject.SetActive(true);
                checks.transform.GetChild(2).gameObject.SetActive(false);
            }
            else if (gameManager.stage_Select_Level_Num == 3)
            {
                checks.transform.GetChild(0).gameObject.SetActive(false);
                checks.transform.GetChild(1).gameObject.SetActive(false);
                checks.transform.GetChild(2).gameObject.SetActive(true);
            }
            
            isLeftUp = false;
            isRightUp = false;
            isDoubleUp = false;
            isSmile = false;
            isNum = false;
            isTutorial_Check2 = true;
            mouse.GetComponent<Image>().sprite = Resources.Load<Sprite>("mouse");
            tutorial.SetActive(false);
            game.SetActive(true);
            gameManager.buttons.SetActive(true);
        }
    }

    public void Skip()
    {
        isTutorial = true;
    }

    void Cursor()
    {
        if (isTutorial == false)
        {
            if (isTutorial_Cursor == false && isLeftUp == false && isRightUp == false && isDoubleUp == false && Input.mousePosition.x < (gameManager.screen_Width / 2) && gameObject.GetComponent<Touch>().result == Result.up)
            {
                isTutorial_Cursor = true;
                isLeftUp = true;
                tutorial_Notice.GetComponent<TextMeshProUGUI>().text = "잘했어요!";
                tutorial_Finger.SetActive(false);
                Invoke("Tutorial_Cursor", 3.0f);
                gameObject.GetComponent<Touch>().result = Result.none;
            }
            else if (isTutorial_Cursor == false && isLeftUp == true && isRightUp == false && isDoubleUp == false && Input.mousePosition.x > (gameManager.screen_Width / 2) && gameObject.GetComponent<Touch>().result == Result.up)
            {
                isTutorial_Cursor = true;
                isRightUp = true;
                tutorial_Notice.GetComponent<TextMeshProUGUI>().text = "잘했어요!";
                tutorial_Finger.SetActive(false);
                Invoke("Tutorial_Cursor", 3.0f);
                gameObject.GetComponent<Touch>().result = Result.none;
            }
            else if (isTutorial_Cursor == false && isLeftUp == false && isRightUp == false && isDoubleUp == true && Input.touchCount == 2 && gameObject.GetComponent<Touch>().result == Result.up && ((Input.touches[0].position.x < (gameManager.screen_Width / 2) && Input.touches[1].position.x > (gameManager.screen_Width / 2)) || (Input.touches[0].position.x > (gameManager.screen_Width / 2) && Input.touches[1].position.x < (gameManager.screen_Width / 2))))
            {
                isTutorial_Cursor = true;
                isLeftUp = true;
                isRightUp = true;
                tutorial_Notice.GetComponent<TextMeshProUGUI>().text = "잘했어요! 튜토리얼은 여기까지 ~";
                tutorial_Finger.SetActive(false);
                Invoke("Tutorial_Cursor", 3.0f);
                gameObject.GetComponent<Touch>().result = Result.none;
            }
        }
        else if (isTutorial == true)
        {
            if (Input.mousePosition.x < (gameManager.screen_Width / 2) && gameObject.GetComponent<Touch>().result == Result.up)
            {
                time = 0;
                isLeftUp = true;
                gameObject.GetComponent<Touch>().result = Result.none;
            }
            else if (Input.mousePosition.x > (gameManager.screen_Width / 2) && gameObject.GetComponent<Touch>().result == Result.up)
            {
                time = 0;
                isRightUp = true;
                gameObject.GetComponent<Touch>().result = Result.none;
            }
            else if (Input.touchCount == 2 && ((Input.touches[0].position.x < (gameManager.screen_Width / 2) && Input.touches[1].position.x > (gameManager.screen_Width / 2)) || (Input.touches[0].position.x > (gameManager.screen_Width / 2) && Input.touches[1].position.x < (gameManager.screen_Width / 2))))
            {
                time = 0;
                isLeftUp = true;
                isRightUp = true;
                gameObject.GetComponent<Touch>().result = Result.none;
            }
        }
    }

    void Tutorial_Cursor()
    {
        if (isLeftUp == true && isRightUp == false && isDoubleUp == false)
        {
            isTutorial_Cursor = false;
            tutorial_Notice.GetComponent<TextMeshProUGUI>().text = "손가락을 따라 위로 드래그 해주세요";
            gameObject.GetComponent<Touch>().result = Result.none;
            tutorial_Finger.SetActive(true);
            tutorial_Finger.GetComponent<Animator>().Play("Finger2");
        }
        else if (isLeftUp == true && isRightUp == true && isDoubleUp == false)
        {
            isTutorial_Cursor = false;
            tutorial_Notice.GetComponent<TextMeshProUGUI>().text = "두 손가락을 따라 위로 드래그 해주세요";
            gameObject.GetComponent<Touch>().result = Result.none;
            tutorial_Finger.SetActive(true);
            tutorial_Finger.transform.GetChild(0).gameObject.SetActive(true);
            tutorial_Finger.GetComponent<Animator>().Play("Finger3");
            isLeftUp = false;
            isRightUp = false;
            isDoubleUp = true;
        }
        else if (isLeftUp == true && isRightUp == true && isDoubleUp == true)
        {
            gameObject.GetComponent<Touch>().result = Result.none;
            tutorial_Finger.SetActive(false);
        }
    }

    void Mouse()
    {
        if (isTutorial == false)
        {
            if (isLeftUp == false && isRightUp == false)
            {
                tutorial_Mouse.GetComponent<Image>().sprite = Resources.Load<Sprite>("mouse");
                isSmile = false;
            }
            else if (isLeftUp == true && isRightUp == false)
            {
                tutorial_Mouse.GetComponent<Image>().sprite = Resources.Load<Sprite>("mouse2");
                isSmile = false;
            }
            else if (isLeftUp == false && isRightUp == true)
            {
                tutorial_Mouse.GetComponent<Image>().sprite = Resources.Load<Sprite>("mouse3");
                isSmile = false;
            }
            else if (isLeftUp == true && isRightUp == true && isNum == false && isDoubleUp == false)
            {
                tutorial_Mouse.GetComponent<Image>().sprite = Resources.Load<Sprite>("mouse4");
                isSmile = false;
            }
            else if (isLeftUp == true && isRightUp == true && isNum == false && isDoubleUp == true)
            {
                tutorial_Mouse.GetComponent<Image>().sprite = Resources.Load<Sprite>("mouse4");
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
            if (isLeftUp == false && isRightUp == false)
            {
                mouse.GetComponent<Image>().sprite = Resources.Load<Sprite>("mouse");
                isSmile = false;
            }
            else if (isLeftUp == true && isRightUp == false)
            {
                mouse.GetComponent<Image>().sprite = Resources.Load<Sprite>("mouse2");
                isSmile = false;
            }
            else if (isLeftUp == false && isRightUp == true)
            {
                mouse.GetComponent<Image>().sprite = Resources.Load<Sprite>("mouse3");
                isSmile = false;
            }
            else if (isLeftUp == true && isRightUp == true && isNum == false)
            {
                mouse.GetComponent<Image>().sprite = Resources.Load<Sprite>("mouse4");
                isSmile = true;
                isNum = true;
                num++;
                animManager.BackGlow();
                lightEffect.SetActive(false);
                lightEffect.SetActive(true);
                transform.GetComponent<AudioSource>().Play();

                if (gameManager.stage_Select_Level_Num == 1)
                {
                    if (num == 1)
                    {
                        checks.transform.GetChild(0).GetChild(0).Find("Image").gameObject.SetActive(true);
                    }
                    else if (num == 2)
                    {
                        checks.transform.GetChild(0).GetChild(1).Find("Image").gameObject.SetActive(true);
                    }
                    else if (num == 3)
                    {
                        checks.transform.GetChild(0).GetChild(2).Find("Image").gameObject.SetActive(true);
                    }
                }
                else if (gameManager.stage_Select_Level_Num == 2)
                {
                    if (num == 1)
                    {
                        checks.transform.GetChild(1).GetChild(0).Find("Image").gameObject.SetActive(true);
                    }
                    else if (num == 2)
                    {
                        checks.transform.GetChild(1).GetChild(1).Find("Image").gameObject.SetActive(true);
                    }
                }
                else if (gameManager.stage_Select_Level_Num == 3)
                {
                    if (num == 1)
                    {
                        checks.transform.GetChild(3).GetChild(0).Find("Image").gameObject.SetActive(true);
                    }
                }
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
                    isLeftUp = false;
                    isRightUp = false;
                }
            }
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
        
        gameManager.Set();
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
        tutorial.SetActive(true);
        tutorial_LightEffect.SetActive(false);
        tutorial_Notice.GetComponent<TextMeshProUGUI>().text = "손가락을 따라 위로 드래그 해주세요";
        tutorial_Finger.SetActive(true);
        tutorial_Finger.transform.GetChild(0).gameObject.SetActive(false);
        game.SetActive(false);
        checks.transform.GetChild(0).gameObject.SetActive(false);
        checks.transform.GetChild(1).gameObject.SetActive(false);
        checks.transform.GetChild(2).gameObject.SetActive(false);
        checks.transform.GetChild(0).GetChild(0).Find("Image").gameObject.SetActive(false);
        checks.transform.GetChild(0).GetChild(1).Find("Image").gameObject.SetActive(false);
        checks.transform.GetChild(0).GetChild(2).Find("Image").gameObject.SetActive(false);
        checks.transform.GetChild(1).GetChild(0).Find("Image").gameObject.SetActive(false);
        checks.transform.GetChild(1).GetChild(1).Find("Image").gameObject.SetActive(false);
        checks.transform.GetChild(2).GetChild(0).Find("Image").gameObject.SetActive(false);
        lightEffect.SetActive(false);
        shadow.SetActive(false);
        time = 0; 
        num = 0;
        isLeftUp = false;
        isRightUp = false;
        isDoubleUp = false;
        isSmile = false;
        isNum = false;
        isTutorial = false;
        isTutorial_Check = false;
        isTutorial_Check2 = false;
        isTutorial_Cursor = false;
        gameManager.buttons.SetActive(true);
    }
}
