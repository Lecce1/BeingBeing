using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Smile_Manager : MonoBehaviour
{
    public GameObject fade;
    public GameObject backGlow;
    public GameObject mouse;
    public Text timer;
    public Text number;
    public float time = 0;
    public int num = 0;
    public bool isLeftUp = false;
    public bool isRightUp = false;
    public bool isSmile = false;
    public bool isNum = false;
    WaitForEndOfFrame waitForEndOfFrame = new WaitForEndOfFrame();
    Anim_Manager anim_Manager;

    void Awake()
    {
        anim_Manager = GameObject.Find("Anim_Manager").GetComponent<Anim_Manager>();
        anim_Manager.Fade_In();
    }

    void Update()
    {
        Cursor();
        Mouse();
        Timer();
    }

    void Cursor()
    {
        if (Input.mousePosition.x < 590 && Input.mousePosition.y > 1300 && gameObject.GetComponent<Touch>().result == Result.up)
        {
            time = 0;
            isLeftUp = true;
            gameObject.GetComponent<Touch>().result = Result.none;
        }
        else if (Input.mousePosition.x > 590 && Input.mousePosition.y > 1300 && gameObject.GetComponent<Touch>().result == Result.up)
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
            mouse.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("mouse");
            isSmile = false;
        }
        else if (isLeftUp == true && isRightUp == false)
        {
            mouse.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("mouse2");
            isSmile = false;
        }
        else if (isLeftUp == false && isRightUp == true)
        {
            mouse.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("mouse3");
            isSmile = false;
        }
        else if (isLeftUp == true && isRightUp == true && isNum == false)
        {
            mouse.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("mouse4");
            isSmile = true;
            isNum = true;
            num++;
            anim_Manager.BackGlow();
        }
    }

    void Timer()
    {
        time += Time.deltaTime;
        timer.text = "Time : " + time.ToString("0");
        number.text = "Number : " + num;

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
    
    public void Back()
    {
        anim_Manager.Fade_Out();
    }
}
