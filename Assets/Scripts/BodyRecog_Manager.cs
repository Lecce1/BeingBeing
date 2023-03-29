using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class BodyRecog_Manager : MonoBehaviour
{
    public GameObject line;
    public GameObject points;
    public GameObject choices;
    public GameObject shadow;
    public GameObject success;
    public TMP_Text result = null;
    public int pointNum = 1;
    private int choiceNum;
    private int step = 0;
    private bool isStart = false;
    public bool isStop = false;
    public bool isNext = false;
    WaitForEndOfFrame waitForEndOfFrame = new WaitForEndOfFrame();
    GameManager gameManager;
    Anim_Manager anim_Manager;

    void Awake()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        anim_Manager = GameObject.Find("Anim_Manager").GetComponent<Anim_Manager>();
        points.GetComponent<Animator>().Play("Point");
    }

    void Update()
    {
        Line();
    }
    
    void Line()
    {
        if (isStart == false)
        {
            isStart = true;
            line.GetComponent<Animator>().Play("Line");
        }
        
        if (isStop == false)
        {
            if (pointNum == 1 && line.transform.position.y <= points.transform.GetChild(0).position.y + 0.8f)
            {
                line.GetComponent<Animator>().speed = 0f;
                points.transform.GetChild(0).gameObject.SetActive(false);
                transform.GetComponent<AudioSource>().Play();
                isStop = true;
                Point();
            }
            else if (pointNum == 2 && line.transform.position.y <= points.transform.GetChild(1).position.y + 0.8f)
            {
                line.GetComponent<Animator>().speed = 0f;
                points.transform.GetChild(1).gameObject.SetActive(false);
                transform.GetComponent<AudioSource>().Play();
                isStop = true;
                Point();
            }
            else if (pointNum == 3 && line.transform.position.y <= points.transform.GetChild(2).position.y + 0.8f)
            {
                line.GetComponent<Animator>().speed = 0f;
                points.transform.GetChild(2).gameObject.SetActive(false);
                transform.GetComponent<AudioSource>().Play();
                isStop = true;
                Point();
            }
            else if (pointNum == 4 && line.transform.position.y <= points.transform.GetChild(3).position.y + 0.8f)
            {
                line.GetComponent<Animator>().speed = 0f;
                points.transform.GetChild(3).gameObject.SetActive(false);
                points.transform.GetChild(4).gameObject.SetActive(false);
                transform.GetComponent<AudioSource>().Play();
                isStop = true;
                Point();
            }
            else if (pointNum == 5 && line.transform.position.y <= points.transform.GetChild(5).position.y + 0.8f)
            {
                line.GetComponent<Animator>().speed = 0f;
                points.transform.GetChild(5).gameObject.SetActive(false);
                points.transform.GetChild(6).gameObject.SetActive(false);
                transform.GetComponent<AudioSource>().Play();
                isStop = true;
                Point();
            }
            else if (pointNum == 6 && line.transform.position.y <= points.transform.GetChild(7).position.y + 0.8f)
            {
                line.GetComponent<Animator>().speed = 0f;
                isStop = true;
                result.gameObject.SetActive(true);
                shadow.SetActive(true);
                success.SetActive(true);
            }
        }
    }

    void Point()
    {
        choices.SetActive(true);
        choices.transform.GetChild(0).gameObject.SetActive(true);
        choices.transform.GetChild(0).GetChild(0).GetChild(2).GetComponent<TextMeshProUGUI>().text = "편하다";
        choices.transform.GetChild(0).GetChild(1).GetChild(2).GetComponent<TextMeshProUGUI>().text = "불편하다";
        step = 1;
    }

    public void Choice(int num)
    {
        choiceNum = num;
        choices.transform.GetChild(0).GetChild(0).GetComponent<Button>().interactable = false;
        choices.transform.GetChild(0).GetChild(1).GetComponent<Button>().interactable = false;
        choices.transform.GetChild(1).GetChild(0).GetComponent<Button>().interactable = false;
        choices.transform.GetChild(1).GetChild(1).GetComponent<Button>().interactable = false;
        choices.transform.GetChild(1).GetChild(2).GetComponent<Button>().interactable = false;
        choices.transform.GetChild(1).GetChild(3).GetComponent<Button>().interactable = false;
        choices.transform.GetChild(1).GetChild(4).GetComponent<Button>().interactable = false;
        Invoke("Choice2", 0.5f);
    }
    
    public void Choice2()
    {
        if (step == 1)
        {
            Result(choices.transform.GetChild(0).GetChild(choiceNum - 1).GetChild(2).GetComponent<TextMeshProUGUI>().text);

            if (choiceNum == 1)
            {
                choices.transform.GetChild(0).gameObject.SetActive(false);
                choices.transform.GetChild(1).gameObject.SetActive(true);
                choices.transform.GetChild(1).GetChild(0).GetChild(2).GetComponent<TextMeshProUGUI>().text = "상쾌하다";
                choices.transform.GetChild(1).GetChild(1).GetChild(2).GetComponent<TextMeshProUGUI>().text = "가볍다";
                choices.transform.GetChild(1).GetChild(2).GetChild(2).GetComponent<TextMeshProUGUI>().text = "시원하다";
                choices.transform.GetChild(1).GetChild(3).GetChild(2).GetComponent<TextMeshProUGUI>().text = "따뜻하다";
                choices.transform.GetChild(1).GetChild(4).GetChild(2).GetComponent<TextMeshProUGUI>().text = "편안하다";
            }
            else if (choiceNum == 2)
            {
                choices.transform.GetChild(0).gameObject.SetActive(false);
                choices.transform.GetChild(1).gameObject.SetActive(true);
                choices.transform.GetChild(1).GetChild(0).GetChild(2).GetComponent<TextMeshProUGUI>().text = "불쾌하다";
                choices.transform.GetChild(1).GetChild(1).GetChild(2).GetComponent<TextMeshProUGUI>().text = "무겁다";
                choices.transform.GetChild(1).GetChild(2).GetChild(2).GetComponent<TextMeshProUGUI>().text = "갑갑하다";
                choices.transform.GetChild(1).GetChild(3).GetChild(2).GetComponent<TextMeshProUGUI>().text = "차갑다";
                choices.transform.GetChild(1).GetChild(4).GetChild(2).GetComponent<TextMeshProUGUI>().text = "불편하다";
            }

            step = 2;
        }
        else if (step == 2)
        {
            Result(choices.transform.GetChild(1).GetChild(choiceNum - 1).GetChild(2).GetComponent<TextMeshProUGUI>().text);
            choices.transform.GetChild(1).GetChild(0).GetChild(2).GetComponent<TextMeshProUGUI>().text = "매우 그렇다";
            choices.transform.GetChild(1).GetChild(1).GetChild(2).GetComponent<TextMeshProUGUI>().text = "조금 그렇다";
            choices.transform.GetChild(1).GetChild(2).GetChild(2).GetComponent<TextMeshProUGUI>().text = "보통이다";
            choices.transform.GetChild(1).GetChild(3).GetChild(2).GetComponent<TextMeshProUGUI>().text = "조금 그렇지 않다";
            choices.transform.GetChild(1).GetChild(4).GetChild(2).GetComponent<TextMeshProUGUI>().text = "매우 그렇지 않다";
            step = 3;
        }
        else if (step == 3)
        {
            Result(choices.transform.GetChild(1).GetChild(choiceNum - 1).GetChild(2).GetComponent<TextMeshProUGUI>().text);
            choices.SetActive(false);
            choices.transform.GetChild(1).gameObject.SetActive(false);
            isStop = false;

            if (pointNum == 1)
            {
                points.transform.GetChild(1).gameObject.SetActive(true);
            }
            else if (pointNum == 2)
            {
                points.transform.GetChild(2).gameObject.SetActive(true);
            }
            else if (pointNum == 3)
            {
                points.transform.GetChild(3).gameObject.SetActive(true);
                points.transform.GetChild(4).gameObject.SetActive(true);
            }
            else if (pointNum == 4)
            {
                points.transform.GetChild(5).gameObject.SetActive(true);
                points.transform.GetChild(6).gameObject.SetActive(true);
            }
            else if (pointNum == 5)
            {
                points.transform.GetChild(7).gameObject.SetActive(true);
            }
            
            pointNum++;
            line.GetComponent<Animator>().speed = 1f;
        }
        
        choices.transform.GetChild(0).GetChild(0).GetComponent<Button>().interactable = true;
        choices.transform.GetChild(0).GetChild(1).GetComponent<Button>().interactable = true;
        choices.transform.GetChild(1).GetChild(0).GetComponent<Button>().interactable = true;
        choices.transform.GetChild(1).GetChild(1).GetComponent<Button>().interactable = true;
        choices.transform.GetChild(1).GetChild(2).GetComponent<Button>().interactable = true;
        choices.transform.GetChild(1).GetChild(3).GetComponent<Button>().interactable = true;
        choices.transform.GetChild(1).GetChild(4).GetComponent<Button>().interactable = true;
    }

    void Result(string data)
    {
        if (pointNum == 1)
        {
            if (step == 1)
            {
                result.text += $"머리 : {data}, ";
            }
        }
        else if (pointNum == 2)
        {
            if (step == 1)
            {
                result.text += $"목 : {data}, ";
            }
        }
        else if (pointNum == 3)
        {
            if (step == 1)
            {
                result.text += $"배 : {data}, ";
            }
        }
        else if (pointNum == 4)
        {
            if (step == 1)
            {
                result.text += $"손 : {data}, ";
            }
        }
        else if (pointNum == 5)
        {
            if (step == 1)
            {
                result.text += $"발 : {data}, ";
            }
        }
        
        if (step == 2)
        {
            result.text += $"{data}, ";
        }
        else if (step == 3)
        {
            result.text += $"{data}\n\n";
        }
    }

    public void List()
    {
        var animator = success.GetComponent<Animator>();
        animator.Play("Close");
        gameManager.isLevel_Start = false;
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

    public void Back()
    {
        gameManager.isLevel_Start = false;
        anim_Manager.Fade_Out();
    }

    public void Reset()
    {
        line.GetComponent<Animator>().speed = 1f;
        line.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, -150);
        points.transform.GetChild(0).gameObject.SetActive(true);
        points.transform.GetChild(1).gameObject.SetActive(false);
        points.transform.GetChild(2).gameObject.SetActive(false);
        points.transform.GetChild(3).gameObject.SetActive(false);
        points.transform.GetChild(4).gameObject.SetActive(false);
        points.transform.GetChild(5).gameObject.SetActive(false);
        points.transform.GetChild(6).gameObject.SetActive(false);
        choices.SetActive(false);
        choices.transform.GetChild(0).gameObject.SetActive(false);
        choices.transform.GetChild(1).gameObject.SetActive(false);
        pointNum = 1;
        step = 0;
        isStart = false;
        isStop = false;
        result.text = "";
        shadow.SetActive(false);
    }
}
