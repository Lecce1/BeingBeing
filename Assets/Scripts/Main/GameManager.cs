using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject splash;
    public GameObject main;
    public GameObject main_Background;
    public GameObject main_Logo;
    public TMP_Text main_Text;
    public GameObject stage;
    public Image stage_Char;
    public GameObject[] stage_Select_Step;
    public GameObject[] stage_Select_Buttons;
    public GameObject stage_Select_Stage;
    public Text stage_Select_Stage_Title;
    public Text stage_Select_Stage_Content;
    public GameObject stage_Select_Stage_Start;
    public GameObject stage_Select_Stage_Recog_Start;
    public List<GameObject> stage_Road;
    public GameObject set;
    public GameObject notice;
    public GameObject quit;
    public Slider set_Music;
    public Image set_Music_Image;
    public Slider set_Vibrate;
    public Image set_Vibrate_Image;
    public Slider set_Voice;
    public Image set_Voice_Image;
    public Sprite toggleOn;
    public Sprite toggleOff;
    public GameObject loading;
    public AnimManager animManager;
    public BGMManager bgmManager;
    public List<Sprite> charLevel;

    void Start()
    {
        StartCoroutine("Init");
    }

    IEnumerator Init()
    {
        while (!DBManager.instance.isLoaded)
        {
            yield return null;
        }
        
        Set();
        Data();

        if (!DBManager.instance.isStageFirst)
        {
            DBManager.instance.isStageFirst = true;
            Splash();
        }
        else
        {
            GotoStage();
        }
    }

    public void Set()
    {
        DBManager.instance.Renewal();
        
        for (int i = 0; i < 4; i++)
        {
            stage_Select_Buttons[i].SetActive(false);
        }
        
        for (int i = 0; i < stage_Road.Count; i++)
        {
            stage_Road[i].SetActive(false);
        }

        if (DBManager.instance.level == 0)
        {
            PlayerPrefs.SetInt("level", 1);
            int index = PlayerPrefs.GetInt("level");

            for (int i = 0; i < index; i++)
            {
                stage_Select_Buttons[i].SetActive(true);
            }
                
            stage_Select_Step[0].GetComponent<Button>().interactable = true;
            stage_Select_Step[1].GetComponent<Button>().interactable = false;
            stage_Select_Step[2].GetComponent<Button>().interactable = false;
            stage_Char.sprite = charLevel[0];
        }
        else
        {
            int index = PlayerPrefs.GetInt("level");

            if (DBManager.instance.currentStep == 1)
            {
                stage_Select_Step[0].transform.GetChild(1).GetComponent<Image>().enabled = true;
                stage_Select_Step[1].transform.GetChild(1).GetComponent<Image>().enabled = false;
                stage_Select_Step[2].transform.GetChild(1).GetComponent<Image>().enabled = false;
                
                if (index <= 4)
                {
                    stage_Select_Step[0].GetComponent<Button>().interactable = true;
                    stage_Select_Step[1].GetComponent<Button>().interactable = false;
                    stage_Select_Step[2].GetComponent<Button>().interactable = false;
                }
                else if (index >= 5 && index <= 8)
                {
                    stage_Select_Step[0].GetComponent<Button>().interactable = true;
                    stage_Select_Step[1].GetComponent<Button>().interactable = true;
                    stage_Select_Step[2].GetComponent<Button>().interactable = false;
                }
                else
                {
                    stage_Select_Step[0].GetComponent<Button>().interactable = true;
                    stage_Select_Step[1].GetComponent<Button>().interactable = true;
                    stage_Select_Step[2].GetComponent<Button>().interactable = true;
                }
            }
            else if (DBManager.instance.currentStep == 2)
            {
                stage_Select_Step[0].transform.GetChild(1).GetComponent<Image>().enabled = false;
                stage_Select_Step[1].transform.GetChild(1).GetComponent<Image>().enabled = true;
                stage_Select_Step[2].transform.GetChild(1).GetComponent<Image>().enabled = false;
                
                if (index >= 5 && index <= 8)
                {
                    stage_Select_Step[0].GetComponent<Button>().interactable = true;
                    stage_Select_Step[1].GetComponent<Button>().interactable = true;
                    stage_Select_Step[2].GetComponent<Button>().interactable = false;
                }
                else
                {
                    stage_Select_Step[0].GetComponent<Button>().interactable = true;
                    stage_Select_Step[1].GetComponent<Button>().interactable = true;
                    stage_Select_Step[2].GetComponent<Button>().interactable = true;
                }
            }
            else if (DBManager.instance.currentStep == 3)
            {
                stage_Select_Step[0].transform.GetChild(1).GetComponent<Image>().enabled = false;
                stage_Select_Step[1].transform.GetChild(1).GetComponent<Image>().enabled = false;
                stage_Select_Step[2].transform.GetChild(1).GetComponent<Image>().enabled = true;
                stage_Select_Step[0].GetComponent<Button>().interactable = true;
                stage_Select_Step[1].GetComponent<Button>().interactable = true;
                stage_Select_Step[2].GetComponent<Button>().interactable = true;
            }
            
            if (DBManager.instance.currentStep == 1)
            {
                stage_Char.sprite = charLevel[0];
                
                if (index <= 4)
                {
                    for (int i = 0; i < index; i++)
                    {
                        stage_Select_Buttons[i].SetActive(true);
                    }
                    
                    if (index == 2)
                    {
                        stage_Road[0].SetActive(true);
                        stage_Road[1].SetActive(true);
                    }
                    else if (index == 3)
                    {
                        stage_Road[0].SetActive(true);
                        stage_Road[1].SetActive(true);
                        stage_Road[2].SetActive(true);
                        stage_Road[3].SetActive(true);
                    }
                    else if (index == 4)
                    {
                        stage_Road[0].SetActive(true);
                        stage_Road[1].SetActive(true);
                        stage_Road[2].SetActive(true);
                        stage_Road[3].SetActive(true);
                        stage_Road[4].SetActive(true);
                        stage_Road[5].SetActive(true);
                        stage_Road[6].SetActive(true);
                        stage_Road[7].SetActive(true);
                    }
                }
                else
                {
                    for (int i = 0; i < 4; i++)
                    {
                        stage_Select_Buttons[i].SetActive(true);
                    }
                    
                    stage_Road[0].SetActive(true);
                    stage_Road[1].SetActive(true);
                    stage_Road[2].SetActive(true);
                    stage_Road[3].SetActive(true);
                    stage_Road[4].SetActive(true);
                    stage_Road[5].SetActive(true);
                    stage_Road[6].SetActive(true);
                    stage_Road[7].SetActive(true);
                }
            }
            else if (DBManager.instance.currentStep == 2)
            {
                stage_Char.sprite = charLevel[1];
                
                if (index >= 5 && index <= 8)
                {
                    for (int i = 0; i < index - 4; i++)
                    {
                        stage_Select_Buttons[i].SetActive(true);
                    }
                    
                    if (index == 6)
                    {
                        stage_Road[0].SetActive(true);
                        stage_Road[1].SetActive(true);
                    }
                    else if (index == 7)
                    {
                        stage_Road[0].SetActive(true);
                        stage_Road[1].SetActive(true);
                        stage_Road[2].SetActive(true);
                        stage_Road[3].SetActive(true);
                    }
                    else if (index == 8)
                    {
                        stage_Road[0].SetActive(true);
                        stage_Road[1].SetActive(true);
                        stage_Road[2].SetActive(true);
                        stage_Road[3].SetActive(true);
                        stage_Road[4].SetActive(true);
                        stage_Road[5].SetActive(true);
                        stage_Road[6].SetActive(true);
                        stage_Road[7].SetActive(true);
                    }
                }
                else
                {
                    for (int i = 0; i < 4; i++)
                    {
                        stage_Select_Buttons[i].SetActive(true);
                    }
                    
                    stage_Road[0].SetActive(true);
                    stage_Road[1].SetActive(true);
                    stage_Road[2].SetActive(true);
                    stage_Road[3].SetActive(true);
                    stage_Road[4].SetActive(true);
                    stage_Road[5].SetActive(true);
                    stage_Road[6].SetActive(true);
                    stage_Road[7].SetActive(true);
                }
            }
            else if (DBManager.instance.currentStep == 3)
            {
                stage_Char.sprite = charLevel[2];
                
                if (index >= 9)
                {
                    for (int i = 0; i < index - 8; i++)
                    {
                        stage_Select_Buttons[i].SetActive(true);
                    }
                    
                    if (index == 10)
                    {
                        stage_Road[0].SetActive(true);
                        stage_Road[1].SetActive(true);
                    }
                    else if (index == 11)
                    {
                        stage_Road[0].SetActive(true);
                        stage_Road[1].SetActive(true);
                        stage_Road[2].SetActive(true);
                        stage_Road[3].SetActive(true);
                    }
                    else if (index == 12)
                    {
                        stage_Road[0].SetActive(true);
                        stage_Road[1].SetActive(true);
                        stage_Road[2].SetActive(true);
                        stage_Road[3].SetActive(true);
                        stage_Road[4].SetActive(true);
                        stage_Road[5].SetActive(true);
                        stage_Road[6].SetActive(true);
                        stage_Road[7].SetActive(true);
                    }
                }
            }
        }
    }
    
    void Splash()
    {
        if (splash.activeSelf)
        {
            animManager.Splash();
        }
    }

    void Data()
    {
        DBManager.instance.level = PlayerPrefs.GetInt("level");
        set_Music.value = DBManager.instance.musicValue;

        if (set_Music.value == 0)
        {
            set_Music_Image.sprite = toggleOff;
        }
        else if (set_Music.value == 1)
        {
            set_Music_Image.sprite = toggleOn;
        }
            
        bgmManager.bgmAudioSource.volume = set_Music.value;
        
        set_Vibrate.value = DBManager.instance.vibrateValue;
            
        if (set_Vibrate.value == 0)
        {
            set_Vibrate_Image.sprite = toggleOff;
        }
        else if (set_Vibrate.value == 1)
        {
            set_Vibrate_Image.sprite = toggleOn;
        }
        
        set_Voice.value = DBManager.instance.soundValue;
            
        if (set_Voice.value == 0)
        {
            set_Voice_Image.sprite = toggleOff;
        }
        else if (set_Voice.value == 1)
        {
            set_Voice_Image.sprite = toggleOn;
        }
            
        bgmManager.voiceAudioSource.volume = set_Voice.value;
    }
    
    IEnumerator Main_Text()
    {
        main_Text.text = "반갑습니다!";
        BGMManager.instance.PlayBGM("Main_Text_1");
        
        float delay = 0;
        
        while (main_Text.color.a < 1)
        {
            main_Text.color = new Color(main_Text.color.r, main_Text.color.g, main_Text.color.b, main_Text.color.a + Time.deltaTime);
            yield return null;
        }

        while (delay < 3)
        {
            delay += Time.deltaTime;
            yield return null;
        }

        delay = 0;
        
        while (main_Text.color.a > 0)
        {
            main_Text.color = new Color(main_Text.color.r, main_Text.color.g, main_Text.color.b, main_Text.color.a - Time.deltaTime);
            yield return null;
        }

        main_Text.text = "빙빙을 찾아주셔서\n감사합니다.";
        BGMManager.instance.PlayBGM("Main_Text_2");
        
        while (main_Text.color.a < 1)
        {
            main_Text.color = new Color(main_Text.color.r, main_Text.color.g, main_Text.color.b, main_Text.color.a + Time.deltaTime);
            yield return null;
        }

        while (delay < 3)
        {
            delay += Time.deltaTime;
            yield return null;
        }

        delay = 0;
        
        while (main_Text.color.a > 0)
        {
            main_Text.color = new Color(main_Text.color.r, main_Text.color.g, main_Text.color.b, main_Text.color.a - Time.deltaTime);
            yield return null;
        }
        
        main_Text.text = "BeingBeing은\n자기이해, 자기수용, 자기사랑의\n실현하는 삶을 말합니다.";
        BGMManager.instance.PlayBGM("Main_Text_3");
        
        while (main_Text.color.a < 1)
        {
            main_Text.color = new Color(main_Text.color.r, main_Text.color.g, main_Text.color.b, main_Text.color.a + Time.deltaTime);
            yield return null;
        }
        
        while (delay < 6)
        {
            delay += Time.deltaTime;
            yield return null;
        }

        delay = 0;
        
        while (main_Text.color.a > 0)
        {
            main_Text.color = new Color(main_Text.color.r, main_Text.color.g, main_Text.color.b, main_Text.color.a - (Time.deltaTime * 0.5f));
            yield return null;
        }
        
        main_Text.text = "빙빙과 함께 자신감과 행복을\n찾아가는 여행을 시작해봅시다.";
        BGMManager.instance.PlayBGM("Main_Text_4");
        
        while (main_Text.color.a < 1)
        {
            main_Text.color = new Color(main_Text.color.r, main_Text.color.g, main_Text.color.b, main_Text.color.a + (Time.deltaTime * 0.5f));
            yield return null;
        }
        
        while (delay < 3)
        {
            delay += Time.deltaTime;
            yield return null;
        }

        while (main_Text.color.a > 0)
        {
            main_Text.color = new Color(main_Text.color.r, main_Text.color.g, main_Text.color.b, main_Text.color.a - (Time.deltaTime * 0.5f));
            yield return null;
        }
        
        loading.SetActive(true);
        Invoke(nameof(GotoStage), 3f);
    }

    void GotoStage()
    {
        main.SetActive(false);
        stage.SetActive(true);
        loading.SetActive(false);

        if (!BGMManager.instance.bgmAudioSource.isPlaying)
        {
            BGMManager.instance.PlayBGM("Main_BGM");
        }
    }
    
    public void Stage_Select_Buttons(int num)
    {
        for (int i = 0; i < 4; i++)
        {
            stage_Select_Buttons[i].SetActive(false);
        }
        
        for (int i = 0; i < stage_Road.Count; i++)
        {
            stage_Road[i].SetActive(false);
        }

        DBManager.instance.currentStep = num;
        int index = PlayerPrefs.GetInt("level");

        if (num == 1)
        {
            stage_Char.sprite = charLevel[0];
            stage_Select_Step[0].transform.GetChild(1).GetComponent<Image>().enabled = true;
            stage_Select_Step[1].transform.GetChild(1).GetComponent<Image>().enabled = false;
            stage_Select_Step[2].transform.GetChild(1).GetComponent<Image>().enabled = false;

            if (index <= 4)
            {
                for (int i = 0; i < index; i++)
                {
                    stage_Select_Buttons[i].SetActive(true);
                }
                
                if (index == 2)
                {
                    stage_Road[0].SetActive(true);
                    stage_Road[1].SetActive(true);
                }
                else if (index == 3)
                {
                    stage_Road[0].SetActive(true);
                    stage_Road[1].SetActive(true);
                    stage_Road[2].SetActive(true);
                    stage_Road[3].SetActive(true);
                }
                else if (index == 4)
                {
                    stage_Road[0].SetActive(true);
                    stage_Road[1].SetActive(true);
                    stage_Road[2].SetActive(true);
                    stage_Road[3].SetActive(true);
                    stage_Road[4].SetActive(true);
                    stage_Road[5].SetActive(true);
                    stage_Road[6].SetActive(true);
                    stage_Road[7].SetActive(true);
                }
            }
            else
            {
                for (int i = 0; i < 4; i++)
                {
                    stage_Select_Buttons[i].SetActive(true);
                }
                
                stage_Road[0].SetActive(true);
                stage_Road[1].SetActive(true);
                stage_Road[2].SetActive(true);
                stage_Road[3].SetActive(true);
                stage_Road[4].SetActive(true);
                stage_Road[5].SetActive(true);
                stage_Road[6].SetActive(true);
                stage_Road[7].SetActive(true);
            }
        }
        else if (num == 2)
        {
            stage_Char.sprite = charLevel[1];
            stage_Select_Step[0].transform.GetChild(1).GetComponent<Image>().enabled = false;
            stage_Select_Step[1].transform.GetChild(1).GetComponent<Image>().enabled = true;
            stage_Select_Step[2].transform.GetChild(1).GetComponent<Image>().enabled = false;

            if (index >= 5 && index <= 8)
            {
                for (int i = 0; i < index - 4; i++)
                {
                    stage_Select_Buttons[i].SetActive(true);
                }
                
                if (index == 6)
                {
                    stage_Road[0].SetActive(true);
                    stage_Road[1].SetActive(true);
                }
                else if (index == 7)
                {
                    stage_Road[0].SetActive(true);
                    stage_Road[1].SetActive(true);
                    stage_Road[2].SetActive(true);
                    stage_Road[3].SetActive(true);
                }
                else if (index == 8)
                {
                    stage_Road[0].SetActive(true);
                    stage_Road[1].SetActive(true);
                    stage_Road[2].SetActive(true);
                    stage_Road[3].SetActive(true);
                    stage_Road[4].SetActive(true);
                    stage_Road[5].SetActive(true);
                    stage_Road[6].SetActive(true);
                    stage_Road[7].SetActive(true);
                }
            }
            else if (index >= 9)
            {
                for (int i = 0; i < 4; i++)
                {
                    stage_Select_Buttons[i].SetActive(true);
                }
                
                stage_Road[0].SetActive(true);
                stage_Road[1].SetActive(true);
                stage_Road[2].SetActive(true);
                stage_Road[3].SetActive(true);
                stage_Road[4].SetActive(true);
                stage_Road[5].SetActive(true);
                stage_Road[6].SetActive(true);
                stage_Road[7].SetActive(true);
            }
        }
        else if (num == 3)
        {
            stage_Char.sprite = charLevel[2];
            stage_Select_Step[0].transform.GetChild(1).GetComponent<Image>().enabled = false;
            stage_Select_Step[1].transform.GetChild(1).GetComponent<Image>().enabled = false;
            stage_Select_Step[2].transform.GetChild(1).GetComponent<Image>().enabled = true;
            
            if (index >= 9)
            {
                for (int i = 0; i < index - 8; i++)
                {
                    stage_Select_Buttons[i].SetActive(true);
                }
                
                if (index == 10)
                {
                    stage_Road[0].SetActive(true);
                    stage_Road[1].SetActive(true);
                }
                else if (index == 11)
                {
                    stage_Road[0].SetActive(true);
                    stage_Road[1].SetActive(true);
                    stage_Road[2].SetActive(true);
                    stage_Road[3].SetActive(true);
                }
                else if (index == 12)
                {
                    stage_Road[0].SetActive(true);
                    stage_Road[1].SetActive(true);
                    stage_Road[2].SetActive(true);
                    stage_Road[3].SetActive(true);
                    stage_Road[4].SetActive(true);
                    stage_Road[5].SetActive(true);
                    stage_Road[6].SetActive(true);
                    stage_Road[7].SetActive(true);
                }
            }
        }
    }

    public void SetBtn()
    {
        set.SetActive(true);
    }
    
    public void Community()
    {
        Application.OpenURL("https://www.youtube.com/watch?v=WC5K4oX-yPc");
    }
    
    public void NoticeBtn()
    {
        notice.SetActive(true);
    }
    
    public void Stage_Select_Stage(string name)
    {
        stage_Select_Stage.SetActive(true);
        DBManager.instance.currentStage = name;

        switch (name)
        {
            case "Breath":
                stage_Select_Stage_Title.text = "호흡과 빙그레";
                stage_Select_Stage_Content.text = "<b><size=55><color=#43536C>호흡</color></size></b>\n호흡에 집중하게 되면\n주의집중과 심신의 안정이\n자연스럽게 이뤄질 뿐 아니라\n있는 그대로 알아차리는 힘을\n키우게 됩니다.\n\n<b><size=55><color=#43536C>빙그레</color></size></b>\n빙그레 웃음 한 번으로\n마음의 여유를 갖게 되고\n어려운 상황에서도 의연하게 대처하는\n힘을 갖게 됩니다.";
                break;
            
            case "BodyRecog":
                stage_Select_Stage_Title.text = "자각";
                stage_Select_Stage_Content.text = "<b><size=55><color=#43536C>신체자각</color></size></b>\n긴장 이완 및 주의 집중 효과와 함께\n자신의 현재 상태를 정확하게\n이해할 수 있게 됩니다.\n\n<b><size=55><color=#43536C>감정자각</color></size></b>\n현재 겪고 있는 고통과 괴로움에서\n잠시 벗어나 보다 편안한 상태에서\n문제를 해결할 수 있게 됩니다.";
                break;
            
            case "Lovely":
                stage_Select_Stage_Title.text = "러블리어텐션";
                stage_Select_Stage_Content.text = "자신의 심신 상태를\n사랑스러운 마음으로 지켜봄으로써\n자기 돌봄의 힘과 여유를\n갖게 됩니다.";
                break;
            
            case "Decent":
                DBManager.instance.decent_Count = 0;
                DBManager.instance.decent_Again = false;
                DBManager.instance.decent_Anger = false;
                DBManager.instance.decent_Sadness = false;
                DBManager.instance.decent_Unrest = false;
                DBManager.instance.decent_Remorse = false;
                DBManager.instance.decent_IsRefresh = false;
                stage_Select_Stage_Title.text = "탈중심화와 수용";
                stage_Select_Stage_Content.text = "<b><size=55><color=#43536C>탈중심화</color></size></b>\n자신의 사고와 감정을\n객관적으로 바라봄으로써\n현실을 정확하게 이해하고\n지혜롭게 대처하게 됩니다.\n\n<b><size=55><color=#43536C>수용</color></size></b>\n자신과 자신의 문제를\n있는 그대로 받아들이고\n더욱 긍정적으로\n살아가게 될 것입니다.";
                break;
        }

        Invoke("Stage_Select_Stage_StartBtn", 1.0f);
    }

    void Stage_Select_Stage_StartBtn()
    {
        if (DBManager.instance.currentStage == "Recog")
        {
            switch (DBManager.instance.currentStep)
            {
                case 1:
                    if (DBManager.instance.recog_Step1_Clear)
                    {
                        stage_Select_Stage_Recog_Start.SetActive(true);
                    }
                    else
                    {
                        stage_Select_Stage_Start.SetActive(true);
                    }
                    break;
                
                case 2:
                    if (DBManager.instance.recog_Step2_Clear)
                    {
                        stage_Select_Stage_Recog_Start.SetActive(true);
                    }
                    else
                    {
                        stage_Select_Stage_Start.SetActive(true);
                    }
                    break;
                
                case 3:
                    if (DBManager.instance.recog_Step3_Clear)
                    {
                        stage_Select_Stage_Recog_Start.SetActive(true);
                    }
                    else
                    {
                        stage_Select_Stage_Start.SetActive(true);
                    }
                    break;
            }
        }
        else
        {
            stage_Select_Stage_Start.SetActive(true);
        }
    }

    public void stage_Select_Stage_StartBtn(string type)
    {
        if (type != "")
        {
            DBManager.instance.currentStage = type;
        }

        stage_Select_Stage.GetComponent<Animator>().Play("Close");
        Invoke("Back_Delay", 0.5f);
        SceneManager.LoadScene("Loading");
    }

    public void Back()
    {
        if (stage_Select_Stage.activeSelf)
        {
            CancelInvoke("Stage_Select_Stage_StartBtn");
            stage_Select_Stage.GetComponent<Animator>().Play("Close");
            Invoke("Back_Delay", 0.3f);
        }
    }
    
    void Back_Delay()
    {
        if (stage.activeSelf)
        {
            if (stage_Select_Stage.activeSelf)
            {
                stage_Select_Stage.SetActive(false);
                stage_Select_Stage_Start.SetActive(false);
            }
        }
    }
    
    public void Buttons_Back()
    {
        if (set.activeSelf)
        {
            var animator = set.GetComponent<Animator>();
            animator.Play("Close");
        }
        else if (notice.activeSelf)
        {
            var animator = notice.GetComponent<Animator>();
            animator.Play("Close");
        }
        
        Invoke("Buttons_Delay", 0.3f);
    }

    void Buttons_Delay()
    {
        if (set.activeSelf)
        {
            set.SetActive(false);
        }
        else if (notice.activeSelf)
        {
            notice.SetActive(false);
        }
        else if (stage_Select_Stage.activeSelf)
        {
            stage_Select_Stage.SetActive(false);
        }
    }

    public void Quit()
    {
        quit.SetActive(true);
    }
}
