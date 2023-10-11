using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class Decent_Manager : MonoBehaviour
{
    public Image background;
    public Sprite main_Background;
    public GameObject blur;
    public GameObject tutorial;
    public Text tutorial_Notice;
    public GameObject tutorial_True;
    public GameObject tutorial_Interpret;
    public GameObject tutorial_Sentence;
    public GameObject sentence;
    public GameObject game;
    public GameObject stage1;
    public Image stage1_cutToon;
    public GameObject stage1_Notice_Image;
    public GameObject stage1_Button;
    public GameObject[] stage1_Buttons;
    public Text stage1_Notice;
    public int stage1_Notice_Num = 1;
    public GameObject stage2;
    public Image stage2_cutToon;
    public Text stage2_Notice;
    public string stage2_Emotion;
    public GameObject stage2_Emotion_Btn;
    public GameObject stage2_Main_Panel;
    public GameObject stage2_ScrollView;
    public GameObject stage2_Button;
    private int stage2_Answer = 0;
    public GameObject stage3;
    public GameObject stage3_Sentence;
    public GameObject stage4;
    public GameObject stage4_One;
    public GameObject stage4_Two;
    public GameObject stage4_Three;
    public GameObject stage4_Four;
    public GameObject stage4_Five;
    private int stage4_Count = 1;
    public GameObject stage5;
    public GameObject stage5_Tutorial;
    public bool stage5_isTutorial = false;
    private bool stage5_isTutorial_Check;
    private bool stage5_isTutorial_Check2;
    public GameObject stage5_Tutorial_Bar;
    public GameObject stage5_Tutorial_Panel;
    public Image stage5_Tutorial_Road;
    public GameObject stage5_Count;
    public bool stage5_Count_Finish = false;
    public Text stage5_Notice;
    public GameObject stage5_Notice_Image;
    public int stage5_Notice_Num = 1;
    public GameObject stage5_Game;
    public Image stage5_Road;
    public GameObject stage5_Bar;
    public GameObject stage5_Car;
    public GameObject stage5_fuel;
    public GameObject stage5_Obstacle1;
    public GameObject stage5_Obstacle2;
    public GameObject stage5_Obstacle3;
    public GameObject stage6;
    public GameObject stage6_Char_Step1;
    public GameObject stage6_Char_Step2;
    public GameObject stage6_Char_Step3;
    public Sprite stage6_Background;
    public GameObject stage6_Bar;
    public GameObject stage6_Ment;
    public GameObject shadow;
    public GameObject success;
    public GameObject fail;
    public bool isNext = false;
    public bool isSentence = false;
    public int stage = 1;
    GameManager gameManager;
    AnimManager animManager;
    WaitForSeconds waitForSeconds = new WaitForSeconds(0.01f);
    public bool isTutorial;
    private bool isTutorial_Check;
    private bool isTutorial_Check2;
    public int tutorial_Notice_Num = 1;
    public List<string> sentence_Text = new List<string> {"우리 할머니의 머리는 점점 백발이 되고 있다.", "오늘 아침에 내 짝이 나를 보고 미소를 지었다.", "나는 생각하고 느끼는 존재이다.", "우리 엄마는 잔소리를 많이 한다.", "우리 아빠는 집안일을 잘 하지 않는다.", "내 동생은 다소 이기적이다.", "우리 반 친구들은 나를 싫어한다.", "내 친구들은 나를 보고도 모른 체 한다.", "내 초등학교 절친은 사회성이 부족하다.", "선생님들은 우리를 힘들게 한다.", "우리 회사의 사장님은 권위적이다.", "공부든 일이든 모두 나를 위한 것이다.", "적성을 아는 것이 진로 선택에 도움이 된다.", "나는 타인의 눈치를 많이 본다.", "나는 왕따이다.", "나는 자신감이 부족하다.", "운전하면서 중간에 끼어들면 안 된다.", "운전하면서 중간에 끼어들어도 괜찮다.", "경상도 남자들은 말이 별로 없다.", "안중근 의사는 애국자이다."};
    private List<string> stage1_Text = new List<string> { "화난", "그리운", "불안한", "사랑스러운", "슬픈", "뿌듯한", "든든한", "괴로운", "열정적인" };
    private List<string> stage2_Anger = new List<string> { "나는 잘못이 없어.", "이 친구는 나쁜 놈이야.", "참으면 나를 무시할 거야.", "일부러 나를 힘들게 해."};
    private List<string> stage2_Unrest = new List<string> { "앞으로도 계속 괴롭히겠지.", "언제 또 당할지 몰라.", "모두 나를 바보처럼 보겠지.", "이제 학교생활은 끝이야."};
    private List<string> stage2_Sadness = new List<string> {"내 편은 아무도 없어.", "언제나 나는 혼자야.", "아무런 희망이 안 보여.", "아무도 도와주지 않아."};
    private List<string> stage2_Remorse = new List<string> {"나는 바보같아.", "내가 잘 못했어.", "다 나 때문이야.", "원래 나는 비호감이야."};
    private List<string> stage2_Text = new List<string> { };
    private List<string> stage3_True = new List<string> {"저 애가 나를 쳐다보고 있어.", "지금 엄마가 생각나.", "반 친구들이 여기를 보고 있네.", "나는 현재 긴장된 상태야.", "지금 어떻게 해야할지 고민이야.", "친구들이 가만히 있기만 하네.", "손에 힘이 들어가고 있어.", "목이 마르고 열이 나네."};
    private List<string> stage3_Text = new List<string> { };
    private List<string> stage5_Anger = new List<string> { "에이, 열받아", "머리에 열이 나는구나", "목 뒤쪽이 뻣뻣하다", "목소리가 커진다", "호흡이 빨라진다", "화가 올라왔다가 사라지는구나"};
    private List<string> stage5_Unrest = new List<string> { "긴장된다", "지금 가슴이 뛴다", "호흡이 빠르다", "말을 더듬는다", "무슨 말을 하는지 잘 모르겠다", "불안했구나"};
    private List<string> stage5_Sadness = new List<string> {"슬프다", "눈물이 난다", "아무것도 하고 싶지 않다", "가라앉는다", "귀찮다", "내가 우울했구나"};
    private List<string> stage5_Remorse = new List<string> {"실망스럽다", "내가 지금 어깨가 쳐지는구나", "목소리가 힘이 없다", "쪼그라든다", "주저앉고싶다", "애썼는데 아쉽네"};
    public List<string> stage5_Text = new List<string> { };
    public List<string> stage6_Text = new List<string> {"너도 나름 최선을 다했잖아.", "잘했어.", "잘 하려고 한 거잖아.", "누구나 잘 하고 싶지.", "못하고 싶은 사람은 아무도 없어.", "네가 한 것은 다 잘 한거야.", "너도 좋은 사람이려고 한 거잖아."};
    public int count = 0;
    public GameObject tutorial_Notice_Image;
    public List<Sprite> cutToon;
    public List<Sprite> stage5_Road_Image;
    public bool isFinish = false;
    public BGMManager bgmManager;

    void Awake()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        animManager = GameObject.Find("AnimManager").GetComponent<AnimManager>();
    }

    void Update()
    {
        Tutorial();
        Sentence();
        Fuel();
        Stage1();
        Stage5_Tutorial();
        Stage6();
    }
    
    void Tutorial()
    {
        if (isTutorial == false)
        {
            if (isTutorial_Check == false)
            {
                isTutorial_Check = true;
                gameManager.Set2();
                
                if (PlayerPrefs.GetInt("Decent_Tutorial") == 0)
                {
                    gameManager.buttons.SetActive(false);
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

                    if (tutorial_Notice_Num != 5)
                    {
                        Tutorial_Notice();
                    }
                }
            }
        }
        else if (isTutorial == true && isTutorial_Check2 == false)
        {
            isTutorial_Check2 = true;
            
            for (int i = 0; i < stage1_Buttons.Length; i++)
            {
                int num = Random.Range(0, stage1_Text.Count);
                stage1_Buttons[i].transform.GetChild(0).GetComponent<Text>().text = stage1_Text[num];
                stage1_Text.RemoveAt(num);

                if (stage1_Buttons[i].transform.GetChild(0).GetComponent<Text>().text == "화난" ||
                    stage1_Buttons[i].transform.GetChild(0).GetComponent<Text>().text == "슬픈" ||
                    stage1_Buttons[i].transform.GetChild(0).GetComponent<Text>().text == "괴로운" ||
                    stage1_Buttons[i].transform.GetChild(0).GetComponent<Text>().text == "불안한")
                {
                    stage1_Buttons[i].transform.GetComponent<Button>().onClick.AddListener(() => Stage1_Btn(1));
                }
                else
                {
                    stage1_Buttons[i].transform.GetComponent<Button>().onClick.AddListener(() => Stage1_Btn(0));
                }
            }
            
            tutorial.SetActive(false);
            game.SetActive(true);
            stage1_Notice_Image.GetComponent<Animator>().Play("Text");
            gameManager.buttons.SetActive(true);

            if (gameManager.stage_Select_Level_Num == 1 || gameManager.stage_Select_Level_Num == 2)
            {
                stage1_cutToon.sprite = cutToon[0];
                stage2_cutToon.sprite = cutToon[0];
            }
            else if (gameManager.stage_Select_Level_Num == 3)
            {
                stage1_cutToon.sprite = cutToon[1];
                stage2_cutToon.sprite = cutToon[1];
            }
        }
    }
    
    void Tutorial_Notice()
    {
        if (tutorial_Notice_Num == 1)
        {
            tutorial_Notice.text = "탈중심화 연습을 시작합니다.";
            tutorial_Notice_Image.GetComponent<Animator>().Play("Text");
        }
        else if (tutorial_Notice_Num == 2)
        {
            tutorial_Notice.text = "잠시 후 나타나는 문장을 보고\n사실과 해석으로 구분하여\n드래그 해주세요.";
        }
        else if (tutorial_Notice_Num == 3)
        {
            tutorial_Notice.text = "사실이란 있는 그대로 설명한 것이며\n해석이란 자신의 생각을 거쳐 나온 이야기입니다.";
        }
        else if (tutorial_Notice_Num == 4)
        {
            tutorial_Notice_Image.SetActive(false);
            tutorial_Notice.text = "";
            tutorial_True.SetActive(true);
            tutorial_Interpret.SetActive(true);
        }
    }

    void Stage1()
    {
        if (isTutorial == true && stage == 1)
        {
            if (Input.GetMouseButtonDown(0))
            {
                stage1_Notice_Num++;

                if (stage1_Notice_Num != 6)
                {
                    Stage1_Notice();
                }
            }
        }
    }

    void Stage1_Notice()
    {
        if (stage1_Notice_Num == 1)
        {
            stage1_Notice.text = "다음 그림을 자세히 살펴봐주세요.";
        }
        else if (stage1_Notice_Num == 2)
        {
            stage1_cutToon.GetComponent<RectTransform>().offsetMin = new Vector2(0, 0);
            stage1_Notice_Image.SetActive(false);
            stage1_Button.SetActive(true);
            stage1_Notice.text = "아래 제시된 9가지 감정 중\n그림에서 경험할 수 있는 감정을\n4가지 선택해보세요.";
        }
    }
    
    public void Stage1_Btn(int num)
    {
        count = 0;
        /*stage2.transform.GetChild(0).GetChild(0).GetComponent<Button>().interactable = true;
        stage2.transform.GetChild(0).GetChild(0).GetChild(1).GetComponent<Image>().color = new Color(255, 255, 255, 1);
        stage2.transform.GetChild(0).GetChild(1).GetComponent<Button>().interactable = true;
        stage2.transform.GetChild(0).GetChild(1).GetChild(1).GetComponent<Image>().color = new Color(255, 255, 255, 1);
        stage2.transform.GetChild(0).GetChild(2).GetComponent<Button>().interactable = true;
        stage2.transform.GetChild(0).GetChild(2).GetChild(1).GetComponent<Image>().color = new Color(255, 255, 255, 1);
        stage2.transform.GetChild(0).GetChild(3).GetComponent<Button>().interactable = true;
        stage2.transform.GetChild(0).GetChild(3).GetChild(1).GetComponent<Image>().color = new Color(255, 255, 255, 1);*/
        
        if (num == 0)
        {
            shadow.SetActive(true);
            fail.SetActive(true);
        }
        else if (num == 1)
        {
            EventSystem.current.currentSelectedGameObject.GetComponent<Button>().interactable = false;
        }

        int count2 = 0;

        for (int i = 0; i < stage1_Buttons.Length; i++)
        {
            if (stage1_Buttons[i].transform.GetComponent<Button>().interactable == false)
            {
                count2++;

                if (count2 >= 4)
                {
                    stage = 2;
                    stage1.gameObject.SetActive(false);
                    stage2.gameObject.SetActive(true);
                }
            }
        }
    }

    public void Stage2_Btn(string type)
    {
        stage2_Emotion = type;

        if (type == "Anger")
        {
            stage2_Emotion_Btn.transform.GetChild(0).GetComponent<Button>().interactable = false;
            stage2_Emotion_Btn.transform.GetChild(0).GetChild(1).GetComponent<Image>().color = new Color(255, 255, 255, 0.3f);

            switch (gameManager.stage_Select_Level_Num)
            {
                case 1:
                    stage2_Notice.text = "분노가 느껴질 때 들 수 있는 생각 2개를 골라보세요.";
                    break;
                case 2:
                    stage2_Notice.text = "분노가 느껴질 때 들 수 있는 생각 4개를 골라보세요.";
                    break;
                case 3:
                    stage2_Notice.text = "분노가 느껴질 때 들 수 있는 생각 6개를 골라보세요.";
                    break;
            }
        }
        else if (type == "Unrest")
        {
            stage2_Emotion_Btn.transform.GetChild(1).GetComponent<Button>().interactable = false;
            stage2_Emotion_Btn.transform.GetChild(1).GetChild(1).GetComponent<Image>().color = new Color(255, 255, 255, 0.3f);
            
            switch (gameManager.stage_Select_Level_Num)
            {
                case 1:
                    stage2_Notice.text = "불안이 느껴질 때 들 수 있는 생각 2개를 골라보세요.";
                    break;
                case 2:
                    stage2_Notice.text = "불안이 느껴질 때 들 수 있는 생각 4개를 골라보세요.";
                    break;
                case 3:
                    stage2_Notice.text = "불안이 느껴질 때 들 수 있는 생각 6개를 골라보세요.";
                    break;
            }
        }
        else if (type == "Sadness")
        {
            stage2_Emotion_Btn.transform.GetChild(2).GetComponent<Button>().interactable = false;
            stage2_Emotion_Btn.transform.GetChild(2).GetChild(1).GetComponent<Image>().color = new Color(255, 255, 255, 0.3f);

            switch (gameManager.stage_Select_Level_Num)
            {
                case 1:
                    stage2_Notice.text = "슬픔이 느껴질 때 들 수 있는 생각 2개를 골라보세요.";
                    break;
                case 2:
                    stage2_Notice.text = "슬픔이 느껴질 때 들 수 있는 생각 4개를 골라보세요.";
                    break;
                case 3:
                    stage2_Notice.text = "슬픔이 느껴질 때 들 수 있는 생각 6개를 골라보세요.";
                    break;
            }
        }
        else if (type == "Remorse")
        {
            stage2_Emotion_Btn.transform.GetChild(3).GetComponent<Button>().interactable = false;
            stage2_Emotion_Btn.transform.GetChild(3).GetChild(1).GetComponent<Image>().color = new Color(255, 255, 255, 0.3f);

            switch (gameManager.stage_Select_Level_Num)
            {
                case 1:
                    stage2_Notice.text = "자책이 느껴질 때 들 수 있는 생각 2개를 골라보세요.";
                    break;
                case 2:
                    stage2_Notice.text = "자책이 느껴질 때 들 수 있는 생각 4개를 골라보세요.";
                    break;
                case 3:
                    stage2_Notice.text = "자책이 느껴질 때 들 수 있는 생각 6개를 골라보세요.";
                    break;
            }
        }

        if (gameManager.stage_Select_Level_Num == 1)
        {
            for (int i = 0; i < 2; i++)
            {
                int num = Random.Range(0, stage2_Anger.Count);
                stage2_Text.Add(stage2_Anger[num]);
                stage2_Anger.RemoveAt(num);
            }
            
            for (int i = 0; i < 2; i++)
            {
                int num = Random.Range(0, stage2_Unrest.Count);
                stage2_Text.Add(stage2_Unrest[num]);
                stage2_Unrest.RemoveAt(num);
            }
            
            for (int i = 0; i < 2; i++)
            {
                int num = Random.Range(0, stage2_Sadness.Count);
                stage2_Text.Add(stage2_Sadness[num]);
                stage2_Sadness.RemoveAt(num);
            }
            
            for (int i = 0; i < 2; i++)
            {
                int num = Random.Range(0, stage2_Remorse.Count);
                stage2_Text.Add(stage2_Remorse[num]);
                stage2_Remorse.RemoveAt(num);
            }
            
            for (int i = 0; i < 8; i++)
            {
                GameObject temp = Instantiate(stage2_Button);
                temp.transform.SetParent(stage2_ScrollView.transform.GetChild(0).GetChild(0));
                temp.transform.localScale = new Vector3(1f, 1f, 1f);
                int num = Random.Range(0, stage2_Text.Count);
                temp.transform.GetChild(0).GetComponent<Text>().text = stage2_Text[num];
                stage2_Text.RemoveAt(num);
                
                if (temp.transform.GetChild(0).GetComponent<Text>().text == "나는 잘못이 없어." || temp.transform.GetChild(0).GetComponent<Text>().text == "이 친구는 나쁜 놈이야." || temp.transform.GetChild(0).GetComponent<Text>().text == "참으면 나를 무시할 거야." || temp.transform.GetChild(0).GetComponent<Text>().text == "일부러 나를 힘들게 해.")
                {
                    temp.GetComponent<Button>().onClick.AddListener(() => Stage2_Check("Anger"));
                }
                else if (temp.transform.GetChild(0).GetComponent<Text>().text == "앞으로도 계속 괴롭히겠지." || temp.transform.GetChild(0).GetComponent<Text>().text == "언제 또 당할지 몰라." || temp.transform.GetChild(0).GetComponent<Text>().text == "모두 나를 바보처럼 보겠지." || temp.transform.GetChild(0).GetComponent<Text>().text == "이제 학교생활은 끝이야.")
                {
                    temp.GetComponent<Button>().onClick.AddListener(() => Stage2_Check("Unrest"));
                }
                else if (temp.transform.GetChild(0).GetComponent<Text>().text == "내 편은 아무도 없어." || temp.transform.GetChild(0).GetComponent<Text>().text == "언제나 나는 혼자야." || temp.transform.GetChild(0).GetComponent<Text>().text == "아무런 희망이 안 보여." || temp.transform.GetChild(0).GetComponent<Text>().text == "아무도 도와주지 않아.")
                {
                    temp.GetComponent<Button>().onClick.AddListener(() => Stage2_Check("Sadness"));
                }
                else if (temp.transform.GetChild(0).GetComponent<Text>().text == "나는 바보같아." || temp.transform.GetChild(0).GetComponent<Text>().text == "내가 잘 못했어." || temp.transform.GetChild(0).GetComponent<Text>().text == "다 나 때문이야." || temp.transform.GetChild(0).GetComponent<Text>().text == "원래 나는 비호감이야.")
                {
                    temp.GetComponent<Button>().onClick.AddListener(() => Stage2_Check("Remorse"));
                }
            }
        }
        else if (gameManager.stage_Select_Level_Num == 2)
        {
            if (stage2_Emotion == "Anger")
            {
                for (int i = 0; i < 4; i++)
                {
                    int num = Random.Range(0, stage2_Anger.Count);
                    stage2_Text.Add(stage2_Anger[num]);
                    stage2_Anger.RemoveAt(num);
                }
            
                for (int i = 0; i < 2; i++)
                {
                    int num = Random.Range(0, stage2_Unrest.Count);
                    stage2_Text.Add(stage2_Unrest[num]);
                    stage2_Unrest.RemoveAt(num);
                }
            
                for (int i = 0; i < 2; i++)
                {
                    int num = Random.Range(0, stage2_Sadness.Count);
                    stage2_Text.Add(stage2_Sadness[num]);
                    stage2_Sadness.RemoveAt(num);
                }
            
                for (int i = 0; i < 2; i++)
                {
                    int num = Random.Range(0, stage2_Remorse.Count);
                    stage2_Text.Add(stage2_Remorse[num]);
                    stage2_Remorse.RemoveAt(num);
                }
            }
            else if (stage2_Emotion == "Unrest")
            {
                for (int i = 0; i < 2; i++)
                {
                    int num = Random.Range(0, stage2_Anger.Count);
                    stage2_Text.Add(stage2_Anger[num]);
                    stage2_Anger.RemoveAt(num);
                }
            
                for (int i = 0; i < 4; i++)
                {
                    int num = Random.Range(0, stage2_Unrest.Count);
                    stage2_Text.Add(stage2_Unrest[num]);
                    stage2_Unrest.RemoveAt(num);
                }
            
                for (int i = 0; i < 2; i++)
                {
                    int num = Random.Range(0, stage2_Sadness.Count);
                    stage2_Text.Add(stage2_Sadness[num]);
                    stage2_Sadness.RemoveAt(num);
                }
            
                for (int i = 0; i < 2; i++)
                {
                    int num = Random.Range(0, stage2_Remorse.Count);
                    stage2_Text.Add(stage2_Remorse[num]);
                    stage2_Remorse.RemoveAt(num);
                }
            }
            else if (stage2_Emotion == "Sadness")
            {
                for (int i = 0; i < 2; i++)
                {
                    int num = Random.Range(0, stage2_Anger.Count);
                    stage2_Text.Add(stage2_Anger[num]);
                    stage2_Anger.RemoveAt(num);
                }
            
                for (int i = 0; i < 2; i++)
                {
                    int num = Random.Range(0, stage2_Unrest.Count);
                    stage2_Text.Add(stage2_Unrest[num]);
                    stage2_Unrest.RemoveAt(num);
                }
            
                for (int i = 0; i < 4; i++)
                {
                    int num = Random.Range(0, stage2_Sadness.Count);
                    stage2_Text.Add(stage2_Sadness[num]);
                    stage2_Sadness.RemoveAt(num);
                }
            
                for (int i = 0; i < 2; i++)
                {
                    int num = Random.Range(0, stage2_Remorse.Count);
                    stage2_Text.Add(stage2_Remorse[num]);
                    stage2_Remorse.RemoveAt(num);
                }
            }
            else if (stage2_Emotion == "Remorse")
            {
                for (int i = 0; i < 2; i++)
                {
                    int num = Random.Range(0, stage2_Anger.Count);
                    stage2_Text.Add(stage2_Anger[num]);
                    stage2_Anger.RemoveAt(num);
                }
            
                for (int i = 0; i < 2; i++)
                {
                    int num = Random.Range(0, stage2_Unrest.Count);
                    stage2_Text.Add(stage2_Unrest[num]);
                    stage2_Unrest.RemoveAt(num);
                }
            
                for (int i = 0; i < 2; i++)
                {
                    int num = Random.Range(0, stage2_Sadness.Count);
                    stage2_Text.Add(stage2_Sadness[num]);
                    stage2_Sadness.RemoveAt(num);
                }
            
                for (int i = 0; i < 4; i++)
                {
                    int num = Random.Range(0, stage2_Remorse.Count);
                    stage2_Text.Add(stage2_Remorse[num]);
                    stage2_Remorse.RemoveAt(num);
                }
            }

            for (int i = 0; i < 10; i++)
            {
                GameObject temp = Instantiate(stage2_Button);
                temp.transform.SetParent(stage2_ScrollView.transform.GetChild(0).GetChild(0));
                temp.transform.localScale = new Vector3(1f, 1f, 1f);
                int num = Random.Range(0, stage2_Text.Count);
                temp.transform.GetChild(0).GetComponent<Text>().text = stage2_Text[num];
                stage2_Text.RemoveAt(num);
                
                if (temp.transform.GetChild(0).GetComponent<Text>().text == "나는 잘못이 없어" || temp.transform.GetChild(0).GetComponent<Text>().text == "이 친구는 나쁜 놈이야" || temp.transform.GetChild(0).GetComponent<Text>().text == "참으면 나를 무시할 거야" || temp.transform.GetChild(0).GetComponent<Text>().text == "일부러 나를 힘들게 해")
                {
                    temp.GetComponent<Button>().onClick.AddListener(() => Stage2_Check("Anger"));
                }
                else if (temp.transform.GetChild(0).GetComponent<Text>().text == "앞으로도 계속 괴롭히겠지" || temp.transform.GetChild(0).GetComponent<Text>().text == "언제 또 당할지 몰라" || temp.transform.GetChild(0).GetComponent<Text>().text == "모두 나를 바보처럼 보겠지" || temp.transform.GetChild(0).GetComponent<Text>().text == "이제 학교생활은 끝이야")
                {
                    temp.GetComponent<Button>().onClick.AddListener(() => Stage2_Check("Unrest"));
                }
                else if (temp.transform.GetChild(0).GetComponent<Text>().text == "내 편은 아무도 없어" || temp.transform.GetChild(0).GetComponent<Text>().text == "언제나 나는 혼자야" || temp.transform.GetChild(0).GetComponent<Text>().text == "아무런 희망이 안 보여" || temp.transform.GetChild(0).GetComponent<Text>().text == "아무도 도와주지 않아")
                {
                    temp.GetComponent<Button>().onClick.AddListener(() => Stage2_Check("Sadness"));
                }
                else if (temp.transform.GetChild(0).GetComponent<Text>().text == "나는 바보같아" || temp.transform.GetChild(0).GetComponent<Text>().text == "내가 잘 못했어" || temp.transform.GetChild(0).GetComponent<Text>().text == "다 나 때문이야" || temp.transform.GetChild(0).GetComponent<Text>().text == "원래 나는 비호감이야")
                {
                    temp.GetComponent<Button>().onClick.AddListener(() => Stage2_Check("Remorse"));
                }
            }
        }
        else if (gameManager.stage_Select_Level_Num == 3)
        {
            if (stage2_Emotion == "Anger")
            {
                for (int i = 0; i < 4; i++)
                {
                    int num = Random.Range(0, stage2_Anger.Count);
                    stage2_Text.Add(stage2_Anger[num]);
                    stage2_Anger.RemoveAt(num);
                }
            
                for (int i = 0; i < 4; i++)
                {
                    int num = Random.Range(0, stage2_Unrest.Count);
                    stage2_Text.Add(stage2_Unrest[num]);
                    stage2_Unrest.RemoveAt(num);
                }
            
                for (int i = 0; i < 3; i++)
                {
                    int num = Random.Range(0, stage2_Sadness.Count);
                    stage2_Text.Add(stage2_Sadness[num]);
                    stage2_Sadness.RemoveAt(num);
                }
            
                for (int i = 0; i < 3; i++)
                {
                    int num = Random.Range(0, stage2_Remorse.Count);
                    stage2_Text.Add(stage2_Remorse[num]);
                    stage2_Remorse.RemoveAt(num);
                }
            }
            else if (stage2_Emotion == "Unrest")
            {
                for (int i = 0; i < 4; i++)
                {
                    int num = Random.Range(0, stage2_Anger.Count);
                    stage2_Text.Add(stage2_Anger[num]);
                    stage2_Anger.RemoveAt(num);
                }
            
                for (int i = 0; i < 4; i++)
                {
                    int num = Random.Range(0, stage2_Unrest.Count);
                    stage2_Text.Add(stage2_Unrest[num]);
                    stage2_Unrest.RemoveAt(num);
                }
            
                for (int i = 0; i < 3; i++)
                {
                    int num = Random.Range(0, stage2_Sadness.Count);
                    stage2_Text.Add(stage2_Sadness[num]);
                    stage2_Sadness.RemoveAt(num);
                }
            
                for (int i = 0; i < 3; i++)
                {
                    int num = Random.Range(0, stage2_Remorse.Count);
                    stage2_Text.Add(stage2_Remorse[num]);
                    stage2_Remorse.RemoveAt(num);
                }
            }
            else if (stage2_Emotion == "Sadness")
            {
                for (int i = 0; i < 3; i++)
                {
                    int num = Random.Range(0, stage2_Anger.Count);
                    stage2_Text.Add(stage2_Anger[num]);
                    stage2_Anger.RemoveAt(num);
                }
            
                for (int i = 0; i < 3; i++)
                {
                    int num = Random.Range(0, stage2_Unrest.Count);
                    stage2_Text.Add(stage2_Unrest[num]);
                    stage2_Unrest.RemoveAt(num);
                }
            
                for (int i = 0; i < 4; i++)
                {
                    int num = Random.Range(0, stage2_Sadness.Count);
                    stage2_Text.Add(stage2_Sadness[num]);
                    stage2_Sadness.RemoveAt(num);
                }
            
                for (int i = 0; i < 4; i++)
                {
                    int num = Random.Range(0, stage2_Remorse.Count);
                    stage2_Text.Add(stage2_Remorse[num]);
                    stage2_Remorse.RemoveAt(num);
                }
            }
            else if (stage2_Emotion == "Remorse")
            {
                for (int i = 0; i < 3; i++)
                {
                    int num = Random.Range(0, stage2_Anger.Count);
                    stage2_Text.Add(stage2_Anger[num]);
                    stage2_Anger.RemoveAt(num);
                }
            
                for (int i = 0; i < 3; i++)
                {
                    int num = Random.Range(0, stage2_Unrest.Count);
                    stage2_Text.Add(stage2_Unrest[num]);
                    stage2_Unrest.RemoveAt(num);
                }
            
                for (int i = 0; i < 4; i++)
                {
                    int num = Random.Range(0, stage2_Sadness.Count);
                    stage2_Text.Add(stage2_Sadness[num]);
                    stage2_Sadness.RemoveAt(num);
                }
            
                for (int i = 0; i < 4; i++)
                {
                    int num = Random.Range(0, stage2_Remorse.Count);
                    stage2_Text.Add(stage2_Remorse[num]);
                    stage2_Remorse.RemoveAt(num);
                }
            }

            for (int i = 0; i < 14; i++)
            {
                GameObject temp = Instantiate(stage2_Button);
                temp.transform.SetParent(stage2_ScrollView.transform.GetChild(0).GetChild(0));
                temp.transform.localScale = new Vector3(1f, 1f, 1f);
                int num = Random.Range(0, stage2_Text.Count);
                temp.transform.GetChild(0).GetComponent<Text>().text = stage2_Text[num];
                stage2_Text.RemoveAt(num);

                if (temp.transform.GetChild(0).GetComponent<Text>().text == "나는 잘못이 없어" || temp.transform.GetChild(0).GetComponent<Text>().text == "이 친구는 나쁜 놈이야" || temp.transform.GetChild(0).GetComponent<Text>().text == "참으면 나를 무시할 거야" || temp.transform.GetChild(0).GetComponent<Text>().text == "일부러 나를 힘들게 해")
                {
                    temp.GetComponent<Button>().onClick.AddListener(() => Stage2_Check("Anger"));
                }
                else if (temp.transform.GetChild(0).GetComponent<Text>().text == "앞으로도 계속 괴롭히겠지" || temp.transform.GetChild(0).GetComponent<Text>().text == "언제 또 당할지 몰라" || temp.transform.GetChild(0).GetComponent<Text>().text == "모두 나를 바보처럼 보겠지" || temp.transform.GetChild(0).GetComponent<Text>().text == "이제 학교생활은 끝이야")
                {
                    temp.GetComponent<Button>().onClick.AddListener(() => Stage2_Check("Unrest"));
                }
                else if (temp.transform.GetChild(0).GetComponent<Text>().text == "내 편은 아무도 없어" || temp.transform.GetChild(0).GetComponent<Text>().text == "언제나 나는 혼자야" || temp.transform.GetChild(0).GetComponent<Text>().text == "아무런 희망이 안 보여" || temp.transform.GetChild(0).GetComponent<Text>().text == "아무도 도와주지 않아")
                {
                    temp.GetComponent<Button>().onClick.AddListener(() => Stage2_Check("Sadness"));
                }
                else if (temp.transform.GetChild(0).GetComponent<Text>().text == "나는 바보같아" || temp.transform.GetChild(0).GetComponent<Text>().text == "내가 잘 못했어" || temp.transform.GetChild(0).GetComponent<Text>().text == "다 나 때문이야" || temp.transform.GetChild(0).GetComponent<Text>().text == "원래 나는 비호감이야")
                {
                    temp.GetComponent<Button>().onClick.AddListener(() => Stage2_Check("Remorse"));
                }
            }
        }
        
        stage2_Emotion_Btn.SetActive(false);
        stage2_Main_Panel.SetActive(true);
    }

    public void Stage2_Check(string type)
    {
        if (stage2_Emotion == type)
        {
            stage3_Text.Add(EventSystem.current.currentSelectedGameObject.transform.GetChild(0).GetComponent<Text>().text);
            EventSystem.current.currentSelectedGameObject.transform.GetChild(0).GetComponent<Text>().color = Color.white;
            EventSystem.current.currentSelectedGameObject.GetComponent<Image>().color = Color.green;
            EventSystem.current.currentSelectedGameObject.GetComponent<Button>().interactable = false;
            stage2_Answer++;

            if (gameManager.stage_Select_Level_Num == 1)
            {
                if (stage2_Answer >= 2)
                {
                    for (int i = 0; i < 2; i++)
                    {
                        int num = Random.Range(0, stage3_True.Count);
                        stage3_Text.Add(stage3_True[num]);
                        stage3_True.RemoveAt(num);
                    }
                    
                    Invoke("Stage2_Delay", 1.5f);
                }
            }
            else if (gameManager.stage_Select_Level_Num == 2 || gameManager.stage_Select_Level_Num == 3)
            {
                if (stage2_Answer >= 4)
                {
                    for (int i = 0; i < 2; i++)
                    {
                        int num = Random.Range(0, stage3_True.Count);
                        stage3_Text.Add(stage3_True[num]);
                        stage3_True.RemoveAt(num);
                    }
                    
                    Invoke("Stage2_Delay", 1.5f);
                }
            }
        }
        else
        {
            EventSystem.current.currentSelectedGameObject.GetComponent<Image>().color = Color.black;
            EventSystem.current.currentSelectedGameObject.GetComponent<Button>().interactable = false;
        }
    }

    void Stage2_Delay()
    {
        stage2.SetActive(false);
        stage3.SetActive(true);
        stage = 3;
    }

    public void Stage4_Btn()
    {
        if (stage4_Count == 1)
        {
            stage4_One.SetActive(false);
            stage4_Two.SetActive(true);
        }
        else if (stage4_Count == 2)
        {
            stage4_Two.SetActive(false);
            stage4_Three.SetActive(true);
        }
        else if (stage4_Count == 3)
        {
            stage4_Three.SetActive(false);
            stage4_Four.SetActive(true);
        }
        else if (stage4_Count == 4)
        {
            stage4_Four.SetActive(false);
            stage4_Five.SetActive(true);
        }
        else if (stage4_Count == 5)
        {
            stage4.SetActive(false);
            stage5.SetActive(true);
            stage = 5;
            stage5_Notice_Image.GetComponent<Animator>().Play("Text");
        }

        stage4_Count++;
    }
    
     void Stage5_Tutorial()
    {
        if (isTutorial == true && stage == 5 && stage5_isTutorial == false)
        {
            if (stage5_isTutorial_Check == false)
            {
                stage5_isTutorial_Check = true;

                if (PlayerPrefs.GetInt("Decent_Stage5_Tutorial") == 0)
                {
                    stage5_isTutorial = false;
                    
                    switch (stage2_Emotion)
                    {
                        case "Anger":
                            stage5_Tutorial_Road.sprite = stage5_Road_Image[0];
                            break;
                        case "Unrest":
                            stage5_Tutorial_Road.sprite = stage5_Road_Image[1];
                            break;
                        case "Sadness":
                            stage5_Tutorial_Road.sprite = stage5_Road_Image[2];
                            break;
                        case "Remorse":
                            stage5_Tutorial_Road.sprite = stage5_Road_Image[3];
                            break;
                    }
                }
                else
                {
                    stage5_isTutorial = true;
                }
            }
            else
            {
                if (Input.GetMouseButtonUp(0))
                {
                    stage5_Notice_Num++;

                    if (stage5_Notice_Num != 7)
                    {
                        Stage5_Tutorial_Notice();
                    }
                }
            }
        }
        else if (isTutorial == true && stage5_isTutorial == true && stage5_isTutorial_Check2 == false)
        {
            stage5_isTutorial_Check2 = true;
            stage5_Tutorial.SetActive(false);

            switch (stage2_Emotion)
            {
                case "Anger":
                    stage5_Road.sprite = stage5_Road_Image[0];
                    break;
                case "Unrest":
                    stage5_Road.sprite = stage5_Road_Image[1];
                    break;
                case "Sadness":
                    stage5_Road.sprite = stage5_Road_Image[2];
                    break;
                case "Remorse":
                    stage5_Road.sprite = stage5_Road_Image[3];
                    break;
            }
            
            stage5_Game.SetActive(true);
            StartCoroutine(nameof(Stage5_Count));
        }
    }
    
    void Stage5_Tutorial_Notice()
    {
        if (stage5_Notice_Num == 1)
        {
            stage5_Notice.text = "수용 연습을 시작합니다.";
        }
        else if (stage5_Notice_Num == 2)
        {
            stage5_Notice.text = "현재 자신이 경험을 받아들임으로써\n자기이해, 자기사랑, 자기수용의 단계를 마무리합시다.";
        }
        else if (stage5_Notice_Num == 3)
        {
            stage5_Notice.text = "자동차는 나 자신이고\n연료는 자신의 현재 경험입니다.";
        }
        else if (stage5_Notice_Num == 4)
        {
            stage5_Notice.text = "자동차를 좌우로 드래그하여\n분노 경험과 관련된 연료를 채우세요.";
        }
        else if (stage5_Notice_Num == 5)
        {
            stage5_Notice.text = "만약 관련이 없는 연료를 채우게 되면\n에너지가 줄어듭니다.";
        }
        else if (stage5_Notice_Num == 6)
        {
            stage5_Notice.text = "";
            stage5_Tutorial_Panel.SetActive(true);
            stage5_Notice_Image.SetActive(false);
        }
    }

    void Stage5_Check()
    {
        bgmManager.StopBGM();
        stage5_isTutorial = true;
        isSentence = false;
        PlayerPrefs.SetInt("Decent_Stage5_Tutorial", 1);
        StartCoroutine(nameof(Stage5_Count));
        
        stage5_Text.Clear();
        
        if (stage2_Emotion == "Anger")
        {
            stage5_Text.AddRange(stage5_Anger);
        }
        else if (stage2_Emotion == "Unrest")
        {
            stage5_Text.AddRange(stage5_Unrest);
        }
        else if (stage2_Emotion == "Sadness")
        {
            stage5_Text.AddRange(stage5_Sadness);
        }
        else if (stage2_Emotion == "Remorse")
        {
            stage5_Text.AddRange(stage5_Remorse);
        }
    }

    private IEnumerator Stage5_Count()
    {
        switch (stage2_Emotion)
        {
            case "Anger":
                bgmManager.PlayBGM("Decent_Anger");
                break;
            
            case "Unrest":
                bgmManager.PlayBGM("Decent_Unrest");
                break;
            
            case "Sadness":
                bgmManager.PlayBGM("Decent_Sadness");
                break;
            
            case "Remorse":
                bgmManager.PlayBGM("Decent_Remorse");
                break;
        }

        float time = 3;

        while (time >= 0)
        {
            if (time < 1)
            {
                stage5_Count.GetComponent<Text>().text = "START!";
            }
            else
            {
                stage5_Count.GetComponent<Text>().text = Mathf.Round(time).ToString();
            }
            
            time -= 1;
            
            yield return new WaitForSeconds(1f);
        }

        stage5_Count.SetActive(false);
        stage5_Count_Finish = true;
    }
    
    void Fuel()
    {
        if (isTutorial == true && stage == 5 && isSentence == false && stage5_isTutorial == false && stage5_Notice_Num >= 6)
        {
            isSentence = true;
            
            if (stage5_Tutorial_Bar.GetComponent<Slider>().value != 1)
            {
                StartCoroutine("FuelGenerator");
            }
            else if (stage5_Tutorial_Bar.GetComponent<Slider>().value == 1)
            {
                stage5_Notice.text = "잘 하셨습니다. 수용 연습을 마칩니다.";
                stage5_Tutorial_Panel.SetActive(false);
                Invoke("Stage5_Check", 3f);
            }
        }
        else if (isTutorial == true && stage == 5 && isSentence == false && stage5_isTutorial == true && stage5_Count_Finish == true)
        {
            isSentence = true;
            
            if (stage5_Bar.GetComponent<Slider>().value != 1)
            {
                StartCoroutine("FuelGenerator");
            }
            else if (stage5_Bar.GetComponent<Slider>().value == 1)
            {
                Invoke("Check", 0.5f);
            }
        }
    }
    
    IEnumerator FuelGenerator()
    {
        if (stage5_isTutorial == false)
        {
            int rand1 = Random.Range(0, 2);

            if (rand1 == 0)
            {
                int rand2 = Random.Range(0, 3);
                GameObject temp = Instantiate(stage5_fuel);

                switch (rand2)
                {
                    case 0:
                        temp = Instantiate(stage5_Obstacle1);
                        break;
                    case 1:
                        temp = Instantiate(stage5_Obstacle2);
                        break;
                    case 2:
                        temp = Instantiate(stage5_Obstacle3);
                        break;
                }
                
                temp.transform.SetParent(stage5_Tutorial_Panel.transform.GetChild(2));
                temp.transform.GetComponent<RectTransform>().anchoredPosition =
                    new Vector2(Random.Range(-220, 220), 190);
                temp.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
            }
            else
            {
                GameObject temp = Instantiate(stage5_fuel);
                temp.transform.SetParent(stage5_Tutorial_Panel.transform.GetChild(2));
                temp.transform.GetComponent<RectTransform>().anchoredPosition =
                    new Vector2(Random.Range(-220, 220), 190);
                temp.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
                int num = Random.Range(0, stage5_Text.Count);
                temp.transform.GetChild(0).GetComponent<Text>().text = stage5_Text[num];
                stage5_Text.RemoveAt(num);

                if (stage5_Text.Count == 0)
                {
                    if (stage2_Emotion == "Anger")
                    {
                        stage5_Text.AddRange(stage5_Anger);
                    }
                    else if (stage2_Emotion == "Unrest")
                    {
                        stage5_Text.AddRange(stage5_Unrest);
                    }
                    else if (stage2_Emotion == "Sadness")
                    {
                        stage5_Text.AddRange(stage5_Sadness);
                    }
                    else if (stage2_Emotion == "Remorse")
                    {
                        stage5_Text.AddRange(stage5_Remorse);
                    }
                }
            }

            float delay = 0;

            while (delay < 1f)
            {
                delay += Time.deltaTime;
                yield return waitForSeconds;
            }
    
            isSentence = false;
        }
        else if (stage5_isTutorial == true)
        {
            int rand1 = Random.Range(0, 2);

            if (rand1 == 0)
            {
                int rand2 = Random.Range(0, 3);
                GameObject temp = Instantiate(stage5_fuel);

                switch (rand2)
                {
                    case 0:
                        temp = Instantiate(stage5_Obstacle1);
                        break;
                    case 1:
                        temp = Instantiate(stage5_Obstacle2);
                        break;
                    case 2:
                        temp = Instantiate(stage5_Obstacle3);
                        break;
                }
                
                temp.transform.SetParent(stage5_Game.transform.GetChild(2));
                temp.transform.GetComponent<RectTransform>().anchoredPosition =
                    new Vector2(Random.Range(-230, 230), 200);
                temp.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
            }
            else
            {
                GameObject temp = Instantiate(stage5_fuel);
                temp.transform.SetParent(stage5_Game.transform.GetChild(2));
                temp.transform.GetComponent<RectTransform>().anchoredPosition =
                    new Vector2(Random.Range(-230, 230), 200);
                temp.transform.localScale = new Vector3(0.4f, 0.4f, 0.4f);
                int num = Random.Range(0, stage5_Text.Count);
                temp.transform.GetChild(0).GetComponent<Text>().text = stage5_Text[num];
                stage5_Text.RemoveAt(num);

                if (stage5_Text.Count == 0)
                {
                    if (stage2_Emotion == "Anger")
                    {
                        stage5_Text.AddRange(stage5_Anger);
                    }
                    else if (stage2_Emotion == "Unrest")
                    {
                        stage5_Text.AddRange(stage5_Unrest);
                    }
                    else if (stage2_Emotion == "Sadness")
                    {
                        stage5_Text.AddRange(stage5_Sadness);
                    }
                    else if (stage2_Emotion == "Remorse")
                    {
                        stage5_Text.AddRange(stage5_Remorse);
                    }
                }
            }

            float delay = 0;

            while (delay < 1f)
            {
                delay += Time.deltaTime;
                yield return waitForSeconds;
            }
    
            isSentence = false;
        }
    }
    
    void Stage6()
    {
        if (isTutorial == true && stage == 6 && isSentence == false)
        {
            isSentence = true;

            if (stage6_Bar.GetComponent<Slider>().value != 1 && stage6_Text.Count != 0)
            {
                StartCoroutine("MentGenerator");
            }
        }
    }
    
    IEnumerator MentGenerator()
    {
        GameObject temp = Instantiate(stage6_Ment);
        temp.transform.SetParent(stage6.transform.GetChild(2));
        temp.transform.GetComponent<RectTransform>().anchoredPosition =
            new Vector2(0, 300);
        temp.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        int num = Random.Range(0, stage6_Text.Count);
        temp.transform.GetChild(0).GetChild(0).GetComponent<Text>().text = stage6_Text[num];
        stage6_Text.RemoveAt(num);

        float delay = 0;

        while (delay < 3f)
        {
            delay += Time.deltaTime;
            yield return waitForSeconds;
        }
    
        isSentence = false;
    }

    public void Check()
    {
        if (isTutorial == false)
        {
            isTutorial = true;
            PlayerPrefs.SetInt("Decent_Tutorial", 1);
        }
        else if (isTutorial == true)
        {
            if (stage == 3)
            {
                if (stage2_Emotion == "Anger")
                {
                    stage5_Text.AddRange(stage5_Anger);
                }
                else if (stage2_Emotion == "Unrest")
                {
                    stage5_Text.AddRange(stage5_Unrest);
                }
                else if (stage2_Emotion == "Sadness")
                {
                    stage5_Text.AddRange(stage5_Sadness);
                }
                else if (stage2_Emotion == "Remorse")
                {
                    stage5_Text.AddRange(stage5_Remorse);
                }
                
                stage3.SetActive(false);
                stage4.SetActive(true);
                stage = 4;
            }
            else if (stage == 5)
            {
                if (stage5_isTutorial == false)
                {
                    Stage5_Check();
                }
                else
                {
                    stage5_Bar.GetComponent<Slider>().value = 0;
                    stage5_Car.transform.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 150);
                    count++;
                    stage5.SetActive(false);
                    bgmManager.StopBGM();
                    bgmManager.PlayBGM("Stage_BGM");

                    if (count != 4)
                    {
                        Reset();
                        isTutorial = true;
                        stage1.SetActive(false);
                        stage2.SetActive(true);
                        stage = 2;
                        stage2_Notice.text = "앞서 선택한 4가지 감정 중 한 가지를 선택해주세요.";
                    }
                    else if (count == 4)
                    {
                        isNext = true;
                        animManager.Fade_Out();
                    }
                }
            }
            else if (stage == 6)
            {
                shadow.SetActive(true);
                success.SetActive(true);
                isFinish = true;
            }
        }
    }

    void Sentence()
    {
        if (isTutorial == false && isSentence == false && tutorial_Notice_Num >= 4)
        {
            if (sentence_Text.Count != 0)
            {
                isSentence = true;
                StartCoroutine("SentenceGenerator");
            }
            else if (sentence_Text.Count == 0)
            {
                if (tutorial_Sentence.transform.childCount == 0)
                {
                    tutorial_Notice.text = "사실과 해석에 대한 구분이 잘 되시나요?\n이제부터 본격적으로 시작해봅시다.";
                    tutorial_True.SetActive(false);
                    tutorial_Interpret.SetActive(false);
                    Invoke("Check", 3.0f);
                }
            }
        }
        else if (isTutorial == true && stage == 3 && isSentence == false)
        {
            if (stage3_Text.Count != 0)
            {
                isSentence = true;
                StartCoroutine("SentenceGenerator");
            }
            else if (stage3_Text.Count == 0)
            {
                if (stage3_Sentence.transform.childCount == 0)
                {
                    Check();
                }
            }
        }
    }
    
    IEnumerator SentenceGenerator()
    {
        bool test = isTutorial;

        if (test == false)
        {
            GameObject temp = Instantiate(sentence);
            temp.transform.SetParent(tutorial_Sentence.transform);
            temp.transform.GetComponent<RectTransform>().anchoredPosition =
                new Vector2(0, -200);
            temp.transform.localScale = new Vector3(1, 1, 1);
            int num = Random.Range(0, sentence_Text.Count);
            temp.transform.GetChild(0).GetComponent<Text>().text = sentence_Text[num];
            sentence_Text.RemoveAt(num);
        }
        else if (test == true)
        {
            GameObject temp = Instantiate(sentence);
            temp.transform.SetParent(stage3_Sentence.transform);
            temp.transform.GetComponent<RectTransform>().anchoredPosition =
                new Vector2(0, -400);
            temp.transform.localScale = new Vector3(1, 1, 1);
            int num = Random.Range(0, stage3_Text.Count);
            temp.transform.GetChild(0).GetComponent<Text>().text = stage3_Text[num];
            stage3_Text.RemoveAt(num);
        }
        
        yield return new WaitForSeconds(3.0f);

        isSentence = false;
    }

    public void Skip()
    {
        Check();
    }

    public void ReStart()
    {
        if (gameManager.pause.activeSelf == true)
        {
            var animator = gameManager.pause.GetComponent<Animator>();
            animator.Play("Close");
            Invoke("Pause_Close", 0.5f);
        }
        else
        {
            if (success.activeSelf == true)
            {
                var animator = success.GetComponent<Animator>();
                animator.Play("Close");
            }
            else if (fail.activeSelf == true)
            {
                var animator = fail.GetComponent<Animator>();
                animator.Play("Close");
            }
            
            Invoke("Success_Fail_Close", 0.5f);
        }
        
        Reset();
    }
    
    public void Next()
    {
        if (success.activeSelf == true)
        {
            if (gameManager.stage_Select_Level_Num == 1)
            {
                if (PlayerPrefs.GetInt("level") <= 4)
                {
                    PlayerPrefs.SetInt("level", 5);
                    gameManager.stage_Select_Level_Num = 2;
                }
            }
            else if (gameManager.stage_Select_Level_Num == 2)
            {
                if (PlayerPrefs.GetInt("level") <= 8)
                {
                    PlayerPrefs.SetInt("level", 9);
                    gameManager.stage_Select_Level_Num = 3;
                }
            }
            else if (gameManager.stage_Select_Level_Num == 3)
            {
                if (PlayerPrefs.GetInt("level") <= 12)
                {
                    PlayerPrefs.SetInt("level", 12);
                }
            }
            
            var animator = success.GetComponent<Animator>();
            animator.Play("Close");
        }
        else if (fail.activeSelf == true)
        {
            var animator = fail.GetComponent<Animator>();
            animator.Play("Close");
        }
        
        animManager.Fade_Out();
        Invoke("Success_Fail_Close", 0.5f);
    }
    
    public void Help()
    {
        PlayerPrefs.SetInt("Decent_Tutorial", 0);
        var animator = gameManager.pause.GetComponent<Animator>();
        animator.Play("Close");
        Reset();
        Invoke("Pause_Close", 0.5f);
    }
    
    void Success_Fail_Close()
    {
        if (success.activeSelf == true)
        {
            success.SetActive(false);
        }
        else if (fail.activeSelf == true)
        {
            fail.SetActive(false);
        }
    }
    
    void Pause_Close()
    {
        gameManager.buttons.transform.GetChild(0).gameObject.SetActive(false);
        gameManager.buttons.transform.GetChild(1).gameObject.SetActive(true);
        gameManager.buttons.transform.GetChild(2).gameObject.SetActive(false);
        gameManager.pause.SetActive(false);
    }

    public void Reset()
    {
        background.sprite = main_Background;
        blur.SetActive(true);
        tutorial.SetActive(true);
        isTutorial = false;
        isTutorial_Check = false;
        isTutorial_Check2 = false;
        tutorial_Notice_Num = 1;
        tutorial_True.SetActive(false);
        tutorial_Interpret.SetActive(false);
        tutorial_Notice.text = "탈중심화 연습을 시작합니다.";

        for (int i = 0; i < tutorial_Sentence.transform.childCount; i++)
        {
            Destroy(tutorial_Sentence.transform.GetChild(i).gameObject);
        }
        
        for (int i = 0; i < stage1_Buttons.Length; i++)
        {
            stage1_Buttons[i].GetComponent<Button>().interactable = true;
            stage1_Buttons[i].GetComponent<Button>().onClick.RemoveAllListeners();
        }

        stage = 1;
        game.SetActive(false);
        stage1.SetActive(true);
        stage1_cutToon.GetComponent<RectTransform>().offsetMin = new Vector2(0, -500);
        stage1_Notice_Image.SetActive(true);
        stage1_Button.SetActive(false);
        stage1_Notice_Num = 1;
        stage1_Notice.text = "아래 그림을 자세히 살펴봐주세요.";
        stage2.SetActive(false);
        stage2_Answer = 0;
        stage2_Notice.text = "아래의 앞서 선택한 4가지 감정이 있습니다.\n이 중 한 가지를 선택해주세요.";
        stage2_Emotion_Btn.SetActive(true);
        stage2_Main_Panel.SetActive(false);
        stage2_ScrollView.transform.GetChild(0).GetChild(0).GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 0);
        stage3.SetActive(false);
        stage4.SetActive(false);
        stage4_One.SetActive(true);
        stage4_Two.SetActive(false);
        stage4_Three.SetActive(false);
        stage4_Four.SetActive(false);
        stage4_Five.SetActive(false);
        stage4_Count = 1;

        for (int i = 0; i < stage2_ScrollView.transform.GetChild(0).GetChild(0).childCount; i++)
        {
            Destroy(stage2_ScrollView.transform.GetChild(0).GetChild(0).GetChild(i).gameObject);
        }
        
        for (int i = 0; i < stage3_Sentence.transform.childCount; i++)
        {
            Destroy(stage3_Sentence.transform.GetChild(i).gameObject);
        }
        
        for (int i = 0; i < stage5_Tutorial_Panel.transform.GetChild(2).childCount; i++)
        {
            Destroy(stage5_Tutorial.transform.GetChild(6).GetChild(i).gameObject);
        }
        
        for (int i = 0; i < stage5_Game.transform.GetChild(3).childCount; i++)
        {
            Destroy(stage5_Game.transform.GetChild(3).GetChild(i).gameObject);
        }
        
        stage5_Bar.GetComponent<Slider>().value = 0;
        stage5_Car.transform.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 150);
        stage5.SetActive(false);
        stage5_Tutorial.SetActive(true);
        stage5_isTutorial = false;
        stage5_isTutorial_Check = false;
        stage5_isTutorial_Check2 = false;
        stage5_Notice.text = "수용 연습을 시작합니다.";
        stage5_Notice_Num = 1;
        stage5_Game.SetActive(false);
        stage5_isTutorial = false;
        stage5_Tutorial_Panel.SetActive(false);
        stage5_Tutorial_Bar.GetComponent<Slider>().value = 0;
        stage5_Tutorial_Panel.SetActive(false);
        stage5_Count.SetActive(true);
        stage5_Count.GetComponent<Text>().text = "3";
        stage5_Count_Finish = false;
        stage5_Notice_Image.SetActive(true);
        stage5_Bar.GetComponent<Slider>().value = 0;
        stage6.SetActive(false);
        stage6_Char_Step1.SetActive(false);
        stage6_Char_Step2.SetActive(false);
        stage6_Char_Step3.SetActive(false);
        stage6_Bar.GetComponent<Slider>().value = 0;
        isSentence = false;
        sentence_Text = new List<string> {"우리 할머니의 머리는 점점 백발이 되고 있다.", "오늘 아침에 내 짝이 나를 보고 미소를 지었다.", "나는 생각하고 느끼는 존재이다.", "우리 엄마는 잔소리를 많이 한다.", "우리 아빠는 집안일을 잘 하지 않는다.", "내 동생은 다소 이기적이다.", "우리 반 친구들은 나를 싫어한다.", "내 친구들은 나를 보고도 모른 체 한다.", "내 초등학교 절친은 사회성이 부족하다.", "선생님들은 우리를 힘들게 한다.", "우리 회사의 사장님은 권위적이다.", "공부든 일이든 모두 나를 위한 것이다.", "적성을 아는 것이 진로 선택에 도움이 된다.", "나는 타인의 눈치를 많이 본다.", "나는 왕따이다.", "나는 자신감이 부족하다.", "운전하면서 중간에 끼어들면 안 된다.", "운전하면서 중간에 끼어들어도 괜찮다.", "경상도 남자들은 말이 별로 없다.", "안중근 의사는 애국자이다."};
        stage1_Text = new List<string> { "화난", "그리운", "불안한", "사랑스러운", "슬픈", "뿌듯한", "든든한", "괴로운", "열정적인" };
        stage2_Anger = new List<string>
        { "나는 잘못이 없어.", "이 친구는 나쁜 놈이야.", "참으면 나를 무시할 거야.", "일부러 나를 힘들게 해." };

        stage2_Unrest = new List<string>
        { "앞으로도 계속 괴롭히겠지.", "언제 또 당할지 몰라.", "모두 나를 바보처럼 보겠지.", "이제 학교생활은 끝이야." };

        stage2_Sadness = new List<string> {"내 편은 아무도 없어.", "언제나 나는 혼자야.", "아무런 희망이 안 보여.", "아무도 도와주지 않아."};
        stage2_Remorse = new List<string> {"나는 바보같아.", "내가 잘 못했어.", "다 나 때문이야.", "원래 나는 비호감이야."};
        stage2_Text = new List<string> { };
        stage3_True = new List<string> {"저 애가 나를 쳐다보고 있어.", "지금 엄마가 생각나.", "반 친구들이 여기를 보고 있네.", "나는 현재 긴장된 상태야.", "지금 어떻게 해야할지 고민이야.", "친구들이 가만히 있기만 하네.", "손에 힘이 들어가고 있어.", "목이 마르고 열이 나네."};
        stage3_Text = new List<string> { };
        stage5_Text = new List<string> { };
        stage6_Text = new List<string> {"너로 나름 최선을 다했잖아.", "잘했어.", "잘 하려고 한 거잖아.", "누구나 잘 하고 싶지.", "못하고 싶은 사람은 아무도 없어.", "네가 한 것은 다 잘 한거야.", "너도 좋은 사람이려고 한 거잖아."};
        isNext = false;
        shadow.SetActive(false);
        success.SetActive(false);
        fail.SetActive(false);
        tutorial_Notice_Image.SetActive(true);
        isFinish = false;
    }
}
