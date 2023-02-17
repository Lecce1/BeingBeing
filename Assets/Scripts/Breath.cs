using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Breath : MonoBehaviour
{
    public GameObject finger;
    public GameObject body;
    public Image circle;
    public Text timer;
    private int count = 0;
    private float time = 0;
    private bool isLimit = false;
    private bool isUp = false;
    private bool isDown = false;
    private bool isBreathe = false;
    WaitForEndOfFrame waitForEndOfFrame = new WaitForEndOfFrame();

    void Update()
    {
        Cursor();
        Breathe();
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

        if (gameObject.GetComponent<Touch>().result == Result.up && isLimit == false)
        {
            isUp = true;
            gameObject.GetComponent<Touch>().result = Result.none;
        }
        else if (gameObject.GetComponent<Touch>().result == Result.down && isLimit == false && isBreathe == true)
        {
            isDown = true;
            gameObject.GetComponent<Touch>().result = Result.none;
        }
        else if (isLimit == true)
        {
            gameObject.GetComponent<Touch>().result = Result.none;
        }
    }

    void Gauge()
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

    IEnumerator Gauge2()
    {
        while (circle.fillAmount < (count * 0.1f))
        {
            yield return waitForEndOfFrame;
            circle.fillAmount += 0.0005f;
        }

        yield return null;
    }

    void Breathe()
    {
        if (isUp == true && isLimit == false && isBreathe == false)
        {
            isBreathe = true;
            StartCoroutine(Breathe2());
        }
        else if (isDown == true && isBreathe == true)
        {
            isBreathe = false;
            StartCoroutine(Breathe2());
        }
    }

    IEnumerator Breathe2()
    {
        if (isBreathe == true)
        {
            while (body.transform.localScale.x < 1.2f)
            {
                yield return waitForEndOfFrame;
                body.transform.localScale += new Vector3(0.001f, 0.001f, 0);
            }
        }
        else if (isBreathe == false)
        {
            while (body.transform.localScale.x > 1)
            {
                yield return waitForEndOfFrame;
                body.transform.localScale -= new Vector3(0.001f, 0.001f, 0);
            }
        }

        yield return null;
    }

    void Timer()
    {
        time += Time.deltaTime;
        timer.text = $"Time : " + time.ToString("0");

        if (time >= 4)
        {
            time = 0;
            isLimit = false;
        }
    }
}
