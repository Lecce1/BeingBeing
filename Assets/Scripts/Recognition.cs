using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Recognition : MonoBehaviour
{
    public GameObject finger;
    public GameObject line;
    public GameObject choices;
    public Text result = null;
    private int pointNum = 1;
    private int step = 0;
    private bool isStop = false;
    WaitForEndOfFrame waitForEndOfFrame = new WaitForEndOfFrame();

    void Update()
    {
        Cursor();
        Line();
    }

    void Cursor()
    {
        finger.transform.position = Input.mousePosition;

        if (Input.GetMouseButton(0))
        {
            finger.GetComponent<Image>().sprite = Resources.Load<Sprite>("Finger2");
        }
        else
        {
            finger.GetComponent<Image>().sprite = Resources.Load<Sprite>("Finger");
        }
    }

    void Line()
    {
        if (isStop == false)
        {
            line.transform.Translate(new Vector3(0, -100f, 0) * Time.deltaTime);
        }

        if (pointNum == 1 && line.GetComponent<RectTransform>().anchoredPosition.y <= 660)
        {
            pointNum++;
            isStop = true;
            Point();
        }
        else if (pointNum == 2 && line.GetComponent<RectTransform>().anchoredPosition.y <= 100)
        {
            pointNum++;
            isStop = true;
            Point();
        }
        else if (pointNum == 3 && line.GetComponent<RectTransform>().anchoredPosition.y <= -75)
        {
            pointNum++;
            isStop = true;
            Point();
        }
        else if (pointNum == 4 && line.GetComponent<RectTransform>().anchoredPosition.y <= -250)
        {
            pointNum++;
            isStop = true;
            Point();
        }
        else if (pointNum == 5 && line.GetComponent<RectTransform>().anchoredPosition.y <= -570)
        {
            pointNum++;
            isStop = true;
            Point();
        }
        else if (pointNum == 6 && line.GetComponent<RectTransform>().anchoredPosition.y <= -900)
        {
            isStop = true;
            result.gameObject.SetActive(true);
        }
    }

    void Point()
    {
        choices.SetActive(true);
        choices.transform.GetChild(0).gameObject.SetActive(true);
        choices.transform.GetChild(0).GetChild(0).GetChild(0).GetComponent<Text>().text = "편하다";
        choices.transform.GetChild(0).GetChild(1).GetChild(0).GetComponent<Text>().text = "불편하다";
        step = 1;
    }

    public void Choice(int choiceNum)
    {
        if (step == 1)
        {
            Result(choices.transform.GetChild(0).GetChild(choiceNum - 1).GetChild(0).GetComponent<Text>().text);

            if (choiceNum == 1)
            {
                choices.transform.GetChild(0).gameObject.SetActive(false);
                choices.transform.GetChild(1).gameObject.SetActive(true);
                choices.transform.GetChild(1).GetChild(0).GetChild(0).GetComponent<Text>().text = "상쾌하다";
                choices.transform.GetChild(1).GetChild(1).GetChild(0).GetComponent<Text>().text = "가볍다";
                choices.transform.GetChild(1).GetChild(2).GetChild(0).GetComponent<Text>().text = "시원하다";
                choices.transform.GetChild(1).GetChild(3).GetChild(0).GetComponent<Text>().text = "따뜻하다";
                choices.transform.GetChild(1).GetChild(4).GetChild(0).GetComponent<Text>().text = "편안하다";
            }
            else if (choiceNum == 2)
            {
                choices.transform.GetChild(0).gameObject.SetActive(false);
                choices.transform.GetChild(1).gameObject.SetActive(true);
                choices.transform.GetChild(1).GetChild(0).GetChild(0).GetComponent<Text>().text = "불쾌하다";
                choices.transform.GetChild(1).GetChild(1).GetChild(0).GetComponent<Text>().text = "무겁다";
                choices.transform.GetChild(1).GetChild(2).GetChild(0).GetComponent<Text>().text = "갑갑하다";
                choices.transform.GetChild(1).GetChild(3).GetChild(0).GetComponent<Text>().text = "차갑다";
                choices.transform.GetChild(1).GetChild(4).GetChild(0).GetComponent<Text>().text = "불편하다";
            }

            step = 2;
        }
        else if (step == 2)
        {
            Result(choices.transform.GetChild(1).GetChild(choiceNum - 1).GetChild(0).GetComponent<Text>().text);
            choices.transform.GetChild(1).GetChild(0).GetChild(0).GetComponent<Text>().text = "매우 그렇다";
            choices.transform.GetChild(1).GetChild(1).GetChild(0).GetComponent<Text>().text = "조금 그렇다";
            choices.transform.GetChild(1).GetChild(2).GetChild(0).GetComponent<Text>().text = "보통이다";
            choices.transform.GetChild(1).GetChild(3).GetChild(0).GetComponent<Text>().text = "조금 그렇지 않다";
            choices.transform.GetChild(1).GetChild(4).GetChild(0).GetComponent<Text>().text = "매우 그렇지 않다";
            step = 3;
        }
        else if (step == 3)
        {
            Result(choices.transform.GetChild(1).GetChild(choiceNum - 1).GetChild(0).GetComponent<Text>().text);
            choices.SetActive(false);
            choices.transform.GetChild(1).gameObject.SetActive(false);
            isStop = false;
        }
    }

    void Result(string data)
    {
        if (pointNum - 1 == 1)
        {
            if (step == 1)
            {
                result.text += $"머리 : {data}, ";
            }
        }
        else if (pointNum - 1 == 2)
        {
            if (step == 1)
            {
                result.text += $"목 : {data}, ";
            }
        }
        else if (pointNum - 1 == 3)
        {
            if (step == 1)
            {
                result.text += $"배 : {data}, ";
            }
        }
        else if (pointNum - 1 == 4)
        {
            if (step == 1)
            {
                result.text += $"손 : {data}, ";
            }
        }
        else if (pointNum - 1 == 5)
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
            result.text += $"{data}\n";
        }
    }
}
