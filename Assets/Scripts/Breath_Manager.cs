using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Breath_Manager : MonoBehaviour
{
    public GameObject fade;
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
    Anim_Manager anim_Manager;

    void Awake()
    {
        anim_Manager = GameObject.Find("Anim_Manager").GetComponent<Anim_Manager>();
        anim_Manager.Fade_In();
    }

    void Update()
    {
        Cursor();
        Breathe();
        Gauge();
        Timer();
    }

    void Cursor()
    {
        if (Input.mousePosition.x > 300 && Input.mousePosition.x < 900 && Input.mousePosition.y > 850 && Input.mousePosition.y < 1650 && gameObject.GetComponent<Touch>().result == Result.up && isLimit == false)
        {
            isUp = true;
            gameObject.GetComponent<Touch>().result = Result.none;
        }
        else if (Input.mousePosition.x > 300 && Input.mousePosition.x < 900 && Input.mousePosition.y > 850 && Input.mousePosition.y < 1650 && gameObject.GetComponent<Touch>().result == Result.down && isLimit == false && isBreathe == true)
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
            circle.fillAmount += 0.5f * Time.deltaTime;
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
        else if (isDown == true && isLimit == false && isBreathe == true)
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
                body.transform.localScale += new Vector3(1f, 1f, 0) * Time.deltaTime;
            }
        }
        else if (isBreathe == false)
        {
            while (body.transform.localScale.x > 1)
            {
                yield return waitForEndOfFrame;
                body.transform.localScale -= new Vector3(1f, 1f, 0) * Time.deltaTime;
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

    public void Back()
    {
        anim_Manager.Fade_Out();
    }

    public void Next()
    {
        SceneManager.LoadScene("Smile");
    }
}
