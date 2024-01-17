using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ButtonManager : MonoBehaviour
{   
    public GameObject info;
    public Text info_Title;
    public Text info_Content;
    public GameObject pause;
    public GameObject set;
    public GameObject set_Reset;
    public Slider set_Music;
    public Image set_Music_Image;
    public Slider set_Vibrate;
    public Image set_Vibrate_Image;
    public Slider set_Voice;
    public Image set_Voice_Image;
    public Sprite toggleOn;
    public Sprite toggleOff;
    public GameObject quit;
    
    public void Init(string type)
    {
        switch (type)
        {
            case "Info":
                switch (DBManager.instance.currentStage)
                {
                    case "Breath":
                        info_Title.text = "호흡";
                        info_Content.text = "호흡에 집중하게 되면\n주의집중과 심신의 안정이\n자연스럽게 이뤄질 뿐 아니라\n있는 그대로 알아차리는 힘을\n키우게 됩니다.";
                        break;
            
                    case "Smile":
                        info_Title.text = "빙그레";
                        info_Content.text = "빙그레 웃음 한 번으로 마음의 여유를 갖게 되고, 어려운 상황에서도 의연하게 대처하는 힘을 갖게 됩니다.";
                        break;
            
                    case "BodyRecog":
                        info_Title.text = "신체자각";
                        info_Content.text = "자신의 심신 상태를\n사랑스러운 마음으로 지켜봄으로써\n자기 돌봄의 힘과 여유를 갖게 됩니다.";
                        break;
            
                    case "EmotionRecog":
                        info_Title.text = "감정자각";
                        info_Content.text = "현재 겪고 있는 고통과 괴로움에서 잠시 벗어나, 좀 더 편안한 상태에서 문제를 해결할 수 있게 됩니다.";
                        break; 
            
                    case "Lovely": 
                        info_Title.text = "러블리어텐션";
                        info_Content.text = "자신의 심신 상태를 사랑스러운 마음으로 지켜봄으로써, 자기 돌봄의 힘과 여유를 갖게 됩니다.";
                        break;
            
                    case "Decent":
                        info_Title.text = "탈중심화";
                        info_Content.text = "자신의 사고와 감정을 객관적으로 바라보고, 현실을 정확하게 이해하고 지혜롭게 대처하게 됩니다.";
                        break;
                }
        
                info.SetActive(true);
                break;
            
            case "Pause":
                pause.SetActive(true);
                Invoke(nameof(TimeScale), 0.4f);
                break;
            
            case "Set":
                set.SetActive(true);
                Invoke(nameof(TimeScale), 0.4f);
                break;
        }
    }

    void TimeScale()
    {
        Time.timeScale = 0;
    }

    public void Back()
    {
        Animator animator;

        if (info != null)
        {
            if (info.activeSelf)
            {
                animator = info.GetComponent<Animator>();
                animator.Play("Close");
            }
        }
        
        if (pause != null)
        {
            if (pause.activeSelf)
            {
                Time.timeScale = 1;
                animator = pause.GetComponent<Animator>();
                animator.Play("Close");
            }
        }

        if (set != null)
        {
            if (set.activeSelf)
            {
                if (set_Reset.activeSelf)
                {
                    animator = set_Reset.GetComponent<Animator>();
                }
                else
                {
                    Time.timeScale = 1;
                    animator = set.GetComponent<Animator>();
                }
            
                animator.Play("Close");
            }
        }

        if (quit != null)
        {
            if (quit.activeSelf)
            {
                animator = quit.GetComponent<Animator>();
                animator.Play("Close");
            }
        }
        
        Invoke("Delay", 0.3f);
    }

    void Delay()
    {
        if (info != null)
        {
            if (info.activeSelf)
            {
                info.SetActive(false);
            }
        }
        
        if (pause != null)
        {
            if (pause.activeSelf)
            {
                pause.SetActive(false);
            }
        }

        if (set != null)
        {
            if (set.activeSelf)
            {
                if (set_Reset.activeSelf)
                {
                    set_Reset.SetActive(false);
                }
                else
                {
                    set.SetActive(false);
                }
            }
        }

        if (quit != null)
        {
            if(quit.activeSelf)
            {
                quit.SetActive(false);
            }
        }
    }
    
    public void Pause(string type)
    {
        Time.timeScale = 1;

        if (pause != null)
        {
            pause.GetComponent<Animator>().Play("Close");
        }

        StartCoroutine("PauseCoroutine", type);
    }

    IEnumerator PauseCoroutine(string type)
    {
        yield return new WaitForSeconds(0.3f);
        
        switch (type)
        {
            case "Back":
                DBManager.instance.currentStage = "Main";
                SceneManager.LoadScene("Loading");
                break;
            
            case "Restart":
                DBManager.instance.currentStage = SceneManager.GetActiveScene().name;
                SceneManager.LoadScene("Loading");
                break;
            
            case "Tutorial":
                Scene scene = SceneManager.GetActiveScene();

                switch (scene.name)
                {
                    case "Breath":
                        PlayerPrefs.SetInt("Breath_Tutorial", 0);
                        break;
            
                    case "Smile":
                        PlayerPrefs.SetInt("Smile_Tutorial", 0);
                        break;
            
                    case "BodyRecog":
                        PlayerPrefs.SetInt("BodyRecog_Tutorial", 0);
                        break;
            
                    case "EmotionRecog":
                        PlayerPrefs.SetInt("EmotionRecog_Tutorial", 0);
                        break;
            
                    case "Lovely":
                        PlayerPrefs.SetInt("Lovely_Tutorial", 0);
                        break;
            
                    case "Decent":
                        PlayerPrefs.SetInt("Decent_Tutorial", 0);
                        break;
                }
                
                DBManager.instance.currentStage = SceneManager.GetActiveScene().name;
                SceneManager.LoadScene("Loading");
                break;
            
            case "Policy":
                Application.OpenURL("http://yeppi.kr/?pn=portfolio&p_id=1");
                break;
            
            case "Reset":
                set_Reset.SetActive(true);
                break;
            
            case "Reset_Accept":
                PlayerPrefs.DeleteAll();
                Application.Quit();
                break;
            
            case "Quit":
                Application.Quit();
                break;
        }
    }
    
    public void Set_Music()
    {
        PlayerPrefs.SetInt("Music", (int)set_Music.value);
        StartCoroutine(nameof(Exception));
    }

    IEnumerator Exception()
    {
        while (BGMManager.instance == null)
        {
            yield return null;
        }
        
        BGMManager.instance.bgmAudioSource.volume = set_Music.value;

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
        PlayerPrefs.SetInt("Voice", (int)set_Voice.value);
        
        if (set_Voice.value == 0)
        {
            set_Voice_Image.sprite = toggleOff;
        }
        else if (set_Voice.value == 1)
        {
            set_Voice_Image.sprite = toggleOn;
        }
    }
}
