using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Refresh_Manager : MonoBehaviour
{
    public GameObject breath;
    public GameObject body;
    public Image circle;
    public GameObject shadow;
    public GameObject success;
    private int count = 0;
    private float time = 0;
    private bool isLimit = false;
    public bool isUp = false;
    public bool isDown = false;
    public bool isBreathe = false;
    private bool isFirst = false;

    public GameObject smile;
    public GameObject mouse;
    public GameObject backGlow;
    public GameObject lightEffect;
    public bool isLeftUp = false;
    public bool isRightUp = false;
    public bool isSmile = false;
    public bool isNum = false;
    WaitForSeconds waitForSeconds = new WaitForSeconds(0.01f);
    GameManager gameManager;
    AnimManager animManager;

    void Awake()
    {
        animManager = GameObject.Find("AnimManager").GetComponent<AnimManager>();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    void Update()
    {
        Cursor();
        Breathe();
        Gauge();
        Timer();
        Mouse();
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
            while (body.transform.localScale.x < 1.2f)
            {
                yield return waitForSeconds;
                body.transform.localScale += new Vector3(1f, 1f, 0) * Time.deltaTime;
            }
        }
        else if (isBreathe == false)
        {
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

        yield return null;
    }

    void Timer()
    {
        if (isFirst == false)
        {
            time += Time.deltaTime;

            if (time >= 4)
            {
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
                    isLeftUp = false;
                    isRightUp = false;
                }
            }
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
            animManager.Refresh_BackGlow();
            lightEffect.SetActive(false);
            lightEffect.SetActive(true);
            transform.GetComponent<AudioSource>().Play();
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
        if (PlayerPrefs.GetInt("level") <= 2)
        {
            PlayerPrefs.SetInt("level", 3);
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
        breath.SetActive(true);
        body.transform.localScale = new Vector3(1, 1, 1);
        circle.fillAmount = 0;
        count = 0;
        time = 0;
        isLimit = false;
        isUp = false; 
        isDown = false;
        isBreathe = false;
        smile.SetActive(false);
        backGlow.SetActive(false);
        lightEffect.SetActive(false);
        isLeftUp = false;
        isRightUp = false;
        isSmile = false;
        isNum = false;
        isFirst = false;
        shadow.SetActive(false);
        success.SetActive(false);
        gameManager.buttons.SetActive(true);
    }
}
