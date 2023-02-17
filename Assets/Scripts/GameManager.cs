using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject finger;
    public Image circle;
    public Text timer;
    private int count = 0;
    private float time = 0;
    private bool isLimit = false;
    private bool isUp = false;
    private bool isDown = false;
    WaitForEndOfFrame waitForEndOfFrame = new WaitForEndOfFrame();

    void Update()
    {
        Cursor();
        Gauge();
        Timer();
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

        if (gameObject.GetComponent<Touch>().result == Result.up)
        {
            isUp = true;
            gameObject.GetComponent<Touch>().result = Result.none;
        }
        else if (gameObject.GetComponent<Touch>().result == Result.down)
        {
            isDown = true;
            gameObject.GetComponent<Touch>().result = Result.none;
        }
    }

    void Gauge()
    {
        if (isUp == true && isDown == true && isLimit == false)
        {
            isUp = false;
            isDown = false;
            isLimit = true;
            time = 0;

            if (count <= 10)
            {
                count++;
            }

            StartCoroutine(Gauge2());
        }
    }

    void Timer()
    {
        time += Time.deltaTime;
        timer.text = $"Time : " + time.ToString("0");

        if (time >= 4)
        {
            time = 0;
            isUp = false;
            isDown = false;
            isLimit = false;
        }
    }

    IEnumerator Gauge2()
    {
        while (circle.fillAmount < (count * 0.1f))
        {
            yield return waitForEndOfFrame;
            circle.fillAmount += 0.0005f;
        }

        yield return null;
    }
}
