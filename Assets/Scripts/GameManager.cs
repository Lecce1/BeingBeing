using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject splash;
    public GameObject buttons;
    public GameObject main;
    public GameObject main_Background;
    public GameObject main_Logo;
    public TMP_Text main_Text;
    public GameObject stage;
    public Image stage_Char;
    public GameObject[] stage_Select_Level;
    public int stage_Select_Level_Num = 0;
    public GameObject[] stage_Select_Buttons;
    public GameObject stage_Select_Stage;
    public Text stage_Select_Stage_Title;
    public Text stage_Select_Stage_Content;
    public GameObject stage_Select_Stage_Start;
    public int stage_Select_Stage_Num;
    public List<Image> stage_Road;
    public GameObject breath;
    public GameObject smile;
    public GameObject bodyRecog;
    public GameObject emotionRecog;
    public GameObject refresh;
    public GameObject lovely;
    public GameObject decent;
    public GameObject info;
    public Text info_Title;
    public Text info_Content;
    public GameObject pause;
    public GameObject pause_Help;
    public GameObject set;
    public GameObject notice;
    public GameObject quit;
    public GameObject reset_Popup;
    public Slider set_Music;
    public Image set_Music_Image;
    public Slider set_Vibrate;
    public Image set_Vibrate_Image;
    public Slider set_Voice;
    public Image set_Voice_Image;
    public Sprite toggleOn;
    public Sprite toggleOff;
    public GameObject loading;
    public GameObject refresh_Loading;
    public AnimManager animManager;
    public BGMManager bgmManager;
    public List<Sprite> charLevel;
    public int isFirst = 0;

    void Awake()
    {
        Application.targetFrameRate = 120;
    }

    void Start()
    {
        Set();
        Splash();
    }

    void Update()
    {
        Quit();
    }

    public void Set()
    {
        isFirst = PlayerPrefs.GetInt("isFirst");

        for (int i = 0; i < 4; i++)
        {
            stage_Select_Buttons[i].GetComponent<Button>().interactable = false;
        }
        
        for (int i = 0; i < stage_Road.Count; i++)
        {
            stage_Road[i].color = new Color(255 / 255f, 255 / 255f, 255 / 255f, 100 / 255f);
        }

        if (stage_Select_Level_Num == 0)
        {
            if (PlayerPrefs.HasKey("level") == true)
            {
                int index = PlayerPrefs.GetInt("level");

                if (index <= 4)
                {
                    stage_Select_Level_Num = 1;
                    stage_Select_Level[0].transform.GetChild(1).GetComponent<Image>().enabled = true;
                    stage_Select_Level[1].transform.GetChild(1).GetComponent<Image>().enabled = false;
                    stage_Select_Level[2].transform.GetChild(1).GetComponent<Image>().enabled = false;
                    stage_Select_Level[0].GetComponent<Button>().interactable = true;
                    stage_Select_Level[1].GetComponent<Button>().interactable = false;
                    stage_Select_Level[2].GetComponent<Button>().interactable = false;
                }
                else if (index >= 5 && index <= 8)
                {
                    stage_Select_Level_Num = 2;
                    stage_Select_Level[0].transform.GetChild(1).GetComponent<Image>().enabled = false;
                    stage_Select_Level[1].transform.GetChild(1).GetComponent<Image>().enabled = true;
                    stage_Select_Level[2].transform.GetChild(1).GetComponent<Image>().enabled = false;
                    stage_Select_Level[0].GetComponent<Button>().interactable = true;
                    stage_Select_Level[1].GetComponent<Button>().interactable = true;
                    stage_Select_Level[2].GetComponent<Button>().interactable = false;
                }
                else if (index >= 9 && index <= 12)
                {
                    stage_Select_Level_Num = 3;
                    stage_Select_Level[0].transform.GetChild(1).GetComponent<Image>().enabled = false;
                    stage_Select_Level[1].transform.GetChild(1).GetComponent<Image>().enabled = false;
                    stage_Select_Level[2].transform.GetChild(1).GetComponent<Image>().enabled = true;
                    stage_Select_Level[0].GetComponent<Button>().interactable = true;
                    stage_Select_Level[1].GetComponent<Button>().interactable = true;
                    stage_Select_Level[2].GetComponent<Button>().interactable = true;
                }

                if (stage_Select_Level_Num == 1)
                {
                    stage_Char.sprite = charLevel[0];
                    
                    if (index <= 4)
                    {
                        for (int i = 0; i < index; i++)
                        {
                            stage_Select_Buttons[i].GetComponent<Button>().interactable = true;
                        }

                        if (index == 2)
                        {
                            stage_Road[0].color = new Color(255 / 255f, 255 / 255f, 255 / 255f, 255 / 255f);
                            stage_Road[1].color = new Color(255 / 255f, 255 / 255f, 255 / 255f, 255 / 255f);
                        }
                        else if (index == 3)
                        {
                            stage_Road[2].color = new Color(255 / 255f, 255 / 255f, 255 / 255f, 255 / 255f);
                            stage_Road[3].color = new Color(255 / 255f, 255 / 255f, 255 / 255f, 255 / 255f);
                        }
                        else if (index == 4)
                        {
                            stage_Road[4].color = new Color(255 / 255f, 255 / 255f, 255 / 255f, 255 / 255f);
                            stage_Road[5].color = new Color(255 / 255f, 255 / 255f, 255 / 255f, 255 / 255f);
                        }
                    }
                    else
                    {
                        for (int i = 0; i < 4; i++)
                        {
                            stage_Select_Buttons[i].GetComponent<Button>().interactable = true;
                        }
                        
                        for (int i = 0; i < 8; i++)
                        {
                            stage_Road[i].color = new Color(255 / 255f, 255 / 255f, 255 / 255f, 255 / 255f);
                        }
                    }
                }
                else if (stage_Select_Level_Num == 2)
                {
                    stage_Char.sprite = charLevel[1];
                    
                    if (index >= 5 && index <= 8)
                    {
                        for (int i = 0; i < index - 4; i++)
                        {
                            stage_Select_Buttons[i].GetComponent<Button>().interactable = true;
                        }
                        
                        if (index == 6)
                        {
                            stage_Road[0].color = new Color(255 / 255f, 255 / 255f, 255 / 255f, 255 / 255f);
                            stage_Road[1].color = new Color(255 / 255f, 255 / 255f, 255 / 255f, 255 / 255f);
                        }
                        else if (index == 7)
                        {
                            stage_Road[2].color = new Color(255 / 255f, 255 / 255f, 255 / 255f, 255 / 255f);
                            stage_Road[3].color = new Color(255 / 255f, 255 / 255f, 255 / 255f, 255 / 255f);
                        }
                        else if (index == 8)
                        {
                            stage_Road[4].color = new Color(255 / 255f, 255 / 255f, 255 / 255f, 255 / 255f);
                            stage_Road[5].color = new Color(255 / 255f, 255 / 255f, 255 / 255f, 255 / 255f);
                        }
                    }
                    else
                    {
                        for (int i = 0; i < 4; i++)
                        {
                            stage_Select_Buttons[i].GetComponent<Button>().interactable = true;
                        }
                        
                        for (int i = 0; i < 8; i++)
                        {
                            stage_Road[i].color = new Color(255 / 255f, 255 / 255f, 255 / 255f, 255 / 255f);
                        }
                    }
                }
                else if (stage_Select_Level_Num == 3)
                {
                    stage_Char.sprite = charLevel[2];
                    
                    if (index >= 9)
                    {
                        for (int i = 0; i < index - 8; i++)
                        {
                            stage_Select_Buttons[i].GetComponent<Button>().interactable = true;
                        }
                        
                        if (index == 10)
                        {
                            stage_Road[0].color = new Color(255 / 255f, 255 / 255f, 255 / 255f, 255 / 255f);
                            stage_Road[1].color = new Color(255 / 255f, 255 / 255f, 255 / 255f, 255 / 255f);
                        }
                        else if (index == 11)
                        {
                            stage_Road[2].color = new Color(255 / 255f, 255 / 255f, 255 / 255f, 255 / 255f);
                            stage_Road[3].color = new Color(255 / 255f, 255 / 255f, 255 / 255f, 255 / 255f);
                        }
                        else if (index == 12)
                        {
                            stage_Road[4].color = new Color(255 / 255f, 255 / 255f, 255 / 255f, 255 / 255f);
                            stage_Road[5].color = new Color(255 / 255f, 255 / 255f, 255 / 255f, 255 / 255f);
                            stage_Road[6].color = new Color(255 / 255f, 255 / 255f, 255 / 255f, 255 / 255f);
                            stage_Road[7].color = new Color(255 / 255f, 255 / 255f, 255 / 255f, 255 / 255f);
                        }
                    }
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
                
                stage_Select_Level[0].GetComponent<Button>().interactable = true;
                stage_Select_Level[1].GetComponent<Button>().interactable = false;
                stage_Select_Level[2].GetComponent<Button>().interactable = false;
                stage_Char.sprite = charLevel[0];
            }
        }
        else
        {
            int index = PlayerPrefs.GetInt("level");

            if (stage_Select_Level_Num == 1)
            {
                stage_Select_Level[0].transform.GetChild(1).GetComponent<Image>().enabled = true;
                stage_Select_Level[1].transform.GetChild(1).GetComponent<Image>().enabled = false;
                stage_Select_Level[2].transform.GetChild(1).GetComponent<Image>().enabled = false;
                
                if (index <= 4)
                {
                    stage_Select_Level[0].GetComponent<Button>().interactable = true;
                    stage_Select_Level[1].GetComponent<Button>().interactable = false;
                    stage_Select_Level[2].GetComponent<Button>().interactable = false;
                }
                else if (index >= 5 && index <= 8)
                {
                    stage_Select_Level[0].GetComponent<Button>().interactable = true;
                    stage_Select_Level[1].GetComponent<Button>().interactable = true;
                    stage_Select_Level[2].GetComponent<Button>().interactable = false;
                }
                else
                {
                    stage_Select_Level[0].GetComponent<Button>().interactable = true;
                    stage_Select_Level[1].GetComponent<Button>().interactable = true;
                    stage_Select_Level[2].GetComponent<Button>().interactable = true;
                }
            }
            else if (stage_Select_Level_Num == 2)
            {
                stage_Select_Level[0].transform.GetChild(1).GetComponent<Image>().enabled = false;
                stage_Select_Level[1].transform.GetChild(1).GetComponent<Image>().enabled = true;
                stage_Select_Level[2].transform.GetChild(1).GetComponent<Image>().enabled = false;
                
                if (index >= 5 && index <= 8)
                {
                    stage_Select_Level[0].GetComponent<Button>().interactable = true;
                    stage_Select_Level[1].GetComponent<Button>().interactable = true;
                    stage_Select_Level[2].GetComponent<Button>().interactable = false;
                }
                else
                {
                    stage_Select_Level[0].GetComponent<Button>().interactable = true;
                    stage_Select_Level[1].GetComponent<Button>().interactable = true;
                    stage_Select_Level[2].GetComponent<Button>().interactable = true;
                }
            }
            else if (stage_Select_Level_Num == 3)
            {
                stage_Select_Level[0].transform.GetChild(1).GetComponent<Image>().enabled = false;
                stage_Select_Level[1].transform.GetChild(1).GetComponent<Image>().enabled = false;
                stage_Select_Level[2].transform.GetChild(1).GetComponent<Image>().enabled = true;
                stage_Select_Level[0].GetComponent<Button>().interactable = true;
                stage_Select_Level[1].GetComponent<Button>().interactable = true;
                stage_Select_Level[2].GetComponent<Button>().interactable = true;
            }
            
            if (stage_Select_Level_Num == 1)
            {
                stage_Char.sprite = charLevel[0];
                
                if (index <= 4)
                {
                    for (int i = 0; i < index; i++)
                    {
                        stage_Select_Buttons[i].GetComponent<Button>().interactable = true;
                    }
                    
                    if (index == 2)
                    {
                        stage_Road[0].color = new Color(255 / 255f, 255 / 255f, 255 / 255f, 255 / 255f);
                        stage_Road[1].color = new Color(255 / 255f, 255 / 255f, 255 / 255f, 255 / 255f);
                    }
                    else if (index == 3)
                    {
                        stage_Road[2].color = new Color(255 / 255f, 255 / 255f, 255 / 255f, 255 / 255f);
                        stage_Road[3].color = new Color(255 / 255f, 255 / 255f, 255 / 255f, 255 / 255f);
                    }
                    else if (index == 4)
                    {
                        stage_Road[4].color = new Color(255 / 255f, 255 / 255f, 255 / 255f, 255 / 255f);
                        stage_Road[5].color = new Color(255 / 255f, 255 / 255f, 255 / 255f, 255 / 255f);
                    }
                }
                else
                {
                    for (int i = 0; i < 4; i++)
                    {
                        stage_Select_Buttons[i].GetComponent<Button>().interactable = true;
                    }
                    
                    for (int i = 0; i < 8; i++)
                    {
                        stage_Road[i].color = new Color(255 / 255f, 255 / 255f, 255 / 255f, 255 / 255f);
                    }
                }
            }
            else if (stage_Select_Level_Num == 2)
            {
                stage_Char.sprite = charLevel[1];
                
                if (index >= 5 && index <= 8)
                {
                    for (int i = 0; i < index - 4; i++)
                    {
                        stage_Select_Buttons[i].GetComponent<Button>().interactable = true;
                    }
                    
                    if (index == 6)
                    {
                        stage_Road[0].color = new Color(255 / 255f, 255 / 255f, 255 / 255f, 255 / 255f);
                        stage_Road[1].color = new Color(255 / 255f, 255 / 255f, 255 / 255f, 255 / 255f);
                    }
                    else if (index == 7)
                    {
                        stage_Road[2].color = new Color(255 / 255f, 255 / 255f, 255 / 255f, 255 / 255f);
                        stage_Road[3].color = new Color(255 / 255f, 255 / 255f, 255 / 255f, 255 / 255f);
                    }
                    else if (index == 8)
                    {
                        stage_Road[4].color = new Color(255 / 255f, 255 / 255f, 255 / 255f, 255 / 255f);
                        stage_Road[5].color = new Color(255 / 255f, 255 / 255f, 255 / 255f, 255 / 255f);
                    }
                }
                else
                {
                    for (int i = 0; i < 4; i++)
                    {
                        stage_Select_Buttons[i].GetComponent<Button>().interactable = true;
                    }
                    
                    for (int i = 0; i < 8; i++)
                    {
                        stage_Road[i].color = new Color(255 / 255f, 255 / 255f, 255 / 255f, 255 / 255f);
                    }
                }
            }
            else if (stage_Select_Level_Num == 3)
            {
                stage_Char.sprite = charLevel[2];
                
                if (index >= 9)
                {
                    for (int i = 0; i < index - 8; i++)
                    {
                        stage_Select_Buttons[i].GetComponent<Button>().interactable = true;
                    }
                    
                    if (index == 10)
                    {
                        stage_Road[0].color = new Color(255 / 255f, 255 / 255f, 255 / 255f, 255 / 255f);
                        stage_Road[1].color = new Color(255 / 255f, 255 / 255f, 255 / 255f, 255 / 255f);
                    }
                    else if (index == 11)
                    {
                        stage_Road[2].color = new Color(255 / 255f, 255 / 255f, 255 / 255f, 255 / 255f);
                        stage_Road[3].color = new Color(255 / 255f, 255 / 255f, 255 / 255f, 255 / 255f);
                    }
                    else if (index == 12)
                    {
                        stage_Road[4].color = new Color(255 / 255f, 255 / 255f, 255 / 255f, 255 / 255f);
                        stage_Road[5].color = new Color(255 / 255f, 255 / 255f, 255 / 255f, 255 / 255f);
                        stage_Road[6].color = new Color(255 / 255f, 255 / 255f, 255 / 255f, 255 / 255f);
                        stage_Road[7].color = new Color(255 / 255f, 255 / 255f, 255 / 255f, 255 / 255f);
                    }
                }
            }
        }
        
        Set2();
    }

    public void Set2()
    {
        if (breath.activeSelf == true || smile.activeSelf == true || bodyRecog.activeSelf == true || emotionRecog.activeSelf == true || refresh.activeSelf == true || lovely.activeSelf == true || decent.activeSelf == true)
        {
            buttons.SetActive(true);
        }
        else
        {
            buttons.SetActive(false);
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

            if (set_Music.value == 0)
            {
                set_Music_Image.sprite = toggleOff;
            }
            else if (set_Music.value == 1)
            {
                set_Music_Image.sprite = toggleOn;
            }
            
            bgmManager.bgmAudioSource.volume = set_Music.value;
        }
        
        if (PlayerPrefs.HasKey("Vibrate"))
        {
            set_Vibrate.value = PlayerPrefs.GetInt("Sound");
            
            if (set_Vibrate.value == 0)
            {
                set_Vibrate_Image.sprite = toggleOff;
            }
            else if (set_Vibrate.value == 1)
            {
                set_Vibrate_Image.sprite = toggleOn;
            }
        }
        
        if (PlayerPrefs.HasKey("Voice"))
        {
            set_Voice.value = PlayerPrefs.GetInt("Sound");
            
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

        buttons.SetActive(false);
    }

    public void Main_Text()
    {
        StartCoroutine("Main_Text_Anim");
    }

    IEnumerator Main_Text_Anim()
    {
        main_Text.text = "반갑습니다!";
        
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
            main_Text.color = new Color(main_Text.color.r, main_Text.color.g, main_Text.color.b, main_Text.color.a - (Time.deltaTime * 0.5f));
            yield return null;
        }
        
        main_Text.text = "빙빙과 함께 자신감과 행복을\n찾아가는 여행을 시작해봅시다.";
        
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

        delay = 0;
        
        while (main_Text.color.a > 0)
        {
            main_Text.color = new Color(main_Text.color.r, main_Text.color.g, main_Text.color.b, main_Text.color.a - (Time.deltaTime * 0.5f));
            yield return null;
        }
        
        animManager.Fade_Out();
    }

    public void Stage_Select_Buttons(int num)
    {
        for (int i = 0; i < 4; i++)
        {
            stage_Select_Buttons[i].GetComponent<Button>().interactable = false;
        }
        
        for (int i = 0; i < stage_Road.Count; i++)
        {
            stage_Road[i].color = new Color(255 / 255f, 255 / 255f, 255 / 255f, 100 / 255f);
        }
        
        stage_Select_Level_Num = num;
        int index = PlayerPrefs.GetInt("level");

        if (num == 1)
        {
            stage_Char.sprite = charLevel[0];
            stage_Select_Level[0].transform.GetChild(1).GetComponent<Image>().enabled = true;
            stage_Select_Level[1].transform.GetChild(1).GetComponent<Image>().enabled = false;
            stage_Select_Level[2].transform.GetChild(1).GetComponent<Image>().enabled = false;

            if (index <= 4)
            {
                for (int i = 0; i < index; i++)
                {
                    stage_Select_Buttons[i].GetComponent<Button>().interactable = true;
                }
                
                if (index == 2)
                {
                    stage_Road[0].color = new Color(255 / 255f, 255 / 255f, 255 / 255f, 255 / 255f);
                    stage_Road[1].color = new Color(255 / 255f, 255 / 255f, 255 / 255f, 255 / 255f);
                }
                else if (index == 3)
                {
                    stage_Road[2].color = new Color(255 / 255f, 255 / 255f, 255 / 255f, 255 / 255f);
                    stage_Road[3].color = new Color(255 / 255f, 255 / 255f, 255 / 255f, 255 / 255f);
                }
                else if (index == 4)
                {
                    stage_Road[4].color = new Color(255 / 255f, 255 / 255f, 255 / 255f, 255 / 255f);
                    stage_Road[5].color = new Color(255 / 255f, 255 / 255f, 255 / 255f, 255 / 255f);
                }
            }
            else
            {
                for (int i = 0; i < 4; i++)
                {
                    stage_Select_Buttons[i].GetComponent<Button>().interactable = true;
                }
                
                for (int i = 0; i < 8; i++)
                {
                    stage_Road[i].color = new Color(255 / 255f, 255 / 255f, 255 / 255f, 255 / 255f);
                }
            }
        }
        else if (num == 2)
        {
            stage_Char.sprite = charLevel[1];
            stage_Select_Level[0].transform.GetChild(1).GetComponent<Image>().enabled = false;
            stage_Select_Level[1].transform.GetChild(1).GetComponent<Image>().enabled = true;
            stage_Select_Level[2].transform.GetChild(1).GetComponent<Image>().enabled = false;

            if (index >= 5 && index <= 8)
            {
                for (int i = 0; i < index - 4; i++)
                {
                    stage_Select_Buttons[i].GetComponent<Button>().interactable = true;
                }
                
                if (index == 6)
                {
                    stage_Road[0].color = new Color(255 / 255f, 255 / 255f, 255 / 255f, 255 / 255f);
                    stage_Road[1].color = new Color(255 / 255f, 255 / 255f, 255 / 255f, 255 / 255f);
                }
                else if (index == 7)
                {
                    stage_Road[2].color = new Color(255 / 255f, 255 / 255f, 255 / 255f, 255 / 255f);
                    stage_Road[3].color = new Color(255 / 255f, 255 / 255f, 255 / 255f, 255 / 255f);
                }
                else if (index == 8)
                {
                    stage_Road[4].color = new Color(255 / 255f, 255 / 255f, 255 / 255f, 255 / 255f);
                    stage_Road[5].color = new Color(255 / 255f, 255 / 255f, 255 / 255f, 255 / 255f);
                }
            }
            else if (index >= 9)
            {
                for (int i = 0; i < 4; i++)
                {
                    stage_Select_Buttons[i].GetComponent<Button>().interactable = true;
                }
                
                for (int i = 0; i < 8; i++)
                {
                    stage_Road[i].color = new Color(255 / 255f, 255 / 255f, 255 / 255f, 255 / 255f);
                }
            }
        }
        else if (num == 3)
        {
            stage_Char.sprite = charLevel[2];
            stage_Select_Level[0].transform.GetChild(1).GetComponent<Image>().enabled = false;
            stage_Select_Level[1].transform.GetChild(1).GetComponent<Image>().enabled = false;
            stage_Select_Level[2].transform.GetChild(1).GetComponent<Image>().enabled = true;
            
            if (index >= 9)
            {
                for (int i = 0; i < index - 8; i++)
                {
                    stage_Select_Buttons[i].GetComponent<Button>().interactable = true;
                }
                
                if (index == 10)
                {
                    stage_Road[0].color = new Color(255 / 255f, 255 / 255f, 255 / 255f, 255 / 255f);
                    stage_Road[1].color = new Color(255 / 255f, 255 / 255f, 255 / 255f, 255 / 255f);
                }
                else if (index == 11)
                {
                    stage_Road[2].color = new Color(255 / 255f, 255 / 255f, 255 / 255f, 255 / 255f);
                    stage_Road[3].color = new Color(255 / 255f, 255 / 255f, 255 / 255f, 255 / 255f);
                }
                else if (index == 12)
                {
                    stage_Road[4].color = new Color(255 / 255f, 255 / 255f, 255 / 255f, 255 / 255f);
                    stage_Road[5].color = new Color(255 / 255f, 255 / 255f, 255 / 255f, 255 / 255f);
                    stage_Road[6].color = new Color(255 / 255f, 255 / 255f, 255 / 255f, 255 / 255f);
                    stage_Road[7].color = new Color(255 / 255f, 255 / 255f, 255 / 255f, 255 / 255f);
                }
            }
        }
    }
    
    public void InfoBtn()
    {
        if (breath.activeSelf == true)
        {
            info_Title.text = "호흡";
            info_Content.text = "호흡에 집중하게 되면\n주의집중과 심신의 안정이\n자연스럽게 이뤄질 뿐 아니라\n있는 그대로 알아차리는 힘을\n키우게 됩니다.";
        }
        else if (smile.activeSelf == true)
        {
            info_Title.text = "빙그레";
            info_Content.text = "빙그레 웃음 한 번으로 마음의 여유를 갖게 되고, 어려운 상황에서도 의연하게 대처하는 힘을 갖게 됩니다.";
        }
        else if (bodyRecog.activeSelf == true)
        {
            info_Title.text = "신체자각";
            info_Content.text = "자신의 심신 상태를\n사랑스러운 마음으로 지켜봄으로써\n자기 돌봄의 힘과 여유를 갖게 됩니다.";
        }
        else if (emotionRecog.activeSelf == true)
        {
            info_Title.text = "감정자각";
            info_Content.text = "현재 겪고 있는 고통과 괴로움에서 잠시 벗어나, 좀 더 편안한 상태에서 문제를 해결할 수 있게 됩니다.";
        }
        else if (lovely.activeSelf == true)
        {
            info_Title.text = "러블리어텐션";
            info_Content.text = "자신의 심신 상태를 사랑스러운 마음으로 지켜봄으로써, 자기 돌봄의 힘과 여유를 갖게 됩니다.";
        }
        else if (decent.activeSelf == true)
        {
            info_Title.text = "탈중심화";
            info_Content.text = "자신의 사고와 감정을 객관적으로 바라보고, 현실을 정확하게 이해하고 지혜롭게 대처하게 됩니다.";
        }
        
        info.SetActive(true);
    }

    public void PauseBtn()
    {
        pause.SetActive(true);

        if (lovely.activeSelf == true)
        {
            pause_Help.SetActive(false);
        }
        else
        {
            pause_Help.SetActive(true);
        }
    }

    public void SetBtn()
    {
        set.SetActive(true);
    }

    public void Set_Music()
    {
        PlayerPrefs.SetInt("Music", (int)set_Music.value);
        bgmManager.bgmAudioSource.volume = set_Music.value;

        if (set_Music.value == 0)
        {
            set_Music_Image.sprite = toggleOff;
        }
        else if (set_Music.value == 1)
        {
            set_Music_Image.sprite = toggleOn;
        }
    }
    
    public void Set_Vibrate()
    {
        PlayerPrefs.SetInt("Vibrate", (int)set_Vibrate.value);
        
        if (set_Vibrate.value == 0)
        {
            set_Vibrate_Image.sprite = toggleOff;
        }
        else if (set_Vibrate.value == 1)
        {
            set_Vibrate_Image.sprite = toggleOn;
        }
    }
    
    public void Set_Voice()
    {
        PlayerPrefs.SetInt("Voice", (int)set_Vibrate.value);
        
        if (set_Voice.value == 0)
        {
            set_Voice_Image.sprite = toggleOff;
        }
        else if (set_Voice.value == 1)
        {
            set_Voice_Image.sprite = toggleOn;
        }
    }

    public void Set_Youtube()
    {
        Application.OpenURL("https://www.youtube.com/watch?v=WC5K4oX-yPc");
    }
    
    public void NoticeBtn()
    {
        notice.SetActive(true);
    }
    
    public void Stage_Select_Stage(int num)
    {
        stage_Select_Stage.SetActive(true);
        stage_Select_Stage_Num = num;
        
        if (stage_Select_Stage_Num == 1)
        {
            stage_Select_Stage_Title.text = "호흡과 빙그레";
            stage_Select_Stage_Content.text = "<b><size=55><color=#43536C>호흡</color></size></b>\n호흡에 집중하게 되면\n주의집중과 심신의 안정이\n자연스럽게 이뤄질 뿐 아니라\n있는 그대로 알아차리는 힘을\n키우게 됩니다.\n\n<b><size=55><color=#43536C>빙그레</color></size></b>\n빙그레 웃음 한 번으로\n마음의 여유를 갖게 되고\n어려운 상황에서도 의연하게 대처하는\n힘을 갖게 됩니다.";
        }
        else if (stage_Select_Stage_Num == 2)
        {
            stage_Select_Stage_Title.text = "자각";
            stage_Select_Stage_Content.text = "<b><size=55><color=#43536C>신체자각</color></size></b>\n긴장 이완 및 주의 집중 효과와 함께\n자신의 현재 상태를 정확하게\n이해할 수 있게 됩니다.\n\n<b><size=55><color=#43536C>감정자각</color></size></b>\n현재 겪고 있는 고통과 괴로움에서\n잠시 벗어나 보다 편안한 상태에서\n문제를 해결할 수 있게 됩니다.";
        }
        else if (stage_Select_Stage_Num == 3)
        {
            stage_Select_Stage_Title.text = "러블리어텐션";
            stage_Select_Stage_Content.text = "자신의 심신 상태를\n사랑스러운 마음으로 지켜봄으로써\n자기 돌봄의 힘과 여유를\n갖게 됩니다.";
        }
        else if (stage_Select_Stage_Num == 4)
        {
            stage_Select_Stage_Title.text = "탈중심화";
            stage_Select_Stage_Content.text = "<b><size=55><color=#43536C>탈중심화</color></size></b>\n자신의 사고와 감정을\n객관적으로 바라봄으로써\n현실을 정확하게 이해하고\n지혜롭게 대처하게 됩니다.\n\n<b><size=55><color=#43536C>수용</color></size></b>\n자신과 자신의 문제를\n있는 그대로 받아들이고\n더욱 긍정적으로\n살아가게 될 것입니다.";
        }
        
        Invoke("Stage_Select_Stage_StartBtn", 1.0f);
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
            CancelInvoke("Stage_Select_Stage_StartBtn");
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
        else if (notice.activeSelf == true)
        {
            var animator = notice.GetComponent<Animator>();
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
        else if (notice.activeSelf == true)
        {
            notice.SetActive(false);
        }
        else if (stage_Select_Stage.activeSelf == true)
        {
            stage_Select_Stage.SetActive(false);
        }
        
        buttons.transform.GetChild(0).gameObject.SetActive(false);
        buttons.transform.GetChild(1).gameObject.SetActive(true);
        buttons.transform.GetChild(2).gameObject.SetActive(false);
    }

    public void Restart()
    {
        if (breath.activeSelf == true)
        {
            breath.transform.GetChild(0).GetComponent<Breath_Manager>().ReStart();
        }
        else if (smile.activeSelf == true)
        {
            smile.transform.GetChild(0).GetComponent<Smile_Manager>().ReStart();
        }
        else if (bodyRecog.activeSelf == true)
        {
            bodyRecog.transform.GetChild(0).GetComponent<BodyRecog_Manager>().ReStart();
        }
        else if (emotionRecog.activeSelf == true)
        {
            emotionRecog.transform.GetChild(0).GetComponent<EmotionRecog_Manager>().ReStart();
        }
        else if (lovely.activeSelf == true)
        {
            lovely.transform.GetChild(0).GetComponent<Lovely_Manager>().ReStart();
        }
        else if (decent.activeSelf == true)
        {
            decent.transform.GetChild(0).GetComponent<Decent_Manager>().ReStart();
        }
    }

    public void Help()
    {
        if (breath.activeSelf == true)
        {
            breath.transform.GetChild(0).GetComponent<Breath_Manager>().Help();
        }
        else if (smile.activeSelf == true)
        {
            smile.transform.GetChild(0).GetComponent<Smile_Manager>().Help();
        }
        else if (bodyRecog.activeSelf == true)
        {
            bodyRecog.transform.GetChild(0).GetComponent<BodyRecog_Manager>().Help();
        }
        else if (emotionRecog.activeSelf == true)
        {
            emotionRecog.transform.GetChild(0).GetComponent<EmotionRecog_Manager>().Help();
        }
        else if (lovely.activeSelf == true)
        {
            lovely.transform.GetChild(0).GetComponent<Lovely_Manager>().Help();
        }
        else if (decent.activeSelf == true)
        {
            decent.transform.GetChild(0).GetComponent<Decent_Manager>().Help();
        }
    }

    void Quit()
    {
        if(Application.platform == RuntimePlatform.Android)
        {
            if(Input.GetKey(KeyCode.Escape))
            {
                quit.SetActive(true);
            }
        }
    }

    public void Quit_Cancel()
    {
        quit.SetActive(false);
    }

    public void Quit_Accept()
    {
        Application.Quit();
    }

    public void Reset_Popup()
    {
        reset_Popup.SetActive(true);
    }
    
    public void Reset_Cancel()
    {
        reset_Popup.SetActive(false);
    }
    
    public void Reset_Accept()
    {
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene("Main");
    }
}
