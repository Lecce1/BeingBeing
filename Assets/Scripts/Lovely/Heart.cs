using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Heart : MonoBehaviour
{
    private bool isTouch;
    private int stage;
    private bool isPositive;
    Lovely_Manager lovely_Manager;
    WaitForSeconds waitForSeconds = new (0.01f);

    void Awake()
    {
        lovely_Manager = GameObject.Find("LovelyManager").GetComponent<Lovely_Manager>();
    }

    void Start()
    {
        stage = lovely_Manager.stage;
        
        if (lovely_Manager.stage == 5)
        {
            if (transform.GetChild(0).GetComponent<TextMeshProUGUI>().text == "고마워" ||
                transform.GetChild(0).GetComponent<TextMeshProUGUI>().text == "힘이나" ||
                transform.GetChild(0).GetComponent<TextMeshProUGUI>().text == "편안해" ||
                transform.GetChild(0).GetComponent<TextMeshProUGUI>().text == "기분이 좋아" ||
                transform.GetChild(0).GetComponent<TextMeshProUGUI>().text == "사랑해" ||
                transform.GetChild(0).GetComponent<TextMeshProUGUI>().text == "잘했어" ||
                transform.GetChild(0).GetComponent<TextMeshProUGUI>().text == "최고야")
            {
                isPositive = true;
            }
            else
            {
                isPositive = false;
            }
        }
    }

    void Update()
    {
        if (!isTouch)
        {
            transform.GetComponent<RectTransform>().anchoredPosition = new Vector2(transform.GetComponent<RectTransform>().anchoredPosition.x, transform.GetComponent<RectTransform>().anchoredPosition.y - (200f * Time.deltaTime));
        }
        else if (isTouch)
        {
            if (stage == 4)
            {
                transform.GetComponent<RectTransform>().anchoredPosition = Vector2.MoveTowards(transform.GetComponent<RectTransform>().anchoredPosition, new Vector2(0, -700), 1000 * Time.deltaTime);

                if (transform.GetComponent<RectTransform>().anchoredPosition.y == -700)
                {
                    lovely_Manager.BackGlow();
                    Destroy(gameObject);
                }
            }
            else if (stage == 5)
            {
                if (isPositive)
                {
                    transform.GetComponent<RectTransform>().anchoredPosition = Vector2.MoveTowards(transform.GetComponent<RectTransform>().anchoredPosition, new Vector2(0, -700), 1000 * Time.deltaTime);

                    if (transform.GetComponent<RectTransform>().anchoredPosition.y == -700)
                    {
                        lovely_Manager.BackGlow();
                        Destroy(gameObject);
                    }
                }
                else
                {
                    Destroy(gameObject);
                }
            }
        }

        if (lovely_Manager.stage == 5)
        {
            if (!isTouch && stage == 4)
            {
                Destroy(gameObject);
            }
        }

        if (lovely_Manager.fail.activeSelf)
        {
            Destroy(gameObject);
        }
    }

    public void Touch()
    {
        transform.GetComponent<Button>().enabled = false;
        lovely_Manager.heartNum++;
        isTouch = true;
        StartCoroutine("Touch2");
    }
    
    IEnumerator Touch2()
    {
        if (lovely_Manager.stage == 4)
        {
            while (lovely_Manager.bar.GetComponent<Slider>().value < lovely_Manager.heartNum * 0.03f)
            {
                lovely_Manager.bar.GetComponent<Slider>().value += 0.01f;
                yield return waitForSeconds;
            }

            if (lovely_Manager.bar.GetComponent<Slider>().value >= 0.7f)
            {
                lovely_Manager.stage = 5;
            }
        }
        else if (lovely_Manager.stage == 5)
        {
            if (isPositive)
            {
                if (DBManager.instance.currentStep == 1 || DBManager.instance.currentStep == 2)
                {
                    float fill = lovely_Manager.bar.GetComponent<Slider>().value;

                    if (fill + 0.1f <= 1)
                    {
                        while (lovely_Manager.bar.GetComponent<Slider>().value < fill + 0.1f)
                        {
                            lovely_Manager.bar.GetComponent<Slider>().value += 0.01f;
                            yield return waitForSeconds;
                        }
                    }
                    else if (fill + 0.1f > 1)
                    {
                        while (lovely_Manager.bar.GetComponent<Slider>().value < 1)
                        {
                            lovely_Manager.bar.GetComponent<Slider>().value += 0.01f;
                            yield return waitForSeconds;
                        }
                    }
                }
                else if (DBManager.instance.currentStep == 3)
                {
                    float fill = lovely_Manager.bar.GetComponent<Slider>().value;

                    if (fill + 0.05f <= 1)
                    {
                        while (lovely_Manager.bar.GetComponent<Slider>().value < fill + 0.05f)
                        {
                            lovely_Manager.bar.GetComponent<Slider>().value += 0.01f;
                            yield return waitForSeconds;
                        }
                    }
                    else if (fill + 0.05f > 1)
                    {
                        while (lovely_Manager.bar.GetComponent<Slider>().value < 1)
                        {
                            lovely_Manager.bar.GetComponent<Slider>().value += 0.01f;
                            yield return waitForSeconds;
                        }
                    }
                }
                
                if (lovely_Manager.bar.GetComponent<Slider>().value >= 1f)
                {
                    lovely_Manager.stage = 6;
                }
            }
            else if (!isPositive)
            {
                lovely_Manager.heart_Fail++;
                
                lovely_Manager.lifes[lovely_Manager.heart_Fail - 1].transform.GetChild(0).GetComponent<Image>().color = Color.white;

                if (DBManager.instance.currentStep == 1 || DBManager.instance.currentStep == 2)
                {
                    if (lovely_Manager.heart_Fail >= 2)
                    {
                        lovely_Manager.shadow.SetActive(true);
                        lovely_Manager.fail.SetActive(true);
                    }
                }
                else if (DBManager.instance.currentStep == 3)
                {
                    if (lovely_Manager.heart_Fail >= 3)
                    {
                        lovely_Manager.shadow.SetActive(true);
                        lovely_Manager.fail.SetActive(true);
                    }
                }
            }
        }
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!isTouch && other.name == "Line")
        {
            if (lovely_Manager.stage == 4)
            {
                lovely_Manager.heart_Fail++;
                lovely_Manager.lifes[lovely_Manager.heart_Fail - 1].transform.GetChild(0).GetComponent<Image>().color = Color.white;
                
                if (DBManager.instance.currentStep == 1 || DBManager.instance.currentStep == 2)
                {
                    if (lovely_Manager.heart_Fail >= 2)
                    {
                        lovely_Manager.shadow.SetActive(true);
                        lovely_Manager.fail.SetActive(true);
                    }
                }
                else if (DBManager.instance.currentStep == 3)
                {
                    if (lovely_Manager.heart_Fail >= 3)
                    {
                        lovely_Manager.shadow.SetActive(true);
                        lovely_Manager.fail.SetActive(true);
                    }
                }
            }
            else if (lovely_Manager.stage == 5)
            {
                if (isPositive)
                {
                    lovely_Manager.heart_Fail++;
                
                    lovely_Manager.lifes[lovely_Manager.heart_Fail - 1].transform.GetChild(0).GetComponent<Image>().color = Color.white;

                    if (DBManager.instance.currentStep == 1 || DBManager.instance.currentStep == 2)
                    {
                        if (lovely_Manager.heart_Fail >= 2)
                        {
                            lovely_Manager.shadow.SetActive(true);
                            lovely_Manager.fail.SetActive(true);
                        }
                    }
                    else if (DBManager.instance.currentStep == 3)
                    {
                        if (lovely_Manager.heart_Fail >= 3)
                        {
                            lovely_Manager.shadow.SetActive(true);
                            lovely_Manager.fail.SetActive(true);
                        }
                    }
                }
            }
            
            Destroy(gameObject);
        }
    }
}
