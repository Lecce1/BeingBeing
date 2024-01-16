using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Breath_Manager : MonoBehaviour
{
    public GameObject tutorial;
    public Text tutorial_Notice;
    public GameObject tutorial_Finger;
    public GameObject tutorial_Character_Panel;
    public GameObject tutorial_Character_Step1;
    public Image tutorial_Circle;
    public Image tutorial_Circle_Timer;
    public GameObject character_Step1;
    public GameObject character_Step2;
    public GameObject character_Step3;
    public GameObject game;
    public GameObject game_Notice;
    public GameObject finger;
    public Image circle;
    public Image circle_Timer;
    [SerializeField]
    private int count;
    public float time;
    public bool isLimit;
    public bool isUp;
    public bool isDown;
    public bool isBreathe;
    public bool isNext;
    public bool isCheck;
    WaitForSeconds waitForSeconds = new (0.01f);
    public bool isTutorial;
    private bool isTutorial_Check;
    private bool isTutorial_Check2;
    private int tutorial_Notice_Num = 1;
    public bool isTouch;
    public GameObject fade;
    public GameObject tutorial_Notice_Image;
    private bool isFirst;

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
        if (!isTutorial)
        {
            if (!isTutorial_Check)
            {
                isTutorial_Check = true;

                if (PlayerPrefs.GetInt("Breath_Tutorial") == 0)
                {
                    isTutorial = false;
                    Tutorial_Notice();
                }
                else
                {
                    isTutorial = true;
                }
            }
            else
            {
                if (Input.GetMouseButtonUp(0))
                {
                    tutorial_Notice_Num++;

                    if (tutorial_Notice_Num != 6)
                    {
                        Tutorial_Notice();
                    }
                }
            }
        }
        else if (isTutorial && !isTutorial_Check2)
        {
            tutorial_Circle.fillAmount = 0;
            count = 0;
            isTutorial_Check2 = true;
            isUp = false;
            isDown = false;
            isBreathe = false;
            isTouch = false;
            isLimit = false;
            tutorial.SetActive(false);
            game.SetActive(true);

            if (DBManager.instance.currentStep == 1)
            {
                character_Step1.SetActive(true);
            }
            else if (DBManager.instance.currentStep == 2)
            {
                character_Step2.SetActive(true);
            }
            else if (DBManager.instance.currentStep == 3)
            {
                character_Step3.SetActive(true);
            }
            
            Invoke(nameof(First_Text), 5f);
        }
    }

    void First_Text()
    {
        if (game_Notice.GetComponent<Text>().text == "소리를 켜서 안내말을 따라해 주세요.")
        {
            game_Notice.GetComponent<Text>().text = "숨을 들이쉬고";
        }
        
        finger.SetActive(true);
        finger.GetComponent<Animator>().Play("Breath_Finger");
    }

    void Tutorial_Notice()
    {
        if (tutorial_Notice_Num == 1)
        {
            tutorial_Notice.text = "안녕하세요.\n호흡 연습을 시작합니다.";
            tutorial_Notice_Image.GetComponent<Animator>().Play("Text");
        }
        else if (tutorial_Notice_Num == 2)
        {
            tutorial_Notice.text = "숨을 들이쉴 때와\n숨을 내쉴 때의 느낌을\n알고 계신가요?";
        }
        else if (tutorial_Notice_Num == 3)
        {
            tutorial_Notice.text = "숨을 들이쉬고 내쉴 때의 느낌에\n주의를 기울이며\n호흡을 함께 진행봅시다.";
        }
        else if (tutorial_Notice_Num == 4)
        {
            tutorial_Notice.text = "숨을 들이쉬면서 2초\n내쉬면서 2초\n한 호흡은 4초 동안 진행됩니다.";
        }
        else if (tutorial_Notice_Num == 5)
        {
            tutorial_Notice_Image.SetActive(false);
            tutorial_Character_Panel.SetActive(true);
            tutorial_Finger.SetActive(true);
            tutorial_Finger.GetComponent<Animator>().Play("Breath_Finger");
            tutorial_Notice.text = "당신도 빙빙이와 함께\n숨을 들이쉬면서 가슴에서 배로\n손가락을 드래그 합니다.";
            isDown = false;
            isUp = false;
        }
    }

    public void Skip()
    {
        isTutorial = true;
        PlayerPrefs.SetInt("Breath_Tutorial", 1);
    }

    void Cursor()
    {
        if (!isTouch)
        {
            if (!isBreathe && gameObject.GetComponent<Touch>().result == Result.down && !isLimit)
            {
                isDown = true;
                gameObject.GetComponent<Touch>().result = Result.none;
            }
            else if (isBreathe && gameObject.GetComponent<Touch>().result == Result.up && !isLimit)
            {
                isUp = true;
                gameObject.GetComponent<Touch>().result = Result.none;
            }
            else if (isLimit)
            {
                gameObject.GetComponent<Touch>().result = Result.none;
            }
        }
    }
    
    void Breathe()
    {
        if (!isTutorial && tutorial_Notice_Num >= 5)
        {
            if (isDown && !isLimit && !isBreathe)
            {
                isBreathe = true;
                isTouch = true;
                StartCoroutine(Gauge2());
                StartCoroutine(Breathe2());
            }
            else if (isUp && !isLimit && isBreathe)
            {
                isBreathe = false;
                isTouch = true;
                StartCoroutine(Gauge2());
                StartCoroutine(Breathe2());
            }
        }
        else if (isTutorial)
        {
            if (isDown && !isLimit && !isBreathe)
            {
                isBreathe = true;
                isTouch = true;
                StartCoroutine(Gauge2());
                StartCoroutine(Breathe2());
            }
            else if (isUp && !isLimit && isBreathe)
            {
                isBreathe = false;
                isTouch = true;
                StartCoroutine(Gauge2());
                StartCoroutine(Breathe2());
            }
        }
    }

    IEnumerator Breathe2()
    {
        if (!isTutorial)
        {
            if (isBreathe)
            {
                if (!isFirst)
                {
                    tutorial_Notice.text = "잘했어요!";
                    tutorial_Finger.SetActive(false);
                }
                else
                {
                    tutorial_Notice.text = String.Empty;
                }

                tutorial_Character_Step1.GetComponent<Animator>().Play("Breath_Step1_1");

                while (tutorial_Circle_Timer.fillAmount < 0.95f)
                {
                    yield return null;
                }

                if (!isFirst)
                {
                    tutorial_Notice.text = "이번에는 빙빙이와 함께\n숨을 내쉬면서 배에서 가슴으로\n드래그 합니다.";
                    tutorial_Finger.SetActive(true);
                    tutorial_Finger.GetComponent<Animator>().Play("Breath_Finger2");
                }
                else if(tutorial_Circle.fillAmount != 1)
                {
                    tutorial_Notice.text = "내쉬고";
                }

                isTouch = false;
            }
            else if (!isBreathe)
            {
                if (!isFirst)
                {
                    isFirst = true;
                    tutorial_Notice.text = "잘 하셨습니다.";
                    tutorial_Finger.SetActive(false);
                }
                else
                {
                    tutorial_Notice.text = String.Empty;
                }

                tutorial_Character_Step1.GetComponent<Animator>().Play("Breath_Step1_2");
                
                while (tutorial_Circle_Timer.fillAmount < 0.95f)
                {
                    yield return null;
                }
                
                if(tutorial_Circle.fillAmount != 1)
                {
                    tutorial_Notice.text = "숨을 들이쉬고";
                }

                isTouch = false;
            }
        }
        else if (isTutorial)
        {
            if (isBreathe)
            {
                finger.SetActive(false);
                game_Notice.GetComponent<Text>().text = string.Empty;
                
                if (DBManager.instance.currentStep == 1)
                {
                    character_Step1.GetComponent<Animator>().Play("Breath_Step1_1");
                }
                else if (DBManager.instance.currentStep == 2)
                {
                    character_Step2.GetComponent<Animator>().Play("Breath_Step2_1");
                }
                else if (DBManager.instance.currentStep == 3)
                {
                    character_Step3.GetComponent<Animator>().Play("Breath_Step3_1");
                }

                while (circle_Timer.fillAmount < 0.95f)
                {
                    yield return null;
                }

                if (circle.fillAmount != 1)
                {
                    game_Notice.GetComponent<Text>().text = "내쉬고";
                    finger.SetActive(true);
                    finger.GetComponent<Animator>().Play("Breath_Finger2");
                }

                isTouch = false;
            }
            else if (!isBreathe)
            {
                finger.SetActive(false);
                game_Notice.GetComponent<Text>().text = string.Empty;
                
                if (DBManager.instance.currentStep == 1)
                {
                    character_Step1.GetComponent<Animator>().Play("Breath_Step1_2");
                }
                else if (DBManager.instance.currentStep == 2)
                {
                    character_Step2.GetComponent<Animator>().Play("Breath_Step2_2");
                }
                else if (DBManager.instance.currentStep == 3)
                {
                    character_Step3.GetComponent<Animator>().Play("Breath_Step3_2");
                }

                while (circle_Timer.fillAmount < 0.95f)
                {
                    yield return null;
                }

                if (circle.fillAmount != 1)
                {
                    game_Notice.GetComponent<Text>().text = "숨을 들이쉬고";
                    finger.SetActive(true);
                    finger.GetComponent<Animator>().Play("Breath_Finger");
                }

                isTouch = false;
            }
        }
        
        yield return null;
    }

    void Gauge()
    {
        if ((isUp || isDown) && !isLimit)
        {
            time = 0;
            isUp = false;
            isDown = false;
            isLimit = true;
        }
    }

    IEnumerator Gauge2()
    {
        isCheck = false;
        
        if (!isTutorial && tutorial_Notice_Num >= 5)
        {
            if (count <= 6)
            {
                count++;
            }
        
            while (tutorial_Circle.fillAmount < (count * 0.167f))
            {
                yield return waitForSeconds;
                tutorial_Circle.fillAmount += 0.5f * Time.deltaTime;
                
                if (tutorial_Circle.fillAmount == 1)
                {
                    break;
                }
            }
            
            if (tutorial_Circle.fillAmount == 1)
            {
                tutorial_Notice.text = "잘 하셨습니다. 호흡 연습을 마칩니다.";
                Invoke(nameof(Skip), 4.0f);
            }
        }    
        else if (isTutorial)
        {
            if (DBManager.instance.currentStep == 1)
            {
                if (count < 10)
                {
                    count++;
                }
        
                while (circle.fillAmount < (count * 0.1f))
                {
                    yield return waitForSeconds;
                    circle.fillAmount += 0.5f * Time.deltaTime;

                    if (circle.fillAmount == 1)
                    {
                        isNext = true;
                        game_Notice.GetComponent<Text>().text = string.Empty;
                        break;
                    }
                }
            }
            else if (DBManager.instance.currentStep == 2)
            {
                if (count < 14)
                {
                    count++;
                }
        
                while (circle.fillAmount < (count * 0.07142857f))
                {
                    yield return waitForSeconds;
                    circle.fillAmount += 0.5f * Time.deltaTime;
                    
                    if (circle.fillAmount == 1)
                    {
                        isNext = true;
                        game_Notice.GetComponent<Text>().text = string.Empty;
                        break;
                    }
                }
            }
            else if (DBManager.instance.currentStep == 3)
            {
                if (count < 20)
                {
                    count++;
                }
        
                while (circle.fillAmount < (count * 0.05f))
                {
                    yield return waitForSeconds;
                    circle.fillAmount += 0.5f * Time.deltaTime;
                    
                    if (circle.fillAmount == 1)
                    {
                        isNext = true;
                        game_Notice.GetComponent<Text>().text = string.Empty;
                        break;
                    }
                }
            }

            if (circle.fillAmount == 1)
            {
                isNext = true;
                game_Notice.GetComponent<Text>().text = string.Empty;
            }
        }

        isCheck = true;
        
        yield return null;
    }

    IEnumerator FadeOut()
    {
        fade.SetActive(true);
        float timer = 0;

        while (timer < 255)
        {
            timer += 500 * Time.deltaTime;
            fade.GetComponent<Image>().color = new Color(0, 0, 0, timer / 255f);
            Debug.Log("timer + " + timer);
            yield return waitForSeconds;
        }
        
        DBManager.instance.currentStage = "Smile";
        SceneManager.LoadScene("Loading");
    }

    void Timer()
    {
        if (!isTutorial)
        {
            if (isLimit && isCheck && tutorial_Circle.fillAmount != 1)
            {
                time += Time.deltaTime;
                tutorial_Circle_Timer.fillAmount = time / 2;
            }
            
            if (time >= 2)
            {
                tutorial_Circle_Timer.fillAmount = 0;
                time = 0;
                isLimit = false;
            }
        }
        else if (isTutorial)
        {
            if (isLimit && isCheck)
            {
                time += Time.deltaTime;
                circle_Timer.fillAmount = time / 2;
            }
            
            if (time >= 2)
            {
                circle_Timer.fillAmount = 0;
                time = 0;
                isLimit = false;
                
                if (isNext)
                {
                    StartCoroutine(nameof(FadeOut));
                }
            }
        }
    }
}
