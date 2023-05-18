using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class Decent_Manager : MonoBehaviour
{
    public GameObject tutorial;
    public GameObject tutorial_Notice;
    public GameObject tutorial_True;
    public GameObject tutorial_Interpret;
    public GameObject tutorial_Sentence;
    public GameObject sentence;
    public GameObject game;
    public GameObject[] stage1_Buttons;
    private string stage2_Emotion;
    public GameObject stage2_Button;
    private int stage2_Answer = 0;
    private int stage4_Count = 1;
    public GameObject stage5_Bar;
    public GameObject stage5_Car;
    public GameObject fuel;
    public GameObject stage6_Bar;
    public GameObject shadow;
    public GameObject success;
    public GameObject fail;
    public bool isNext = false;
    public bool isSentence = false;
    public int stage = 1;
    GameManager gameManager;
    AnimManager animManager;
    WaitForEndOfFrame waitForEndOfFrame = new WaitForEndOfFrame();
    public bool isTutorial;
    private bool isTutorial_Check;
    private bool isTutorial_Check2;
    private List<string> sentence_Text = new List<string> {"우리 할머니의 머리는 점점 백발이 되고 있다", "오늘 아침에 내 짝이 나를 보고 미소를 지었다", "나는 생각하고 느끼는 존재이다", "우리 엄마는 잔소리를 많이 한다", "우리 아빠는 집안일을 잘 하지 않는다", "내 동생은 다소 이기적이다", "우리 반 친구들은 나를 싫어한다", "내 친구들은 나를 보고도 모른 체 한다", "내 초등학교 절친은 사회성이 부족하다", "선생님들은 우리를 힘들게 한다", "우리 회사의 사장님은 권위적이다", "공부든 일이든 모두 나를 위한 것이다", "적성을 아는 거이 진로 선택에 도움이 된다", "나는 타인의 눈치를 많이 본다", "나는 왕따이다", "나는 자신감이 부족하다", "운전하면서 중간에 끼어들면 안 된다", "운전하면서 중간에 끼어들어도 괜찮다", "경상도 남자들은 말이 별로 없다", "안중근 의사는 애국자이다"};
    private List<string> stage1_Text = new List<string> { "화난", "그리운", "불안한", "사랑스러운", "슬픈", "뿌듯한", "든든한", "괴로운", "열정적인" };
    private List<string> stage2_Anger = new List<string> { "나는 잘못이 없어", "이 친구는 나쁜 놈이야", "참으면 나를 무시할 거야", "일부러 나를 힘들게 해"};
    private List<string> stage2_Unrest = new List<string> { "앞으로도 계속 괴롭히겠지", "언제 또 당할지 몰라", "모두 나를 바보처럼 보겠지", "이제 학교생활은 끝이야"};
    private List<string> stage2_Sadness = new List<string> {"내 편은 아무도 없어", "언제나 나는 혼자야", "아무런 희망이 안 보여", "아무도 도와주지 않아"};
    private List<string> stage2_Remorse = new List<string> {"나는 바보같아", "내가 잘 못했어", "다 나 떄문이야", "원래 나는 비호감이야"};
    private List<string> stage2_Text = new List<string> { };
    private List<string> stage3_True = new List<string> {"저 애가 나를 쳐다보고 있어", "지금 엄마가 생각나", "반 친구들이 여기를 보고 있네", "나는 현재 긴장된 상태야", "지금 어떻게 해야할지 고민이야", "친구들이 가만히 있기만 하네", "손에 힘이 들어가고 있어", "목이 마르고 열이 나네"};
    private List<string> stage3_Text = new List<string> { };
    private List<string> stage5_Anger = new List<string> { "에이, 열받아", "머리에 열이 나는구나", "목 뒤쪽이 뻣뻣하다", "목소리가 커진다", "호흡이 빨라진다", "화가 올라왔다가 사라지는구나"};
    private List<string> stage5_Unrest = new List<string> { "긴장된다", "지금 가슴이 뛴다", "호흡이 빠르다", "말을 더듬는다", "무슨 말을 하는지 잘 모르겠다", "불안했구나"};
    private List<string> stage5_Sadness = new List<string> {"슬프다", "눈물이 난다", "아무것도 하고 싶지 않다", "가라앉는다", "귀찮다", "내가 우울했구나"};
    private List<string> stage5_Remorse = new List<string> {"실망스럽다", "내가 지금 어깨가 쳐지는구나", "목소리가 힘이 없다", "쪼그라든다", "주저앉고싶다", "애썼는데 아쉽네"};
    private List<string> stage5_Text = new List<string> { };
    private List<string> stage6_Text = new List<string> {"너로 나름 최선을 다했잖아", "잘했어", "잘 하려고 한 거잖아", "누구나 잘 하고 싶지", "못하고 싶은 사람은 아무도 없어", "네가 한 것은 다 잘 한거야", "너도 좋은 사람이려고 한 거잖아"};
    public GameObject stage1;
    public GameObject stage2;
    public GameObject stage3;
    public GameObject stage4;
    public GameObject stage5;
    public GameObject stage6;
    public int count = 0;

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
        Stage6();
    }
    
    void Tutorial()
    {
        if (isTutorial == false && isTutorial_Check == false)
        {
            isTutorial_Check = true;
            gameManager.Set2();
            gameManager.buttons.SetActive(false);
            
            if (gameManager.stage_Select_Level_Num == 1)
            {
                isTutorial = false;
            }
            else
            {
                isTutorial = true;
            }
        }
        else if (isTutorial == true && isTutorial_Check2 == false)
        {
            isTutorial_Check2 = true;
            
            for (int i = 0; i < stage1_Buttons.Length; i++)
            {
                int num = Random.Range(0, stage1_Text.Count);
                stage1_Buttons[i].transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = stage1_Text[num];
                stage1_Text.RemoveAt(num);

                if (stage1_Buttons[i].transform.GetChild(0).GetComponent<TextMeshProUGUI>().text == "화난" ||
                    stage1_Buttons[i].transform.GetChild(0).GetComponent<TextMeshProUGUI>().text == "슬픈" ||
                    stage1_Buttons[i].transform.GetChild(0).GetComponent<TextMeshProUGUI>().text == "괴로운" ||
                    stage1_Buttons[i].transform.GetChild(0).GetComponent<TextMeshProUGUI>().text == "불안한")
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
            gameManager.buttons.SetActive(true);
        }
    }
    
    public void Stage1_Btn(int num)
    {
        count = 0;
        stage2.transform.GetChild(0).GetChild(0).GetComponent<Button>().interactable = true;
        stage2.transform.GetChild(0).GetChild(0).GetChild(1).GetComponent<Image>().color = new Color(255, 255, 255, 1);
        stage2.transform.GetChild(0).GetChild(1).GetComponent<Button>().interactable = true;
        stage2.transform.GetChild(0).GetChild(1).GetChild(1).GetComponent<Image>().color = new Color(255, 255, 255, 1);
        stage2.transform.GetChild(0).GetChild(2).GetComponent<Button>().interactable = true;
        stage2.transform.GetChild(0).GetChild(2).GetChild(1).GetComponent<Image>().color = new Color(255, 255, 255, 1);
        stage2.transform.GetChild(0).GetChild(3).GetComponent<Button>().interactable = true;
        stage2.transform.GetChild(0).GetChild(3).GetChild(1).GetComponent<Image>().color = new Color(255, 255, 255, 1);
        
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
            stage2.transform.GetChild(0).GetChild(0).GetComponent<Button>().interactable = false;
            stage2.transform.GetChild(0).GetChild(0).GetChild(1).GetComponent<Image>().color = new Color(255, 255, 255, 0.3f);
        }
        else if (type == "Unrest")
        {
            stage2.transform.GetChild(0).GetChild(1).GetComponent<Button>().interactable = false;
            stage2.transform.GetChild(0).GetChild(1).GetChild(1).GetComponent<Image>().color = new Color(255, 255, 255, 0.3f);
        }
        else if (type == "Sadness")
        {
            stage2.transform.GetChild(0).GetChild(2).GetComponent<Button>().interactable = false;
            stage2.transform.GetChild(0).GetChild(2).GetChild(1).GetComponent<Image>().color = new Color(255, 255, 255, 0.3f);
        }
        else if (type == "Remorse")
        {
            stage2.transform.GetChild(0).GetChild(3).GetComponent<Button>().interactable = false;
            stage2.transform.GetChild(0).GetChild(3).GetChild(1).GetComponent<Image>().color = new Color(255, 255, 255, 0.3f);
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
                temp.transform.SetParent(stage2.transform.GetChild(3).GetChild(0).GetChild(0));
                temp.transform.localScale = new Vector3(1f, 1f, 1f);
                int num = Random.Range(0, stage2_Text.Count);
                temp.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = stage2_Text[num];
                stage2_Text.RemoveAt(num);
                
                if (temp.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text == "나는 잘못이 없어" || temp.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text == "이 친구는 나쁜 놈이야" || temp.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text == "참으면 나를 무시할 거야" || temp.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text == "일부러 나를 힘들게 해")
                {
                    temp.GetComponent<Button>().onClick.AddListener(() => Stage2_Check("Anger"));
                }
                else if (temp.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text == "앞으로도 계속 괴롭히겠지" || temp.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text == "언제 또 당할지 몰라" || temp.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text == "모두 나를 바보처럼 보겠지" || temp.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text == "이제 학교생활은 끝이야")
                {
                    temp.GetComponent<Button>().onClick.AddListener(() => Stage2_Check("Unrest"));
                }
                else if (temp.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text == "내 편은 아무도 없어" || temp.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text == "언제나 나는 혼자야" || temp.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text == "아무런 희망이 안 보여" || temp.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text == "아무도 도와주지 않아")
                {
                    temp.GetComponent<Button>().onClick.AddListener(() => Stage2_Check("Sadness"));
                }
                else if (temp.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text == "나는 바보같아" || temp.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text == "내가 잘 못했어" || temp.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text == "다 나 떄문이야" || temp.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text == "원래 나는 비호감이야")
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
                temp.transform.SetParent(stage2.transform.GetChild(3).GetChild(0).GetChild(0));
                temp.transform.localScale = new Vector3(1f, 1f, 1f);
                int num = Random.Range(0, stage2_Text.Count);
                temp.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = stage2_Text[num];
                stage2_Text.RemoveAt(num);
                
                if (temp.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text == "나는 잘못이 없어" || temp.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text == "이 친구는 나쁜 놈이야" || temp.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text == "참으면 나를 무시할 거야" || temp.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text == "일부러 나를 힘들게 해")
                {
                    temp.GetComponent<Button>().onClick.AddListener(() => Stage2_Check("Anger"));
                }
                else if (temp.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text == "앞으로도 계속 괴롭히겠지" || temp.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text == "언제 또 당할지 몰라" || temp.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text == "모두 나를 바보처럼 보겠지" || temp.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text == "이제 학교생활은 끝이야")
                {
                    temp.GetComponent<Button>().onClick.AddListener(() => Stage2_Check("Unrest"));
                }
                else if (temp.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text == "내 편은 아무도 없어" || temp.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text == "언제나 나는 혼자야" || temp.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text == "아무런 희망이 안 보여" || temp.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text == "아무도 도와주지 않아")
                {
                    temp.GetComponent<Button>().onClick.AddListener(() => Stage2_Check("Sadness"));
                }
                else if (temp.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text == "나는 바보같아" || temp.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text == "내가 잘 못했어" || temp.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text == "다 나 떄문이야" || temp.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text == "원래 나는 비호감이야")
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
                temp.transform.SetParent(stage2.transform.GetChild(3).GetChild(0).GetChild(0));
                temp.transform.localScale = new Vector3(1f, 1f, 1f);
                int num = Random.Range(0, stage2_Text.Count);
                temp.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = stage2_Text[num];
                stage2_Text.RemoveAt(num);

                if (temp.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text == "나는 잘못이 없어" || temp.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text == "이 친구는 나쁜 놈이야" || temp.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text == "참으면 나를 무시할 거야" || temp.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text == "일부러 나를 힘들게 해")
                {
                    temp.GetComponent<Button>().onClick.AddListener(() => Stage2_Check("Anger"));
                }
                else if (temp.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text == "앞으로도 계속 괴롭히겠지" || temp.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text == "언제 또 당할지 몰라" || temp.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text == "모두 나를 바보처럼 보겠지" || temp.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text == "이제 학교생활은 끝이야")
                {
                    temp.GetComponent<Button>().onClick.AddListener(() => Stage2_Check("Unrest"));
                }
                else if (temp.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text == "내 편은 아무도 없어" || temp.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text == "언제나 나는 혼자야" || temp.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text == "아무런 희망이 안 보여" || temp.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text == "아무도 도와주지 않아")
                {
                    temp.GetComponent<Button>().onClick.AddListener(() => Stage2_Check("Sadness"));
                }
                else if (temp.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text == "나는 바보같아" || temp.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text == "내가 잘 못했어" || temp.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text == "다 나 떄문이야" || temp.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text == "원래 나는 비호감이야")
                {
                    temp.GetComponent<Button>().onClick.AddListener(() => Stage2_Check("Remorse"));
                }
            }
        }
        
        stage2.transform.GetChild(0).gameObject.SetActive(false);
        stage2.transform.GetChild(1).gameObject.SetActive(true);
        stage2.transform.GetChild(2).gameObject.SetActive(true);
        stage2.transform.GetChild(3).gameObject.SetActive(true);
    }

    public void Stage2_Check(string type)
    {
        if (stage2_Emotion == type)
        {
            stage3_Text.Add(EventSystem.current.currentSelectedGameObject.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text);
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
                    
                    stage2.SetActive(false);
                    stage3.SetActive(true);
                    stage = 3;
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
                    
                    stage2.SetActive(false);
                    stage3.SetActive(true);
                    stage = 3;
                }
            }
        }
        else
        {
            EventSystem.current.currentSelectedGameObject.GetComponent<Image>().color = Color.black;
            EventSystem.current.currentSelectedGameObject.GetComponent<Button>().interactable = false;
        }
    }

    public void Stage4_Btn()
    {
        if (stage4_Count == 1)
        {
            stage4.transform.GetChild(1).gameObject.SetActive(false);
            stage4.transform.GetChild(2).gameObject.SetActive(true);
        }
        else if (stage4_Count == 2)
        {
            stage4.transform.GetChild(2).gameObject.SetActive(false);
            stage4.transform.GetChild(3).gameObject.SetActive(true);
        }
        else if (stage4_Count == 3)
        {
            stage4.SetActive(false);
            stage5.SetActive(true);
            stage = 5;
        }

        stage4_Count++;
    }
    
    void Fuel()
    {
        if (isTutorial == true && stage == 5 && isSentence == false)
        {
            isSentence = true;
            
            if (stage5_Bar.transform.GetChild(0).GetComponent<Image>().fillAmount != 1)
            {
                StartCoroutine("FuelGenerator");
            }
            else if (stage5_Bar.transform.GetChild(0).GetComponent<Image>().fillAmount == 1)
            {
                Invoke("Check", 0.5f);
            }
        }
    }
    
    IEnumerator FuelGenerator()
    {
        GameObject temp = Instantiate(fuel);
        temp.transform.SetParent(stage5.transform.GetChild(3));
        temp.transform.GetComponent<RectTransform>().anchoredPosition =
            new Vector2(Random.Range(-300, 400), -200);
        temp.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        int num = Random.Range(0, stage5_Text.Count);
        temp.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = stage5_Text[num];
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
        
        float delay = 0;

        while (delay < 0.6f)
        {
            delay += Time.deltaTime;
            yield return waitForEndOfFrame;
        }
    
        isSentence = false;
    }
    
    void Stage6()
    {
        if (isTutorial == true && stage == 6 && isSentence == false)
        {
            isSentence = true;
            
            if (stage6_Bar.transform.GetChild(0).GetComponent<Image>().fillAmount != 1 && stage6_Text.Count != 0)
            {
                //StartCoroutine("MentGenerator");
            }
            else if (stage6_Bar.transform.GetChild(0).GetComponent<Image>().fillAmount == 1)
            {
                Invoke("Check", 0.5f);
            }
        }
    }
    
    IEnumerator MentGenerator()
    {
        GameObject temp = Instantiate(fuel);
        temp.transform.SetParent(stage6.transform.GetChild(2));
        temp.transform.GetComponent<RectTransform>().anchoredPosition =
            new Vector2(Random.Range(-300, 400), -200);
        temp.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
        int num = Random.Range(0, stage6_Text.Count);
        temp.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = stage6_Text[num];
        stage6_Text.RemoveAt(num);

        float delay = 0;

        while (delay < 1f)
        {
            delay += Time.deltaTime;
            yield return waitForEndOfFrame;
        }
    
        isSentence = false;
    }

    void Check()
    {
        if (isTutorial == false)
        {
            isTutorial = true;
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
                stage5_Bar.transform.GetChild(0).GetComponent<Image>().fillAmount = 0;
                stage5_Car.transform.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 150);
                count++;
                stage5.SetActive(false);

                if (count != 4)
                {
                    Reset();
                    isTutorial = true;
                    stage1.SetActive(false);
                    stage2.SetActive(true);
                    stage = 2;
                }
                else if (count == 4)
                {
                    isNext = true;
                    animManager.Fade_Out();
                }
            }
            else if (stage == 6)
            {
                shadow.SetActive(true);
                success.SetActive(true);
            }
        }
    }

    void Sentence()
    {
        if (isTutorial == false && isSentence == false)
        {
            if (sentence_Text.Count != 0)
            {
                isSentence = true;
                StartCoroutine("SentenceGenerator");
            }
            else if (sentence_Text.Count == 0)
            {
                if (tutorial.transform.GetChild(5).childCount == 0)
                {
                    tutorial_Notice.SetActive(true);
                    tutorial_True.SetActive(false);
                    tutorial_Interpret.SetActive(false);
                    Check();
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
                if (stage3.transform.GetChild(2).childCount == 0)
                {
                    Check();
                }
            }
        }
    }
    
    IEnumerator SentenceGenerator()
    {
        bool test = isTutorial;
        
        float delay = 0;

        while (delay < 1.5f)
        {
            delay += Time.deltaTime;
            yield return waitForEndOfFrame;
        }
        
        if (test == false)
        {
            GameObject temp = Instantiate(sentence);
            temp.transform.SetParent(tutorial.transform.GetChild(5));
            temp.transform.GetComponent<RectTransform>().anchoredPosition =
                new Vector2(0, -200);
            temp.transform.localScale = new Vector3(1, 1, 1);
            int num = Random.Range(0, sentence_Text.Count);
            temp.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = sentence_Text[num];
            sentence_Text.RemoveAt(num);
        }
        else if (test == true)
        {
            GameObject temp = Instantiate(sentence);
            temp.transform.SetParent(stage3.transform.GetChild(2));
            temp.transform.GetComponent<RectTransform>().anchoredPosition =
                new Vector2(0, -200);
            temp.transform.localScale = new Vector3(1, 1, 1);
            int num = Random.Range(0, stage3_Text.Count);
            temp.transform.GetChild(0).GetComponent<TextMeshProUGUI>().text = stage3_Text[num];
            stage3_Text.RemoveAt(num);
        }

        isSentence = false;
    }

    public void Skip()
    {
        Check();
    }

    public void ReStart()
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

        Reset();
        Invoke("Success_Fail_Close", 0.5f);
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
                }
            }
            else if (gameManager.stage_Select_Level_Num == 2)
            {
                if (PlayerPrefs.GetInt("level") <= 8)
                {
                    PlayerPrefs.SetInt("level", 9);
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

    public void Reset()
    {
        tutorial.SetActive(true);
        isTutorial = false;
        isTutorial_Check = false;
        isTutorial_Check2 = false;
        tutorial_Notice.SetActive(false);
        tutorial_True.SetActive(true);
        tutorial_Interpret.SetActive(true);

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
        stage2.SetActive(false);
        stage2.transform.GetChild(0).gameObject.SetActive(true);
        stage2.transform.GetChild(1).gameObject.SetActive(false);
        stage2.transform.GetChild(2).gameObject.SetActive(false);
        stage2.transform.GetChild(3).gameObject.SetActive(false);
        stage2.transform.GetChild(3).GetChild(0).GetChild(0).GetComponent<RectTransform>().anchoredPosition =
            new Vector2(0, 0);
        stage3.SetActive(false);
        stage4.SetActive(false);
        stage4.transform.GetChild(1).gameObject.SetActive(true);
        stage4.transform.GetChild(2).gameObject.SetActive(false);
        stage4.transform.GetChild(3).gameObject.SetActive(false);
        stage4_Count = 1;

        for (int i = 0; i < stage2.transform.GetChild(3).GetChild(0).GetChild(0).childCount; i++)
        {
            Destroy(stage2.transform.GetChild(3).GetChild(0).GetChild(0).GetChild(i).gameObject);
        }
        
        for (int i = 0; i < stage3.transform.GetChild(2).childCount; i++)
        {
            Destroy(stage3.transform.GetChild(2).GetChild(i).gameObject);
        }
        
        for (int i = 0; i < stage5.transform.GetChild(3).childCount; i++)
        {
            Destroy(stage5.transform.GetChild(3).GetChild(i).gameObject);
        }
        
        stage5_Bar.transform.GetChild(0).GetComponent<Image>().fillAmount = 0;
        stage5_Car.transform.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 150);
        stage5.SetActive(false);
        stage6.SetActive(false);
        stage6_Bar.transform.GetChild(0).GetComponent<Image>().fillAmount = 0;
        stage2_Answer = 0;
        isSentence = false;
        sentence_Text = new List<string> {"우리 할머니의 머리는 점점 백발이 되고 있다", "오늘 아침에 내 짝이 나를 보고 미소를 지었다", "나는 생각하고 느끼는 존재이다", "우리 엄마는 잔소리를 많이 한다", "우리 아빠는 집안일을 잘요 하지 않는다", "내 동생은 다소 이기적이다", "우리 반 친구들은 나를 싫어한다", "내 친구들은 나를 보고도 모른 체 한다", "내 초등학교 절친은 사회성이 부족하다", "선생님들은 우리를 힘들게 한다", "우리 회사의 사장님은 권위적이다", "공부든 일이든 모두 나를 위한 것이다", "적성을 아는 거이 진로 선택에 도움이 된다", "나는 타인의 눈치를 많이 본다", "나는 왕따이다", "나는 자신감이 부족하다", "운전하면서 중간에 끼어들면 안 된다", "운전하면서 중간에 끼어들어도 괜찮다", "경상도 남자들은 말이 별로 없다", "안중근 의사는 애국자이다"};
        stage1_Text = new List<string> { "화난", "그리운", "불안한", "사랑스러운", "슬픈", "뿌듯한", "든든한", "괴로운", "열정적인" };
        stage2_Anger = new List<string>
        { "나는 잘못이 없어", "이 친구는 나쁜 놈이야", "참으면 나를 무시할 거야", "일부러 나를 힘들게 해" };

        stage2_Unrest = new List<string>
        { "앞으로도 계속 괴롭히겠지", "언제 또 당할지 몰라", "모두 나를 바보처럼 보겠지", "이제 학교생활은 끝이야" };

        stage2_Sadness = new List<string> {"내 편은 아무도 없어", "언제나 나는 혼자야", "아무런 희망이 안 보여", "아무도 도와주지 않아"};
        stage2_Remorse = new List<string> {"나는 바보같아", "내가 잘 못했어", "다 나 떄문이야", "원래 나는 비호감이야"};
        stage2_Text = new List<string> { };
        stage3_True = new List<string> {"저 애가 나를 쳐다보고 있어", "지금 엄마가 생각나", "반 친구들이 여기를 보고 있네", "나는 현재 긴장된 상태야", "지금 어떻게 해야할지 고민이야", "친구들이 가만히 있기만 하네", "손에 힘이 들어가고 있어", "목이 마르고 열이 나네"};
        stage3_Text = new List<string> { };
        stage5_Text = new List<string> { };
        stage6_Text = new List<string> {"너로 나름 최선을 다했잖아", "잘했어", "잘 하려고 한 거잖아", "누구나 잘 하고 싶지", "못하고 싶은 사람은 아무도 없어", "네가 한 것은 다 잘 한거야", "너도 좋은 사람이려고 한 거잖아"};
        isNext = false;
        shadow.SetActive(false);
        success.SetActive(false);
        fail.SetActive(false);
    }
}
