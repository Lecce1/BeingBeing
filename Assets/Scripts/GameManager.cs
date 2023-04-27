using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public Camera camera;
    public GameObject splash;
    public GameObject buttons;
    public GameObject buttons_Info;
    public GameObject main;
    public GameObject main_Logo;
    public GameObject stage;
    public GameObject stage_Ground;
    public GameObject stage_Select;
    public GameObject[] stage_Select_Level;
    public int stage_Select_Level_Num;
    public GameObject[] stage_Select_Buttons;
    public GameObject stage_Select_Stage;
    public TMP_Text stage_Select_Stage_Title;
    public TMP_Text stage_Select_Stage_Content;
    public GameObject stage_Select_Stage_Start;
    public int stage_Select_Stage_Num;
    public GameObject breath;
    public GameObject smile;
    public GameObject bodyRecog;
    public GameObject emotionRecog;
    public GameObject refresh;
    public GameObject lovely;
    public GameObject fade;
    public GameObject info;
    public TMP_Text info_Title;
    public TMP_Text info_Content;
    public GameObject pause;
    public GameObject set;
    public Slider set_Music;
    public Image set_Music_Handle;
    public Image set_Music_Border;
    public Slider set_Vibrate;
    public Image set_Vibrate_Handle;
    public Image set_Vibrate_Border;
    public Sprite set_Handle_Green;
    public Sprite set_Handle_Gray;
    public GameObject loading;
    public AnimManager animManager;
    public int screen_Width;

    void Awake()
    {
        Application.targetFrameRate = 144;
        screen_Width = Screen.width;
    }

    void Start()
    {
        Set();
        Splash();
    }

    public void Set()
    {
        if (PlayerPrefs.HasKey("level") == true)
        {
            int index = PlayerPrefs.GetInt("level");
            
            for (int i = 0; i < index; i++)
            {
                stage_Select_Buttons[i].SetActive(true);
            }
        }
        else
        {
            PlayerPrefs.SetInt("level", 1);
            
            int index = PlayerPrefs.GetInt("level");
            
            for (int i = 0; i < index; i++)
            {
                stage_Select_Buttons[i].SetActive(true);
            }
        }

        if (breath.activeSelf == true || smile.activeSelf == true || bodyRecog.activeSelf == true || emotionRecog.activeSelf == true)
        {
            buttons_Info.transform.GetChild(0).gameObject.SetActive(true);
        }
        else
        {
            buttons_Info.transform.GetChild(0).gameObject.SetActive(false);
        }
    }

    void Splash()
    {
        animManager.Splash();
        Data();
    }

    void Data()
    {
        if (PlayerPrefs.HasKey("Music"))
        {
            set_Music.value = PlayerPrefs.GetInt("Music");
            transform.GetComponent<AudioSource>().volume = set_Music.value;
        }
        
        if (PlayerPrefs.HasKey("Vibrate"))
        {
            set_Vibrate.value = PlayerPrefs.GetInt("Sound");
        }

        if (stage_Select.activeSelf == true)
        {
            buttons_Info.SetActive(false);
        }
        else
        {
            buttons_Info.SetActive(true);
        }
    }

    public void Stage_Select_Buttons(int num)
    {
        if (num == 1)
        {
            stage_Select_Level[0].transform.GetChild(1).GetComponent<Image>().enabled = true;
            stage_Select_Level[1].transform.GetChild(1).GetComponent<Image>().enabled = false;
            stage_Select_Level[2].transform.GetChild(1).GetComponent<Image>().enabled = false;
        }
        else if (num == 2)
        {
            stage_Select_Level[0].transform.GetChild(1).GetComponent<Image>().enabled = false;
            stage_Select_Level[1].transform.GetChild(1).GetComponent<Image>().enabled = true;
            stage_Select_Level[2].transform.GetChild(1).GetComponent<Image>().enabled = false;
        }
        else if (num == 3)
        {
            stage_Select_Level[0].transform.GetChild(1).GetComponent<Image>().enabled = false;
            stage_Select_Level[1].transform.GetChild(1).GetComponent<Image>().enabled = false;
            stage_Select_Level[2].transform.GetChild(1).GetComponent<Image>().enabled = true;
        }

        stage_Select_Level_Num = num;
    }
    
    public void InfoBtn()
    {
        if (breath.activeSelf == true)
        {
            info_Title.text = "호흡";
            info_Content.text = "호흡에 집중하게 되면, 주의집중과 심신의 안정이 자연스럽게 이뤄질 뿐 아니라, 있는 그대로 알아차리는 힘을 키우게 됩니다";
        }
        else if (smile.activeSelf == true)
        {
            info_Title.text = "빙그레";
            info_Content.text = "빙그레 웃음 한 번으로 마음의 여유를 갖게 되고, 어려운 상황에서도 의연하게 대처하는 힘을 갖게 됩니다";
        }
        else if (bodyRecog.activeSelf == true)
        {
            info_Title.text = "신체자각";
            info_Content.text = "자신의 심신 상태를 사랑스러운 마음으로 지켜봄으로써, 자기 돌봄의 힘과 여유를 갖게 됩니다.";
        }
        else if (emotionRecog.activeSelf == true)
        {
            info_Title.text = "감정자각";
            info_Content.text = "현재 겪고 있는 고통과 괴로움에서 잠시 벗어나, 좀 더 편안한 상태에서 문제를 해결할 수 있게 됩니다";
        }
        else if (lovely.activeSelf == true)
        {
            info_Title.text = "러블리어텐션";
            info_Content.text = "자신의 심신 상태를 사랑스러운 마음으로 지켜봄으로써, 자기 돌봄의 힘과 여유를 갖게 됩니다";
        }
        
        info.SetActive(true);
    }

    public void PauseBtn()
    {
        pause.SetActive(true);
    }

    public void SetBtn()
    {
        set.SetActive(true);
    }

    public void Set_Music()
    {
        PlayerPrefs.SetInt("Music", (int)set_Music.value);
        transform.GetComponent<AudioSource>().volume = set_Music.value;

        if (set_Music.value == 0)
        {
            set_Music_Handle.sprite = set_Handle_Gray;
            set_Music_Border.color = new Color(120 / 255f, 129 / 255f, 138 / 255f, 255 / 255f);
        }
        else if (set_Music.value == 1)
        {
            set_Music_Handle.sprite = set_Handle_Green;
            set_Music_Border.color = new Color(60 / 255f, 129 / 255f, 11 / 255f, 255 / 255f);
        }
    }
    
    public void Set_Vibrate()
    {
        PlayerPrefs.SetInt("Vibrate", (int)set_Vibrate.value);
        
        if (set_Vibrate.value == 0)
        {
            set_Vibrate_Handle.sprite = set_Handle_Gray;
            set_Vibrate_Border.color = new Color(120 / 255f, 129 / 255f, 138 / 255f, 255 / 255f);
        }
        else if (set_Vibrate.value == 1)
        {
            set_Vibrate_Handle.sprite = set_Handle_Green;
            set_Vibrate_Border.color = new Color(60 / 255f, 129 / 255f, 11 / 255f, 255 / 255f);
        }
    }

    public void Set_Youtube()
    {
        Application.OpenURL("https://www.youtube.com");
    }

    public void Stage_Ground()
    {
        stage_Ground.SetActive(false);
        loading.SetActive(true);
        stage_Select.SetActive(true);
        Invoke("Stage_Ground_Delay", 5.0f);
    }

    void Stage_Ground_Delay()
    {
        loading.SetActive(false);
    }

    public void Stage_Select_Stage(int num)
    {
        stage_Select_Stage.SetActive(true);
        stage_Select_Stage_Num = num;
        
        if (stage_Select_Stage_Num == 1)
        {
            stage_Select_Stage_Title.text = "호흡과 빙그레";
            stage_Select_Stage_Content.text = "호흡\n호흡에 집중하게 되면, 주의집중과 심신의 안정이 자연스럽게 이뤄질 뿐 아니라, 있는 그대로 알아차리는 힘을 키우게 됩니다.\n\n빙그레\n빙그레 웃음 한 번으로 마음의 여우를 갖게 되고, 어려운 상황에서도 의연하게 대처하는 힘을 갖게 됩니다.";
        }
        else if (stage_Select_Stage_Num == 2)
        {
            stage_Select_Stage_Title.text = "신체 자각과 감정 자각";
            stage_Select_Stage_Content.text = "신체자각\n긴장 이완 및 주의 집중 효과와 함께 자신의 현재 상태를 정확하게 이해할 수 있도록 도와줄 것입니다.\n\n감정자각\n현재 겪고 있는 고통과 괴로움에서 잠시 벗어나 좀 더 편안한 상태에서 문제를 해결할 수 있게 됩니다.";
        }
        else if (stage_Select_Stage_Num == 3)
        {
            stage_Select_Stage_Title.text = "러블리어텐션";
            stage_Select_Stage_Content.text = "자신의 심신 상태를 사랑스러운 마음으로 지켜봄으로써, 자기 돌봄의 힘과 여유를 갖게 됩니다";
        }
        else if (stage_Select_Stage_Num == 4)
        {
            stage_Select_Stage_Title.text = "탈 중심화";
            stage_Select_Stage_Content.text = "자신의 사고와 감정을 객관적으로 바라보고, 현실을 정확하게 이해하고 지혜롭게 대처하게 됩니다";
        }
        else if (stage_Select_Stage_Num == 5)
        {
            stage_Select_Stage_Title.text = "수용";
            stage_Select_Stage_Content.text = "자신과 자신의 문제를 있는 그대로 받아들이고, 생활 속에서 더욱 긍정적으로 살아가게 될 것입니다";
        }
        
        Invoke("Stage_Select_Stage_StartBtn", 2.0f);
    }

    void Stage_Select_Stage_StartBtn()
    {
        stage_Select_Stage_Start.SetActive(true);
    }

    public void stage_Select_Stage_StartBtn()
    {
        stage_Select_Stage.GetComponent<Animator>().Play("Close");
        Invoke("Back_Delay", 0.5f);
        animManager.Fade_Out();
    }

    public void Back()
    {
        if (stage_Select_Stage.activeSelf == true)
        {
            stage_Select_Stage.GetComponent<Animator>().Play("Close");
            Invoke("Back_Delay", 0.3f);
        }
        else
        {
            var animator = pause.GetComponent<Animator>();
            animator.Play("Close");
            Invoke("Back_Delay", 0.3f);
        }
    }
    
    void Back_Delay()
    {
        if (main.activeSelf == true)
        {
            pause.SetActive(false);
        }
        else if (stage.activeSelf == true)
        {
            if (stage_Select_Stage.activeSelf == true)
            {
                stage_Select_Stage.SetActive(false);
                stage_Select_Stage_Start.SetActive(false);
            }
            else
            {
                pause.SetActive(false);
            }
        }
        else
        {
            pause.SetActive(false);
            animManager.Fade_Out();
        }
    }
    
    public void Buttons_Back()
    {
        if (info.activeSelf == true)
        {
            var animator = info.GetComponent<Animator>();
            animator.Play("Close");
        }
        else if (pause.activeSelf == true)
        {
            var animator = pause.GetComponent<Animator>();
            animator.Play("Close");
        }
        else if (set.activeSelf == true)
        {
            var animator = set.GetComponent<Animator>();
            animator.Play("Close");
        }
        
        Invoke("Buttons_Delay", 0.3f);
    }

    void Buttons_Delay()
    {
        if (info.activeSelf == true)
        {
            info.SetActive(false);
        }
        else if (pause.activeSelf == true)
        {
            pause.SetActive(false);
        }
        else if (set.activeSelf == true)
        {
            set.SetActive(false);
        }
        else if (stage_Select_Stage.activeSelf == true)
        {
            stage_Select_Stage.SetActive(false);
        }
    }

    public void Quit()
    {
        Application.Quit();
    }
}
