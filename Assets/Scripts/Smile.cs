using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Smile : MonoBehaviour
{
    public GameObject finger;
    public GameObject mouse;
    public Text timer;
    private float time = 0;
    private bool isLeftUp = false;
    private bool isRightUp = false;
    public bool isSmile = false;
    WaitForEndOfFrame waitForEndOfFrame = new WaitForEndOfFrame();

    void Update()
    {
        Cursor();
        Mouse();
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

        if (Input.mousePosition.x < 590 && Input.mousePosition.y > 1300 && gameObject.GetComponent<Touch>().result == Result.up)
        {
            isLeftUp = true;
            gameObject.GetComponent<Touch>().result = Result.none;
        }
        else if (Input.mousePosition.x < 590 && Input.mousePosition.y > 1300 && gameObject.GetComponent<Touch>().result == Result.down)
        {
            isLeftUp = false;
            gameObject.GetComponent<Touch>().result = Result.none;
        }
        else if (Input.mousePosition.x > 590 && Input.mousePosition.y > 1300 && gameObject.GetComponent<Touch>().result == Result.up)
        {
            isRightUp = true;
            gameObject.GetComponent<Touch>().result = Result.none;
        }
        else if (Input.mousePosition.x > 590 && Input.mousePosition.y > 1300 && gameObject.GetComponent<Touch>().result == Result.down)
        {
            isRightUp = false;
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
        else if (isLeftUp == true && isRightUp == true)
        {
            mouse.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>("mouse4");
            isSmile = true;
        }
    }

    void Timer()
    {
        time += Time.deltaTime;
        timer.text = $"Time : " + time.ToString("0");

        if (time >= 4)
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
