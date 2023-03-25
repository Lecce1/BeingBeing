using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject logo;
    public GameObject lobby;
    public GameObject lobby_Info;
    public GameObject lobby_Help;
    public GameObject lobby_Pause;
    public GameObject lobby_Set;
    public Slider lobby_Set_Music;
    public Slider lobby_Set_Sound;
    public GameObject lobby_Shadow;
    public GameObject level;
    public GameObject level_Slider;
    public GameObject level_Left;
    public GameObject level_Right;
    public GameObject level_Stage;
    public GameObject level_Start;
    public TMP_Text level_Stage_Text;
    private int level_Num = 1;
    private int level_Stage_Num;
    public TMP_Text level_Text;
    public GameObject fade;
    Anim_Manager anim_Manager;

    void Awake()
    {
        Application.targetFrameRate = 144;
        anim_Manager = GameObject.Find("Anim_Manager").GetComponent<Anim_Manager>();
        anim_Manager.Logo();
        PlayerPrefs();
    }

    void PlayerPrefs()
    {
        lobby_Set_Music.value = UnityEngine.PlayerPrefs.GetInt("Music");
        lobby_Set_Sound.value = UnityEngine.PlayerPrefs.GetInt("Sound");
        transform.GetComponent<AudioSource>().volume = lobby_Set_Music.value;
    }

    public void Lobby_Start()
    {
        anim_Manager.Fade_Out();
    }
    
    public void Lobby_InfoBtn()
    {
        lobby_Shadow.SetActive(true);
        lobby_Info.SetActive(true);
    }
    
    public void Lobby_HelpBtn()
    {
        lobby_Shadow.SetActive(true);
        lobby_Help.SetActive(true);
    }
    
    public void Lobby_PauseBtn()
    {
        lobby_Shadow.SetActive(true);
        lobby_Pause.SetActive(true);
    }

    public void Lobby_SetBtn()
    {
        lobby_Shadow.SetActive(true);
        lobby_Set.SetActive(true);
    }

    public void Lobby_Set_Music()
    {
        UnityEngine.PlayerPrefs.SetInt("Music", (int)lobby_Set_Music.value);
        transform.GetComponent<AudioSource>().volume = lobby_Set_Music.value;
    }
    
    public void Lobby_Set_Sound()
    {
        UnityEngine.PlayerPrefs.SetInt("Sound", (int)lobby_Set_Sound.value);
    }
    
    public void Level_Left()
    {
        --level_Num;
            
        if (level_Num < 0)
        {
            level_Num = 0;
        }

        Level_Text();
        level_Left.GetComponent<Animator>().SetTrigger("Pressed");
            
        switch (level_Num)
        {
            case 1:
                if (!level_Slider.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("2to1"))
                {
                    level_Slider.GetComponent<Animator>().Play("2to1");
                }

                Level_Left_Disable();
                Level_Right_Enable();
                break;

            default:
                break;
            }
        }
    
    public void Level_Right()
    {
        ++level_Num;
            
        if (level_Num >= 3)
        {
            level_Num = 2;
        }
            
        Level_Text();
        level_Right.GetComponent<Animator>().SetTrigger("Pressed");
            
        switch (level_Num)
        {
            case 2:
                if (!level_Slider.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("1to2"))
                {
                    level_Slider.GetComponent<Animator>().Play("1to2");
                }
                    
                Level_Left_Enable();
                Level_Right_Disable();
                break;

            default:
                break;
            }
        }

    void Level_Left_Enable()
    {
        level_Left.transform.GetChild(0).GetComponent<Image>().color = new Color(255 / 255f, 255 / 255f, 255 / 255f, 255 / 255f);
        level_Left.GetComponent<Button>().interactable = true;
    }
    
    void Level_Left_Disable()
    {
        level_Left.transform.GetChild(0).GetComponent<Image>().color = new Color(255 / 255f, 255 / 255f, 255 / 255f, 40 / 255f);
        level_Left.GetComponent<Button>().interactable = false;
    }

    void Level_Right_Enable()
    {
        level_Right.transform.GetChild(0).GetComponent<Image>().color = new Color(255 / 255f, 255 / 255f, 255 / 255f, 255 / 255f);
        level_Right.GetComponent<Button>().interactable = true;
    }

    void Level_Right_Disable()
    {
        level_Right.transform.GetChild(0).GetComponent<Image>().color = new Color(255 / 255f, 255 / 255f, 255 / 255f, 40 / 255f);
        level_Right.GetComponent<Button>().interactable = false;
    }

    void Level_Text()
    {
        if (level_Num == 1)
        { 
            level_Text.text = "호흡과 빙그레";
        }
        else if (level_Num == 2)
        { 
            level_Text.text = "자각";
        }
    }

    public void Level_Stage(int num)
    {
        level_Stage.SetActive(true);
        level_Stage_Num = num;
        
        if (num == 1)
        {
            level_Stage_Text.text = "호흡";
        }
        else if (num == 2)
        {
            level_Stage_Text.text = "빙그레";
        }
    }

    public void Level_Start()
    {
        var animator = level_Stage.GetComponent<Animator>();
        animator.Play("Close");
        Invoke("Delay", 0.5f);

        if (level_Stage_Num == 1)
        {
            
        }
        else if (level_Stage_Num == 2)
        {
            
        }
    }

    public void Back()
    {
        if (lobby.activeSelf == true)
        {
            lobby_Shadow.SetActive(false);
            
            if (lobby_Info.activeSelf == true)
            {
                var animator = lobby_Info.GetComponent<Animator>();
                animator.Play("Close");
            }
            else if (lobby_Help.activeSelf == true)
            {
                var animator = lobby_Help.GetComponent<Animator>();
                animator.Play("Close");
            }
            else if (lobby_Pause.activeSelf == true)
            {
                var animator = lobby_Pause.GetComponent<Animator>();
                animator.Play("Close");
            }
            else if (lobby_Set.activeSelf == true)
            {
                var animator = lobby_Set.GetComponent<Animator>();
                animator.Play("Close");
            }
        }
        else if (level.activeSelf == true)
        {
            if (level_Stage.activeSelf == true)
            {
                var animator = level_Stage.GetComponent<Animator>();
                animator.Play("Close");
            }
            else
            {
                anim_Manager.Fade_Out();
            }
        }
        
        Invoke("Delay", 0.5f);
    }

    void Delay()
    {
        if (lobby_Info.activeSelf == true)
        {
            lobby_Info.SetActive(false);
        }
        else if (lobby_Help.activeSelf == true)
        {
            lobby_Help.SetActive(false);
        }
        else if (lobby_Pause.activeSelf == true)
        {
            lobby_Pause.SetActive(false);
        }
        else if (lobby_Set.activeSelf == true)
        {
            lobby_Set.SetActive(false);
        }
        else if (level_Stage.activeSelf == true)
        {
            level_Stage.SetActive(false);
        }
    }

    public void Resume()
    {
        SceneManager.LoadScene("Main");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
