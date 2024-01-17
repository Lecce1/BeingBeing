using UnityEngine;

public class AnimManager : MonoBehaviour
{
    Animator splash_Animator;
    Animator smile_BackGlow_Animator;
    Animator refresh_BackGlow_Animator;
    Animator emotionRecog_Dot_Animator;
    Animator emotionRecog_Fade_Animator;
    Animator lovely_BackGlow_Animator;
    GameManager gameManager;
    BGMManager bgmManager;
    BodyRecog_Manager bodyRecog_Manager;
    EmotionRecog_Manager emotionRecog_Manager;
    Lovely_Manager lovely_Manager;
    Decent_Manager decent_Manager;
    Refresh_Manager refresh_Manager;

    void Awake()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        bgmManager = GameObject.Find("BGMManager").GetComponent<BGMManager>();
    }

    public void Splash()
    {
        splash_Animator = GameObject.Find("Splash").GetComponent<Animator>();
        splash_Animator.Play("Splash");
    }
    
    void Splash_Finish()
    {
        gameManager.splash.SetActive(false);
        gameManager.main.SetActive(true);
        bgmManager.PlayBGM("Main_BGM");
    }

    void Main_Finish()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    public void Main_Start_Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        gameManager.main_Logo.GetComponent<Animator>().Play("Main_Start2");
        gameManager.main_Background.GetComponent<Animator>().Play("Main_Background");
    }

    public void Main_Background_Finish()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();

        if (!DBManager.instance.isFirst)
        {
            PlayerPrefs.SetInt("isFirst", 1);
            DBManager.instance.isFirst = true;
            gameManager.main_Logo.SetActive(false);
            gameManager.main_Text.gameObject.SetActive(true);
            BGMManager.instance.StopBGM();
            gameManager.StartCoroutine("Main_Text");
        }
        else
        {
            gameManager.loading.SetActive(true);
            gameManager.Invoke("GotoStage", 3f);
        }
    }
}
