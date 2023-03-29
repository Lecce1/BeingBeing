using UnityEngine;
using UnityEngine.UI;

public class Smile_Manager : MonoBehaviour
{
    public GameObject tutorial;
    public GameObject tutorial_Arrow;
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
    public bool isSmile = false;
    public bool isNum = false;
    WaitForEndOfFrame waitForEndOfFrame = new WaitForEndOfFrame();
    GameManager gameManager;
    Anim_Manager anim_Manager;
    public bool isTutorial;
    private bool isTutorial_Check;
    private bool isTutorial_Check2;

    void Awake()
    {
        PlayerPrefs.DeleteAll();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        anim_Manager = GameObject.Find("Anim_Manager").GetComponent<Anim_Manager>();
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
            tutorial_Arrow.GetComponent<Animator>().Play("Arrow");
        }
        if (isTutorial == true && isTutorial_Check2 == false)
        {
            isLeftUp = false;
            isRightUp = false;
            isSmile = false;
            isNum = false;
            isTutorial_Check2 = true;
            tutorial.SetActive(false);
            game.SetActive(true);
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
            if (Input.mousePosition.x < (gameManager.screen_Width / 2) && gameObject.GetComponent<Touch>().result == Result.up)
            {
                isLeftUp = true;
                gameObject.GetComponent<Touch>().result = Result.none;
                tutorial_Arrow.GetComponent<Animator>().Play("Arrow2");
            }
            else if (isLeftUp == true && Input.mousePosition.x > (gameManager.screen_Width / 2) && gameObject.GetComponent<Touch>().result == Result.up)
            {
                isRightUp = true;
                gameObject.GetComponent<Touch>().result = Result.none;
                tutorial_Arrow.SetActive(false);
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
            else if (isLeftUp == true && isRightUp == true && isNum == false)
            {
                tutorial_Mouse.GetComponent<Image>().sprite = Resources.Load<Sprite>("mouse4");
                isSmile = true;
                isNum = true;
                anim_Manager.BackGlow();
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
                anim_Manager.BackGlow();
                lightEffect.SetActive(false);
                lightEffect.SetActive(true);
                transform.GetComponent<AudioSource>().Play();

                if (num == 1)
                {
                    checks.transform.GetChild(0).Find("Image").gameObject.SetActive(true);
                }
                else if (num == 2)
                {
                    checks.transform.GetChild(1).Find("Image").gameObject.SetActive(true);
                }
                else if (num == 3)
                {
                    checks.transform.GetChild(2).Find("Image").gameObject.SetActive(true);
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
        var animator = success.GetComponent<Animator>();
        animator.Play("Close");
        gameManager.isLevel_Start = false;
        anim_Manager.Fade_Out();
        Invoke("Success_Close", 0.5f);
    }
    
    void Success_Close()
    {
        success.SetActive(false);
    }

    public void Back()
    {
        gameManager.isLevel_Start = false;
        anim_Manager.Fade_Out();
    }

    public void Reset()
    {
        tutorial.SetActive(true);
        tutorial_Arrow.SetActive(true);
        game.SetActive(false);
        checks.transform.GetChild(0).Find("Image").gameObject.SetActive(false);
        checks.transform.GetChild(1).Find("Image").gameObject.SetActive(false);
        checks.transform.GetChild(2).Find("Image").gameObject.SetActive(false);
        lightEffect.SetActive(false);
        shadow.SetActive(false);
        time = 0; 
        num = 0;
        isLeftUp = false;
        isRightUp = false;
        isSmile = false;
        isNum = false;
        isTutorial = false;
        isTutorial_Check = false;
        isTutorial_Check2 = false;
    }
}
