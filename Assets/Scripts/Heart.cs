using System;
using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Heart : MonoBehaviour
{
    private bool isTouch = false;
    private int stage;
    private bool isPositive = false;
    Lovely_Manager lovely_Manager;
    GameManager gameManager;
    AnimManager animManager;
    WaitForSeconds waitForSeconds = new WaitForSeconds(0.01f);

    void Awake()
    {
        lovely_Manager = GameObject.Find("Lovely_Manager").GetComponent<Lovely_Manager>();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        animManager = GameObject.Find("AnimManager").GetComponent<AnimManager>();
    }

    void Start()
    {
        stage = lovely_Manager.stage;
    }

    void Update()
    {
        if (isTouch == false)
        {
            transform.GetComponent<RectTransform>().anchoredPosition = new Vector2(transform.GetComponent<RectTransform>().anchoredPosition.x, transform.GetComponent<RectTransform>().anchoredPosition.y - (200f * Time.deltaTime));
        }
        else if (isTouch == true)
        {
            if (stage == 4)
            {
                transform.GetComponent<RectTransform>().anchoredPosition = Vector2.MoveTowards(transform.GetComponent<RectTransform>().anchoredPosition, new Vector2(0, -700), 1000 * Time.deltaTime);

                if (transform.GetComponent<RectTransform>().anchoredPosition.y == -700)
                {
                    animManager.Lovely_BackGlow();
                    Destroy(gameObject);
                }
            }
            else if (stage == 5)
            {
                if (isPositive == true)
                {
                    transform.GetComponent<RectTransform>().anchoredPosition = Vector2.MoveTowards(transform.GetComponent<RectTransform>().anchoredPosition, new Vector2(0, -700), 1000 * Time.deltaTime);

                    if (transform.GetComponent<RectTransform>().anchoredPosition.y == -700)
                    {
                        animManager.Lovely_BackGlow();
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
            if (isTouch == false && stage == 4)
            {
                Destroy(gameObject);
            }
        }
    }

    public void Touch()
    {
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
            if (isPositive == true)
            {
                if (gameManager.stage_Select_Level_Num == 1 || gameManager.stage_Select_Level_Num == 2)
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
                else if (gameManager.stage_Select_Level_Num == 3)
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
            else if (isPositive == false)
            {
                lovely_Manager.heart_Fail++;

                if (gameManager.stage_Select_Level_Num == 1 || gameManager.stage_Select_Level_Num == 2)
                {
                    if (lovely_Manager.heart_Fail >= 2)
                    {
                        lovely_Manager.fail.SetActive(true);
                    }
                }
                else if (gameManager.stage_Select_Level_Num == 3)
                {
                    if (lovely_Manager.heart_Fail >= 3)
                    {
                        lovely_Manager.fail.SetActive(true);
                    }
                }
            }
        }
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (isTouch == false && other.name == "Head")
        {
            Destroy(gameObject);
        }
    }
}
