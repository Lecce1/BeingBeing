using UnityEngine;
using UnityEngine.UI;

public class Smile_Manager : MonoBehaviour
{
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

    void Awake()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        anim_Manager = GameObject.Find("Anim_Manager").GetComponent<Anim_Manager>();
    }

    void Update()
    {
        Cursor();
        Mouse();
        Timer();
    }

    void Cursor()
    {
        if (Input.mousePosition.x < 590 && Input.mousePosition.y > 1000 && gameObject.GetComponent<Touch>().result == Result.up)
        {
            time = 0;
            isLeftUp = true;
            gameObject.GetComponent<Touch>().result = Result.none;
        }
        else if (Input.mousePosition.x > 590 && Input.mousePosition.y > 1000 && gameObject.GetComponent<Touch>().result == Result.up)
        {
            time = 0;
            isRightUp = true;
            gameObject.GetComponent<Touch>().result = Result.none;
        }
    }

    void Mouse()
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

    void Timer()
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
        Reset();
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
    }
}
