using System.Collections;
using System.Collections.Generic;
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
    public GameObject[] stage_Select_Step;
    public int stage_Select_Step_Num = 0;
    public GameObject[] stage_Select_Buttons;
    public GameObject stage_Select_Stage;
    public Text stage_Select_Stage_Title;
    public Text stage_Select_Stage_Content;
    public GameObject stage_Select_Stage_Start;
    public int stage_Select_Stage_Num;
    public List<GameObject> stage_Road;
    public GameObject breath;
    public GameObject smile;
    public GameObject bodyRecog;
    public GameObject emotionRecog;
    public GameObject refresh;
    public GameObject lovely;
    public GameObject decent;
    public GameObject upgrade;
    public GameObject upgrade_Character;
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

    void Start()
    {
        StartCoroutine("Init");
    }

    void Update()
    {
        Quit();
    }

    IEnumerator Init()
    {
        Application.targetFrameRate = 120;
        
        while (!DBManager.instance.isLoaded)
        {
            yield return null;
        }
        
        Set();
        Splash();
    }

    public void Set()
    {
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
            if (PlayerPrefs.HasKey("level"))
            {
                int index = DBManager.instance.level;
                
                if (index <= 4)
                {
                    stage_Select_Step_Num = 1;
                    stage_Select_Step[0].transform.GetChild(1).GetComponent<Image>().enabled = true;
                    stage_Select_Step[1].transform.GetChild(1).GetComponent<Image>().enabled = false;
                    stage_Select_Step[2].transform.GetChild(1).GetComponent<Image>().enabled = false;
                    stage_Select_Step[0].GetComponent<Button>().interactable = true;
                    stage_Select_Step[1].GetComponent<Button>().interactable = false;
                    stage_Select_Step[2].GetComponent<Button>().interactable = false;
                }
                else if (index >= 5 && index <= 8)
                {
                    stage_Select_Step_Num = 2;
                    stage_Select_Step[0].transform.GetChild(1).GetComponent<Image>().enabled = false;
                    stage_Select_Step[1].transform.GetChild(1).GetComponent<Image>().enabled = true;
                    stage_Select_Step[2].transform.GetChild(1).GetComponent<Image>().enabled = false;
                    stage_Select_Step[0].GetComponent<Button>().interactable = true;
                    stage_Select_Step[1].GetComponent<Button>().interactable = true;
                    stage_Select_Step[2].GetComponent<Button>().interactable = false;
                }
                else if (index >= 9 && index <= 12)
                {
                    stage_Select_Step_Num = 3;
                    stage_Select_Step[0].transform.GetChild(1).GetComponent<Image>().enabled = false;
                    stage_Select_Step[1].transform.GetChild(1).GetComponent<Image>().enabled = false;
                    stage_Select_Step[2].transform.GetChild(1).GetComponent<Image>().enabled = true;
                    stage_Select_Step[0].GetComponent<Button>().interactable = true;
                    stage_Select_Step[1].GetComponent<Button>().interactable = true;
                    stage_Select_Step[2].GetComponent<Button>().interactable = true;
                }

                if (stage_Select_Step_Num == 1)
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
                else if (stage_Select_Step_Num == 2)
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
                else if (stage_Select_Step_Num == 3)
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
            else
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
        }
        else
        {
            int index = PlayerPrefs.GetInt("level");

            if (stage_Select_Step_Num == 1)
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
            else if (stage_Select_Step_Num == 2)
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
            else if (stage_Select_Step_Num == 3)
            {
                stage_Select_Step[0].transform.GetChild(1).GetComponent<Image>().enabled = false;
                stage_Select_Step[1].transform.GetChild(1).GetComponent<Image>().enabled = false;
                stage_Select_Step[2].transform.GetChild(1).GetComponent<Image>().enabled = true;
                stage_Select_Step[0].GetComponent<Button>().interactable = true;
                stage_Select_Step[1].GetComponent<Button>().interactable = true;
                stage_Select_Step[2].GetComponent<Button>().interactable = true;
            }
            
            if (stage_Select_Step_Num == 1)
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
            else if (stage_Select_Step_Num == 2)
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
            else if (stage_Select_Step_Num == 3)
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
        
        Set2();
    }

    public void Set2()
    {
        if (breath.activeSelf || smile.activeSelf || bodyRecog.activeSelf || emotionRecog.activeSelf || refresh.activeSelf || lovely.activeSelf || decent.activeSelf)
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
        if (splash.activeSelf)
        {
            animManager.Splash();
        }

        Data();
    }

    void Data()
    {
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
            stage_Select_Buttons[i].SetActive(false);
        }
        
        for (int i = 0; i < stage_Road.Count; i++)
        {
            stage_Road[i].SetActive(false);
        }

        DBManager.instance.currentStep = num;
        stage_Select_Step_Num = num;
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

    public void PauseBtn()
    {
        Time.timeScale = 0;
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
            
            case "Recog":
                stage_Select_Stage_Title.text = "자각";
                stage_Select_Stage_Content.text = "<b><size=55><color=#43536C>신체자각</color></size></b>\n긴장 이완 및 주의 집중 효과와 함께\n자신의 현재 상태를 정확하게\n이해할 수 있게 됩니다.\n\n<b><size=55><color=#43536C>감정자각</color></size></b>\n현재 겪고 있는 고통과 괴로움에서\n잠시 벗어나 보다 편안한 상태에서\n문제를 해결할 수 있게 됩니다.";
                break;
            
            case "Lovely":
                stage_Select_Stage_Title.text = "러블리어텐션";
                stage_Select_Stage_Content.text = "자신의 심신 상태를\n사랑스러운 마음으로 지켜봄으로써\n자기 돌봄의 힘과 여유를\n갖게 됩니다.";
                break;
            
            case "Decent":
                stage_Select_Stage_Title.text = "탈중심화와 수용";
                stage_Select_Stage_Content.text = "<b><size=55><color=#43536C>탈중심화</color></size></b>\n자신의 사고와 감정을\n객관적으로 바라봄으로써\n현실을 정확하게 이해하고\n지혜롭게 대처하게 됩니다.\n\n<b><size=55><color=#43536C>수용</color></size></b>\n자신과 자신의 문제를\n있는 그대로 받아들이고\n더욱 긍정적으로\n살아가게 될 것입니다.";
                break;
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
        SceneManager.LoadScene("Loading");
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
            Time.timeScale = 1;
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
        if (pause.activeSelf == true)
        {
            Time.timeScale = 1;
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
        if (pause.activeSelf == true)
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
        Time.timeScale = 1;
        
        if (breath.activeSelf == true)
        {
           
        }
        else if (smile.activeSelf == true)
        {

        }
        else if (bodyRecog.activeSelf == true)
        {

        }
        else if (emotionRecog.activeSelf == true)
        {

        }
        else if (lovely.activeSelf == true)
        {
            
        }
        else if (decent.activeSelf == true)
        {
            decent.transform.GetChild(0).GetComponent<Decent_Manager>().ReStart();
        }
    }

    public void Help()
    {
        Time.timeScale = 1;
        
        if (breath.activeSelf == true)
        {
            
        }
        else if (smile.activeSelf == true)
        {
            
        }
        else if (bodyRecog.activeSelf == true)
        {

        }
        else if (emotionRecog.activeSelf == true)
        {

        }
        else if (lovely.activeSelf == true)
        {
            
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
    
    public void Policy_Popup()
    {
        Application.OpenURL("http://yeppi.kr/?pn=portfolio&p_id=1");
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
