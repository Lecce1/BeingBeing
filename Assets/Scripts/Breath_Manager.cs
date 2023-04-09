using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Breath_Manager : MonoBehaviour
{
    public GameObject tutorial;
    public GameObject tutorial_Notice;
    public GameObject tutorial_Finger;
    public GameObject tutorial_Body;
    public GameObject game;
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
    public bool isNext = false;
    WaitForSeconds waitForSeconds = new WaitForSeconds(0.01f);
    Anim_Manager anim_Manager;
    public bool isTutorial;
    private bool isTutorial_Check;
    private bool isTutorial_Check2;

    void Awake()
    {
        anim_Manager = GameObject.Find("Anim_Manager").GetComponent<Anim_Manager>();
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
        if (isTutorial == false && isTutorial_Check == false)
        {
            isTutorial_Check = true;
            tutorial_Finger.GetComponent<Animator>().Play("Breath_Finger");
        }
        if (isTutorial == true && isTutorial_Check2 == false)
        {
            isTutorial_Check2 = true;
            isUp = false;
            isDown = false;
            isBreathe = false;
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
    
    void Breathe()
    {
        if (isDown == true && isLimit == false && isBreathe == false)
        {
            isBreathe = true;
            StartCoroutine(Breathe2());
        }
        else if (isUp == true && isLimit == false && isBreathe == true)
        {
            isBreathe = false;
            StartCoroutine(Breathe2());
        }
    }

    IEnumerator Breathe2()
    {
        if (isTutorial == false)
        {
            if (isBreathe == true)
            {
                tutorial_Notice.GetComponent<TextMeshProUGUI>().text = "잘했어요!";
                tutorial_Finger.SetActive(false);
                
                while (tutorial_Body.transform.localScale.x < 1.2f)
                {
                    yield return waitForSeconds;
                    tutorial_Body.transform.localScale += new Vector3(0.3f, 0.3f, 0) * Time.deltaTime;
                }

                tutorial_Finger.GetComponent<RectTransform>().rotation = Quaternion.Euler(0, 0, -180);
                tutorial_Finger.SetActive(true);
                tutorial_Finger.GetComponent<Animator>().Play("Breath_Finger2");
                tutorial_Notice.GetComponent<TextMeshProUGUI>().text = "숨을 내쉬기 위해 화살표를 따라 위로 드래그 해주세요";
            }
            else if (isBreathe == false)
            {
                isUp = false;
                isDown = false;
                tutorial_Notice.GetComponent<TextMeshProUGUI>().text = "잘했어요! 튜토리얼은 여기까지 ~";
                tutorial_Finger.SetActive(false);
                
                while (tutorial_Body.transform.localScale.x > 1)
                {
                    yield return waitForSeconds;
                    tutorial_Body.transform.localScale -= new Vector3(0.3f, 0.3f, 0) * Time.deltaTime;
                }
                
                Invoke("Skip", 3.0f);
            }
        }
        else if (isTutorial == true)
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

                if (count <= 10)
                {
                    count++;
                }

                StartCoroutine(Gauge2());
            }
        }
    }

    IEnumerator Gauge2()
    {
        while (circle.fillAmount < (count * 0.2f))
        {
            yield return waitForSeconds;
            circle.fillAmount += 0.5f * Time.deltaTime;
        }

        if (circle.fillAmount >= 1f)
        {
            shadow.SetActive(true);
            success.SetActive(true);
        }

        yield return null;
    }

    void Timer()
    {
        if (isTutorial == true)
        {
            time += Time.deltaTime;

            if (time >= 4)
            {
                time = 0;
                isLimit = false;
            }
        }
    }
    
    public void List()
    {
        var animator = success.GetComponent<Animator>();
        animator.Play("Close");
        anim_Manager.Fade_Out();
        Invoke("Success_Close", 0.5f);
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
        isNext = true;
        var animator = success.GetComponent<Animator>();
        animator.Play("Close");
        anim_Manager.Fade_Out();
        Invoke("Success_Close", 0.5f);
    }
    
    void Success_Close()
    {
        success.SetActive(false);
    }

    public void Reset()
    {
        tutorial_Notice.GetComponent<TextMeshProUGUI>().text = "숨을 들이쉬기 위해 화살표를 따라 아래로 드래그 해주세요";
        tutorial_Finger.GetComponent<RectTransform>().rotation = Quaternion.Euler(0, 0, 0);
        isTutorial = false;
        tutorial.SetActive(true);
        game.SetActive(false);
        tutorial_Body.transform.localScale = new Vector3(1, 1, 1);
        body.transform.localScale = new Vector3(1, 1, 1);
        count = 0;
        time = 0;
        isLimit = false;
        isUp = false; 
        isDown = false;
        isBreathe = false;
        isNext = false;
        circle.fillAmount = 0;
        shadow.SetActive(false);
        success.SetActive(false);
    }
}
