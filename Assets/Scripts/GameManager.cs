using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public Camera camera;
    public GameObject logo;
    public GameObject buttons;
    public GameObject lobby;
    public GameObject lobby_Logo;
    public GameObject lobby_Info;
    public GameObject lobby_Pause;
    public GameObject lobby_Set;
    public Slider lobby_Set_Music;
    public Image lobby_Set_Music_Handle;
    public Image lobby_Set_Music_Border;
    public Slider lobby_Set_Sound;
    public Image lobby_Set_Sound_Handle;
    public Image lobby_Set_Sound_Border;
    public Sprite lobby_Set_Handle_Green;
    public Sprite lobby_Set_Handle_Gray;
    public GameObject lobby_Shadow;
    public GameObject level;
    public GameObject level_Ground;
    public GameObject level_Road;
    public GameObject level_Stage;
    public GameObject level_Start;
    public TMP_Text level_Stage_Text;
    public TMP_Text level_Stage_Content;
    private int level_Num = 1;
    public int level_Stage_Num;
    public GameObject breath;
    public GameObject smile;
    public GameObject bodyRecog;
    public GameObject emotionRecog;
    public GameObject fade;
    public int screen_Width;
    public int screen_Height;
    Anim_Manager anim_Manager;

    void Awake()
    {
        Application.targetFrameRate = 144;
        screen_Width = Screen.width;
        screen_Height = Screen.height;
        anim_Manager = GameObject.Find("Anim_Manager").GetComponent<Anim_Manager>();
        anim_Manager.Logo();
        Data();
    }

    void Data()
    {
        if (PlayerPrefs.HasKey("Music"))
        {
            lobby_Set_Music.value = PlayerPrefs.GetInt("Music");
            transform.GetComponent<AudioSource>().volume = lobby_Set_Music.value;
        }
        
        if (PlayerPrefs.HasKey("Sound"))
        {
            lobby_Set_Sound.value = PlayerPrefs.GetInt("Sound");
        }
    }

    public void Lobby_InfoBtn()
    {
        lobby_Shadow.SetActive(true);
        lobby_Info.SetActive(true);
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
        PlayerPrefs.SetInt("Music", (int)lobby_Set_Music.value);
        transform.GetComponent<AudioSource>().volume = lobby_Set_Music.value;

        if (lobby_Set_Music.value == 0)
        {
            lobby_Set_Music_Handle.sprite = lobby_Set_Handle_Gray;
            lobby_Set_Music_Border.color = new Color(120 / 255f, 129 / 255f, 138 / 255f, 255 / 255f);
        }
        else if (lobby_Set_Music.value == 1)
        {
            lobby_Set_Music_Handle.sprite = lobby_Set_Handle_Green;
            lobby_Set_Music_Border.color = new Color(60 / 255f, 129 / 255f, 11 / 255f, 255 / 255f);
        }
    }
    
    public void Lobby_Set_Sound()
    {
        PlayerPrefs.SetInt("Sound", (int)lobby_Set_Sound.value);
        
        if (lobby_Set_Sound.value == 0)
        {
            lobby_Set_Sound_Handle.sprite = lobby_Set_Handle_Gray;
            lobby_Set_Sound_Border.color = new Color(120 / 255f, 129 / 255f, 138 / 255f, 255 / 255f);
        }
        else if (lobby_Set_Sound.value == 1)
        {
            lobby_Set_Sound_Handle.sprite = lobby_Set_Handle_Green;
            lobby_Set_Sound_Border.color = new Color(60 / 255f, 129 / 255f, 11 / 255f, 255 / 255f);
        }
    }

    public void Level_Ground()
    {
        level_Ground.SetActive(false);
        level_Road.SetActive(true);
    }

    public void Level_Stage(int num)
    {
        level_Stage.SetActive(true);
        level_Stage_Num = num;
        
        if (num == 1)
        {
            level_Stage_Text.text = "호흡";
            level_Stage_Content.text = "호흡에 집중하게 되면, 주의집중과 심신의 안정이 자연스럽게 이뤄질 뿐 아니라, 있는 그대로 알아차리는 힘을 키우게 됩니다";
        }
        else if (num == 2)
        {
            level_Stage_Text.text = "빙그레";
            level_Stage_Content.text = "빙그레 웃음 한 번으로 마음의 여유를 갖게 되고, 어려운 상황에서도 의연하게 대처하는 힘을 갖게 됩니다";
        }
        else if (num == 3)
        {
            level_Stage_Text.text = "신체 자각";
            level_Stage_Content.text = "긴장 이완 및 주의집중 효과와 함께 자신의 현재 상태를 정확하게 이해할 수 있도록 도와줄 것입니다";
        }
        else if (num == 4)
        {
            level_Stage_Text.text = "감정 자각";
            level_Stage_Content.text = "현재 겪고 있는 고통과 괴로움에서 잠시 벗어나, 좀 더 편안한 상태에서 문제를 해결할 수 있게 됩니다";
        }
    }

    public void Level_Start()
    {
        level_Stage.GetComponent<Animator>().Play("Close");
        Invoke("Back_Delay", 0.5f);
        anim_Manager.Fade_Out();
    }

    public void Back()
    {
        if (level_Stage.activeSelf == true)
        {
            level_Stage.GetComponent<Animator>().Play("Close");
            Invoke("Back_Delay", 0.3f);
        }
        else
        {
            lobby_Shadow.SetActive(false);
            var animator = lobby_Pause.GetComponent<Animator>();
            animator.Play("Close");
            Invoke("Back_Delay", 0.3f);
        }
    }
    
    void Back_Delay()
    {
        if (lobby.activeSelf == true)
        {
            lobby_Pause.SetActive(false);
        }
        else if (level.activeSelf == true)
        {
            if (level_Stage.activeSelf == true)
            {
                level_Stage.SetActive(false);
            }
            else
            {
                lobby_Pause.SetActive(false);
            }
        }
        else
        {
            lobby_Pause.SetActive(false);
            anim_Manager.Fade_Out();
        }
    }
    
    public void Buttons_Back()
    {
        lobby_Shadow.SetActive(false);
            
        if (lobby_Info.activeSelf == true)
        {
            var animator = lobby_Info.GetComponent<Animator>();
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
        
        Invoke("Buttons_Delay", 0.3f);
    }

    void Buttons_Delay()
    {
        if (lobby_Info.activeSelf == true)
        {
            lobby_Info.SetActive(false);
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

    public void Logo()
    {
        Application.OpenURL("http://yeppi.kr");
    }

    public void Quit()
    {
        Application.Quit();
    }
}
