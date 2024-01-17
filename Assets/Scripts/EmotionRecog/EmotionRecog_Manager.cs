using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class EmotionRecog_Manager : MonoBehaviour
{
    public GameObject tutorial;
    public Text tutorial_Notice;
    public GameObject tutorial_EmotionComingBtn;
    public GameObject tutorial_EmotionBtn;
    public GameObject tutorial_Character;
    public GameObject tutorial_EmotionColor;
    public GameObject tutorial_EmotionCloud;
    public GameObject tutorial_DragArea;
    public List<Sprite> emotionColor_Sprite;
    public GameObject game;
    public GameObject character;
    public GameObject character_Step1;
    public GameObject character_Step2;
    public GameObject character_Step3;
    public GameObject dragArea;
    public GameObject emotionTimer;
    public GameObject emotionBtn;
    public GameObject emotionColor;
    public GameObject emotionComingBtn;
    public GameObject emotionCloud;
    public GameObject shadow;
    public GameObject success;
    public GameObject fail;
    private string emotionFeel;
    private float emotionStartTime;
    [SerializeField]
    private float emotionTime;
    private bool isTimer;
    private bool isComing;
    private bool isCloud;
    private bool isFirstFill;
    private bool isDot;
    private bool isDot2;
    private bool isClick;
    public bool isNext;
    public int count;
    private float emotionColor_Fill;
    public bool isTutorial;
    private bool isTutorial_Check;
    private bool isTutorial_Check2;
    [SerializeField]
    private int tutorial_Notice_Num = 1;
    private List<string> cloud_Text = new List<string> {"너 때문이야", "다 부숴버릴거야", "잘못되면 끝이야", "다른 사람이 알면 큰일인데", "나 때문이야", "내가 원망스러워", "좋은 사람은 다 가버리네", "내 편은 아무도 없어"};
    public GameObject tutorial_Notice_Image;

    void Update()
    {
        Tutorial();
        EmotionTimer();
        EmotionColor();
        EmotionDot();
    }
    
    void Tutorial()
    {
        if (!isTutorial)
        {
            if (!isTutorial_Check)
            {
                isTutorial_Check = true;

                if (PlayerPrefs.GetInt("EmotionRecog_Tutorial") == 0)
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

                    if (tutorial_Notice_Num != 4)
                    {
                        Tutorial_Notice();
                    }
                }
            }
        }
        else if (isTutorial && !isTutorial_Check2)
        {
            isTutorial_Check2 = true;
            isComing = false;
            isCloud = false;
            isFirstFill = false;
            isDot = false;
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
        }
    }
    
    void Tutorial_Notice()
    {
        if (tutorial_Notice_Num == 1)
        {
            tutorial_Notice.text = "이제는 감정자각 연습을 시작합니다.";
            BGMManager.instance.PlayBGM("EmotionRecog_Tutorial_1");
            tutorial_Notice_Image.GetComponent<Animator>().Play("Text");
        }
        else if (tutorial_Notice_Num == 2)
        {
            tutorial_Notice.text = "사람이 경험하는 대표적인 감정은\n분노, 불안, 슬픔, 자책의 4가지 입니다.";
            BGMManager.instance.PlayBGM("EmotionRecog_Tutorial_2");
        }
        else if (tutorial_Notice_Num == 3)
        {
            tutorial_Notice_Image.SetActive(false);
            tutorial_Notice.text = "이 4가지 감정 중 하나를 선택해보세요.";
            BGMManager.instance.PlayBGM("EmotionRecog_Tutorial_3");
            tutorial_EmotionBtn.SetActive(true);
        }
    }

    public void Skip()
    {
        isTutorial = true;
        PlayerPrefs.SetInt("EmotionRecog_Tutorial", 1);
    }
    
    void EmotionTimer()
    {
        if (emotionTimer.activeSelf && !success.activeSelf)
        {
            emotionTime = Time.time - emotionStartTime;
            emotionTimer.transform.GetChild(0).GetComponent<Image>().fillAmount = emotionTime * (1f / 90f);

            if (emotionTime >= 70 && !isTimer)
            {
                isTimer = true;
                emotionTimer.GetComponent<Animator>().Play("Emotion_Timer");
            }
            
            if (emotionTimer.transform.GetChild(0).GetComponent<Image>().fillAmount == 1)
            {
                shadow.SetActive(true);
                fail.SetActive(true);
            }
        }
    }

    public void EmotionComingBtn()
    {
        if (!isTutorial)
        {
            tutorial_Notice.text = "";
            tutorial_EmotionComingBtn.SetActive(false);
            isComing = true;
            Invoke("EmotionComing", 3.0f);
        }
        else if (isTutorial)
        {
            emotionComingBtn.SetActive(false);
            isComing = true;
            Invoke("EmotionComing", 3.0f);
        }
    }
    
    void EmotionColor()
    {
        if (!isTutorial)
        {
            if (tutorial_EmotionColor.activeSelf)
            {
                if (!isComing)
                {
                    tutorial_EmotionColor.GetComponent<RectTransform>().localScale += new Vector3(0, 0.5f * Time.deltaTime, 0);
                    
                    if (tutorial_EmotionColor.GetComponent<RectTransform>().localScale.y >= 2.5f)
                    {
                        tutorial_EmotionComingBtn.SetActive(true);
                        tutorial_EmotionComingBtn.GetComponent<Animator>().Play("Emotion_Tutorial_Coming");
                        tutorial_Notice.text = "감정이 다 차오르기 전에\n“그분이 오셨네＂를 터치해주세요.";
                        BGMManager.instance.PlayBGM("EmotionRecog_Tutorial_4");
                    }

                    if (tutorial_EmotionColor.GetComponent<RectTransform>().localScale.y >= 5f)
                    {
                        isComing = true;
                    }
                }
                else if (isComing)
                {
                    if (isCloud)
                    {
                        if (tutorial_EmotionColor.GetComponent<RectTransform>().localScale.y > emotionColor_Fill)
                        {
                            tutorial_EmotionColor.GetComponent<RectTransform>().localScale += new Vector3(0, -1f * Time.deltaTime, 0);
                        }
                        else
                        {
                            isCloud = false;

                            if (!isFirstFill)
                            {
                                isFirstFill = true;
                                emotionColor_Fill *= (2f / 3f);
                            }
                            
                            if (tutorial_EmotionColor.GetComponent<RectTransform>().localScale.y > emotionColor_Fill)
                            {
                                tutorial_EmotionCloud.SetActive(true);
                            }
                            else if (tutorial_EmotionColor.GetComponent<RectTransform>().localScale.y <= emotionColor_Fill)
                            {
                                tutorial_Notice.text = "";
                                EmotionColor2();
                            }
                        }
                    }
                }
            }
        }
        else if (isTutorial)
        { 
            if (emotionColor.activeSelf)
            {
                if (!isComing)
                {
                    emotionColor.GetComponent<RectTransform>().localScale += new Vector3(0, 0.5f * Time.deltaTime, 0);
                    
                    if (emotionColor.GetComponent<RectTransform>().localScale.y >= 2.5f)
                    {
                        emotionComingBtn.SetActive(true);
                        emotionComingBtn.GetComponent<Animator>().Play("Emotion_Coming");
                    }

                    if (emotionColor.GetComponent<RectTransform>().localScale.y >= 5f)
                    {
                        isComing = true;
                        shadow.SetActive(true);
                        fail.SetActive(true);
                    }
                }
                else if (isComing)
                {
                    if (isCloud)
                    {
                        if (emotionColor.GetComponent<RectTransform>().localScale.y > emotionColor_Fill)
                        {
                            emotionColor.GetComponent<RectTransform>().localScale += new Vector3(0, -1f * Time.deltaTime, 0);
                        }
                        else
                        {
                            isCloud = false;
                            
                            if (!isFirstFill)
                            {
                                isFirstFill = true;
                                emotionColor_Fill *= (2f / 3f);
                            }
                            
                            if (emotionColor.GetComponent<RectTransform>().localScale.y > emotionColor_Fill)
                            {
                                emotionCloud.SetActive(true);
                            }
                            else if (emotionColor.GetComponent<RectTransform>().localScale.y <= emotionColor_Fill)
                            {
                                EmotionColor2();
                            }
                        }
                    }
                }
            }
        }
    }

    void EmotionColor2()
    {
        if (!isTutorial)
        {
            tutorial_Notice.text = "감정과 만들어내는 생각을 누르면\n감정이 줄어들고 가슴 부위에 머무르게 됩니다.\n아래 부위에 손가락을 대고\n가만히 감정의 느낌을 느껴주세요.";
            BGMManager.instance.PlayBGM("EmotionRecog_Tutorial_6");
            tutorial_DragArea.SetActive(true);
            isDot = true;
        }
        else if (isTutorial)
        {
            if (!isDot)
            {
                isDot = true;
                isClick = true;
                dragArea.SetActive(true);
                
                switch (DBManager.instance.currentStep)
                {
                    case 1:
                        dragArea.GetComponent<RectTransform>().anchoredPosition =
                            new Vector2(dragArea.GetComponent<RectTransform>().anchoredPosition.x, 150);
                        break;
                    case 2:
                        dragArea.GetComponent<RectTransform>().anchoredPosition =
                            new Vector2(dragArea.GetComponent<RectTransform>().anchoredPosition.x, 150);
                        break;
                    case 3:
                        dragArea.GetComponent<RectTransform>().anchoredPosition =
                            new Vector2(dragArea.GetComponent<RectTransform>().anchoredPosition.x, 300);
                        break;
                }
            }
            else if(isDot)
            {
                if (count >= 3)
                {
                    isDot2 = true;
                }

                isClick = true;
                
                dragArea.SetActive(true);
                
                switch (DBManager.instance.currentStep)
                {
                    case 1:
                        dragArea.GetComponent<RectTransform>().anchoredPosition =
                            new Vector2(dragArea.GetComponent<RectTransform>().anchoredPosition.x, 150);
                        break;
                    case 2:
                        dragArea.GetComponent<RectTransform>().anchoredPosition =
                            new Vector2(dragArea.GetComponent<RectTransform>().anchoredPosition.x, 150);
                        break;
                    case 3:
                        dragArea.GetComponent<RectTransform>().anchoredPosition =
                            new Vector2(dragArea.GetComponent<RectTransform>().anchoredPosition.x, 300);
                        break;
                }
            }
        }
    }

    void EmotionComing()
    {
        if (!isTutorial)
        {
            emotionColor_Fill = tutorial_EmotionColor.transform.localScale.y * (3f / 4f);
            tutorial_EmotionCloud.SetActive(true);

            switch (emotionFeel)
            {
                case "Anger":
                    tutorial_Notice.text = "여러 생각 중에\n분노를 만들어내는 생각을 2개 찾아서 터치해주세요.";
                    break;
                case "Unrest":
                    tutorial_Notice.text = "여러 생각 중에\n불안을 만들어내는 생각을 2개 찾아서 터치해주세요.";
                    break;
                case "Sadness":
                    tutorial_Notice.text = "여러 생각 중에\n슬픔을 만들어내는 생각을 2개 찾아서 터치해주세요.";
                    break;
                case "Remorse":
                    tutorial_Notice.text = "여러 생각 중에\n자책을 만들어내는 생각을 2개 찾아서 터치해주세요.";
                    break;
            }
            
            BGMManager.instance.PlayBGM("EmotionRecog_Tutorial_5");
            
        }
        else if (isTutorial)
        {
            emotionColor_Fill = emotionColor.transform.localScale.y * (3f / 4f);

            for (int i = 0; i < 8; i++)
            {
                int num = Random.Range(0, cloud_Text.Count);
       
                if (i <= 2)
                {
                    emotionCloud.transform.GetChild(0).GetChild(i).GetChild(1).GetChild(0).GetComponent<Text>().text = cloud_Text[num];
                    
                    if (cloud_Text[num] == "너 때문이야" || cloud_Text[num] == "다 부숴버릴거야")
                    {
                        emotionCloud.transform.GetChild(0).GetChild(i).GetComponent<Button>().onClick.AddListener(() => EmotionCloud("Anger"));
                    }
                    else if (cloud_Text[num] == "잘못되면 끝이야" || cloud_Text[num] == "다른 사람이 알면 큰일인데")
                    {
                        emotionCloud.transform.GetChild(0).GetChild(i).GetComponent<Button>().onClick.AddListener(() => EmotionCloud("Unrest"));
                    }
                    else if (cloud_Text[num] == "나 때문이야" || cloud_Text[num] == "내가 원망스러워")
                    {
                        emotionCloud.transform.GetChild(0).GetChild(i).GetComponent<Button>().onClick.AddListener(() => EmotionCloud("Remorse"));
                    }
                    else if (cloud_Text[num] == "좋은 사람은 다 가버리네" || cloud_Text[num] == "내 편은 아무도 없어")
                    {
                        emotionCloud.transform.GetChild(0).GetChild(i).GetComponent<Button>().onClick.AddListener(() => EmotionCloud("Sadness"));
                    }
                }
                else if (i >= 3 && i <=4)
                {
                    emotionCloud.transform.GetChild(1).GetChild(i-3).GetChild(1).GetChild(0).GetComponent<Text>().text = cloud_Text[num];
                    
                    if (cloud_Text[num] == "너 때문이야" || cloud_Text[num] == "다 부숴버릴거야")
                    {
                        emotionCloud.transform.GetChild(1).GetChild(i-3).GetComponent<Button>().onClick.AddListener(() => EmotionCloud("Anger"));
                    }
                    else if (cloud_Text[num] == "잘못되면 끝이야" || cloud_Text[num] == "다른 사람이 알면 큰일인데")
                    {
                        emotionCloud.transform.GetChild(1).GetChild(i-3).GetComponent<Button>().onClick.AddListener(() => EmotionCloud("Unrest"));
                    }
                    else if (cloud_Text[num] == "나 때문이야" || cloud_Text[num] == "내가 원망스러워")
                    {
                        emotionCloud.transform.GetChild(1).GetChild(i-3).GetComponent<Button>().onClick.AddListener(() => EmotionCloud("Remorse"));
                    }
                    else if (cloud_Text[num] == "좋은 사람은 다 가버리네" || cloud_Text[num] == "내 편은 아무도 없어")
                    {
                        emotionCloud.transform.GetChild(1).GetChild(i-3).GetComponent<Button>().onClick.AddListener(() => EmotionCloud("Sadness"));
                    }
                }
                else if (i >= 5)
                {
                    emotionCloud.transform.GetChild(2).GetChild(i-5).GetChild(1).GetChild(0).GetComponent<Text>().text = cloud_Text[num];
                    
                    if (cloud_Text[num] == "너 때문이야" || cloud_Text[num] == "다 부숴버릴거야")
                    {
                        emotionCloud.transform.GetChild(2).GetChild(i-5).GetComponent<Button>().onClick.AddListener(() => EmotionCloud("Anger"));
                    }
                    else if (cloud_Text[num] == "잘못되면 끝이야" || cloud_Text[num] == "다른 사람이 알면 큰일인데")
                    {
                        emotionCloud.transform.GetChild(2).GetChild(i-5).GetComponent<Button>().onClick.AddListener(() => EmotionCloud("Unrest"));
                    }
                    else if (cloud_Text[num] == "나 때문이야" || cloud_Text[num] == "내가 원망스러워")
                    {
                        emotionCloud.transform.GetChild(2).GetChild(i-5).GetComponent<Button>().onClick.AddListener(() => EmotionCloud("Remorse"));
                    }
                    else if (cloud_Text[num] == "좋은 사람은 다 가버리네" || cloud_Text[num] == "내 편은 아무도 없어")
                    {
                        emotionCloud.transform.GetChild(2).GetChild(i-5).GetComponent<Button>().onClick.AddListener(() => EmotionCloud("Sadness"));
                    }
                }

                cloud_Text.RemoveAt(num);
            }
            
            emotionCloud.SetActive(true);
        }
    }

    public void EmotionCloud(string type)
    {
        if (!isTutorial)
        {
            if (type == emotionFeel)
            {
                tutorial_EmotionCloud.SetActive(false);
                isCloud = true;
            }
        }
        else if (isTutorial)
        {
            if (type == emotionFeel)
            {
                emotionCloud.SetActive(false);
                isCloud = true;
            }
        }
        
        EventSystem.current.currentSelectedGameObject.SetActive(false);
    }

    void EmotionDot()
    {
        if (!isTutorial)
        {
            if (isDot && Input.GetMouseButton(0))
            {
                tutorial_EmotionColor.GetComponent<RectTransform>().localScale += new Vector3(0, -0.5f * Time.deltaTime, 0);
            
                if (tutorial_EmotionColor.GetComponent<RectTransform>().localScale.y <= 0f)
                {
                    tutorial_Notice.text = "잘 하셨습니다.\n감정자각 연습을 마칩니다.";
                    BGMManager.instance.PlayBGM("EmotionRecog_Tutorial_7");
                    Invoke("Skip", 3.0f);
                }
            }
        }
        else if (isTutorial)
        {
            if (isClick && isDot && Input.GetMouseButton(0))
            {
                emotionColor.GetComponent<RectTransform>().localScale += new Vector3(0, -0.5f * Time.deltaTime, 0);
            
                if (emotionColor.GetComponent<RectTransform>().localScale.y <= 0f)
                {
                    count++;
                    
                    if (!isDot2)
                    {
                        isClick = false;
                        isFirstFill = false;
                        character.SetActive(false);
                        emotionColor.SetActive(false);
                        emotionBtn.SetActive(true);
                        dragArea.SetActive(false);
                        emotionTimer.SetActive(false);
                    }
                    else if (isDot2)
                    {
                        isDot = false;
                        isDot2 = false;
                        isNext = true;
                        DBManager.instance.refresh_PrevStage = "EmotionRecog";
                        DBManager.instance.currentStage = "Refresh";
                        SceneManager.LoadScene("Loading");
                    }
                }
            }
        }
    }

    public void BtnCheck(string type)
    {
        if (!isTutorial)
        {
            if (type == "Anger")
            {
                emotionFeel = "Anger";
                tutorial_EmotionColor.GetComponent<Image>().sprite = emotionColor_Sprite[0];
                tutorial_EmotionBtn.transform.GetChild(0).GetComponent<Button>().interactable = false;
                tutorial_EmotionBtn.transform.GetChild(0).GetChild(1).GetComponent<Image>().color = new Color(255, 255, 255, 0.3f);
            }
            else if (type == "Unrest")
            {
                emotionFeel = "Unrest";
                tutorial_EmotionColor.GetComponent<Image>().sprite = emotionColor_Sprite[1];
                tutorial_EmotionBtn.transform.GetChild(1).GetComponent<Button>().interactable = false;
                tutorial_EmotionBtn.transform.GetChild(1).GetChild(1).GetComponent<Image>().color =
                    new Color(255, 255, 255, 0.3f);
                
            }
            else if (type == "Sadness")
            {
                emotionFeel = "Sadness";
                tutorial_EmotionColor.GetComponent<Image>().sprite = emotionColor_Sprite[2];
                tutorial_EmotionBtn.transform.GetChild(2).GetComponent<Button>().interactable = false;
                tutorial_EmotionBtn.transform.GetChild(2).GetChild(1).GetComponent<Image>().color =
                    new Color(255, 255, 255, 0.3f);
            }
            else if (type == "Remorse")
            {
                emotionFeel = "Remorse";
                tutorial_EmotionColor.GetComponent<Image>().sprite = emotionColor_Sprite[3];
                tutorial_EmotionBtn.transform.GetChild(3).GetComponent<Button>().interactable = false;
                tutorial_EmotionBtn.transform.GetChild(3).GetChild(1).GetComponent<Image>().color =
                    new Color(255, 255, 255, 0.3f);
            }
        }
        else if (isTutorial)
        {
            if (type == "Anger")
            {
                emotionFeel = "Anger";
                emotionColor.GetComponent<Image>().sprite = emotionColor_Sprite[0];
                emotionBtn.transform.GetChild(0).GetComponent<Button>().interactable = false;
                emotionBtn.transform.GetChild(0).GetChild(1).GetComponent<Image>().color =
                    new Color(255, 255, 255, 0.3f);
            }
            else if (type == "Unrest")
            {
                emotionFeel = "Unrest";
                emotionColor.GetComponent<Image>().sprite = emotionColor_Sprite[1];
                emotionBtn.transform.GetChild(1).GetComponent<Button>().interactable = false;
                emotionBtn.transform.GetChild(1).GetChild(1).GetComponent<Image>().color =
                    new Color(255, 255, 255, 0.3f);
            }
            else if (type == "Sadness")
            {
                emotionFeel = "Sadness";
                emotionColor.GetComponent<Image>().sprite = emotionColor_Sprite[2];
                emotionBtn.transform.GetChild(2).GetComponent<Button>().interactable = false;
                emotionBtn.transform.GetChild(2).GetChild(1).GetComponent<Image>().color =
                    new Color(255, 255, 255, 0.3f);
            }
            else if (type == "Remorse")
            {
                emotionFeel = "Remorse";
                emotionColor.GetComponent<Image>().sprite = emotionColor_Sprite[3];
                emotionBtn.transform.GetChild(3).GetComponent<Button>().interactable = false;
                emotionBtn.transform.GetChild(3).GetChild(1).GetComponent<Image>().color =
                    new Color(255, 255, 255, 0.3f);
            }
        }
        
        Invoke("BtnCheck2", 0.5f);
    }
    
    void BtnCheck2()
    {
        if (!isTutorial)
        {
            if (!isDot)
            {
                tutorial_Notice.text = "빙빙이에게 감정이 점점 차오르고 있어요.";
                tutorial_EmotionBtn.SetActive(false);
                tutorial_Character.SetActive(true);
                tutorial_EmotionColor.SetActive(true);
            }
            else if (isDot)
            {
                tutorial_EmotionBtn.SetActive(false);
                tutorial_Character.SetActive(true);
                tutorial_EmotionColor.SetActive(true);
                StartCoroutine("EmotionColor2");
            }
        }
        else if (isTutorial)
        {
            if (!isDot)
            {
                emotionStartTime = Time.time;
                emotionTimer.SetActive(true);
                emotionBtn.SetActive(false);
                character.SetActive(true);
                emotionColor.SetActive(true); 
            }
            else if (isDot)
            {
                emotionStartTime = Time.time;
                emotionTimer.SetActive(true);
                isComing = false;
                isCloud = false;
                cloud_Text = new List<string> {"너 때문이야", "다 부숴버릴거야", "잘못되면 끝이야", "다른 사람이 알면 큰일인데", "나 때문이야", "내가 원망스러워", "좋은 사람은 다 가버리네", "내 편은 아무도 없어"};
                emotionCloud.transform.GetChild(0).GetChild(0).gameObject.SetActive(true);
                emotionCloud.transform.GetChild(0).GetChild(1).gameObject.SetActive(true);
                emotionCloud.transform.GetChild(0).GetChild(2).gameObject.SetActive(true);
                emotionCloud.transform.GetChild(1).GetChild(0).gameObject.SetActive(true);
                emotionCloud.transform.GetChild(1).GetChild(1).gameObject.SetActive(true);
                emotionCloud.transform.GetChild(2).GetChild(0).gameObject.SetActive(true);
                emotionCloud.transform.GetChild(2).GetChild(1).gameObject.SetActive(true);
                emotionCloud.transform.GetChild(2).GetChild(2).gameObject.SetActive(true);
                emotionBtn.SetActive(false);
                character.SetActive(true);
                emotionColor.SetActive(true);
            }
        }
    }

    public void Next()
    {
        if (success.activeSelf)
        {
            var animator = success.GetComponent<Animator>();
            animator.Play("Close");
        }
        else if (fail.activeSelf)
        {
            var animator = fail.GetComponent<Animator>();
            animator.Play("Close");
        }
        
        Invoke("Success_Fail_Close", 0.5f);
    }

    public void Restart()
    {
        DBManager.instance.currentStage = "EmotionRecog";
        SceneManager.LoadScene("Loading");
    }

    void Success_Fail_Close()
    {
        if (success.activeSelf)
        {
            success.SetActive(false);
        }
        else if (fail.activeSelf)
        {
            fail.SetActive(false);
        }
        
        DBManager.instance.currentStage = "Main";
        SceneManager.LoadScene("Loading");
    }
}
