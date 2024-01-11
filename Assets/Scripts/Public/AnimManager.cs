using UnityEngine;
using UnityEngine.UI;

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

        if (DBManager.instance.isFirst)
        {
            PlayerPrefs.SetInt("isFirst", 1);
            DBManager.instance.isFirst = false;
            gameManager.main_Logo.SetActive(false);
            gameManager.main_Text.gameObject.SetActive(true);
            gameManager.Main_Text();
        }
        else
        {
            Fade_Out();
        }
    }                                                                       

    public void Fade_Out()
    {
        bgmManager.StopBGM();
        
        if (gameManager.emotionRecog.activeSelf == true)
        {
            emotionRecog_Manager = GameObject.Find("EmotionRecog").transform.GetChild(0).GetComponent<EmotionRecog_Manager>();

            if (emotionRecog_Manager.isNext == true)
            {
                gameManager.refresh_Loading.SetActive(true);
            }
            else
            {
                gameManager.loading.SetActive(true);
            }
        }
        else if (gameManager.lovely.activeSelf == true)
        {
            lovely_Manager = GameObject.Find("Lovely").transform.GetChild(0).GetComponent<Lovely_Manager>();

            if (lovely_Manager.isNext == true)
            {
                gameManager.refresh_Loading.SetActive(true);
            }
            else
            {
                gameManager.loading.SetActive(true);
            }
        }
        else if (gameManager.decent.activeSelf == true)
        {
            decent_Manager = GameObject.Find("Decent").transform.GetChild(0).GetComponent<Decent_Manager>();
            
            if (decent_Manager.isNext == true)
            {
                gameManager.refresh_Loading.SetActive(true);
            }
            else
            {
                gameManager.loading.SetActive(true);
            }
        }
        else
        {
            gameManager.loading.SetActive(true);
        }

        if (gameManager.refresh_Loading.activeSelf == true)
        {
            Invoke("Loading_Finish", 5.0f);
        }
        else
        {
            Invoke("Loading_Finish", 3.0f);
        }
    }

    void Loading_Finish()
    {
        bgmManager.PlayBGM("Stage_BGM");
        
        if (gameManager.main.activeSelf == true)
        {
            bgmManager.PlayBGM("Stage_BGM");
            gameManager.main.SetActive(false);
            gameManager.stage.SetActive(true);
            gameManager.Set();
        }
        else if (gameManager.stage.activeSelf == true)
        {
            gameManager.stage.SetActive(false);

            if (gameManager.stage_Select_Stage_Num == 1)
            {
                gameManager.breath.SetActive(true);
            }
            else if (gameManager.stage_Select_Stage_Num == 2)
            {
                gameManager.bodyRecog.SetActive(true);
            }
            else if (gameManager.stage_Select_Stage_Num == 3)
            {
                gameManager.lovely.SetActive(true);
            }
            else if (gameManager.stage_Select_Stage_Num == 4)
            {
                gameManager.decent.SetActive(true);
            }
        }
        else if (gameManager.bodyRecog.activeSelf == true)
        {
            bodyRecog_Manager = GameObject.Find("BodyRecog").transform.GetChild(0).GetComponent<BodyRecog_Manager>();
            
            if (bodyRecog_Manager.isNext == false)
            {
                gameManager.stage.SetActive(true);
                gameManager.bodyRecog.SetActive(false);
                gameManager.Set();
            }
            else if (bodyRecog_Manager.isNext == true)
            {
                gameManager.bodyRecog.SetActive(false);
                gameManager.emotionRecog.SetActive(true);
            }
        }
        else if (gameManager.emotionRecog.activeSelf == true)
        {
            emotionRecog_Manager = GameObject.Find("EmotionRecog").transform.GetChild(0).GetComponent<EmotionRecog_Manager>();
            
            if (emotionRecog_Manager.isNext == false)
            {
                gameManager.stage.SetActive(true);
                gameManager.emotionRecog.SetActive(false);
                gameManager.Set();
            }
            else if (emotionRecog_Manager.isNext == true)
            {
                gameManager.refresh.SetActive(true);
                refresh_Manager = GameObject.Find("Refresh").transform.GetChild(0).GetComponent<Refresh_Manager>();
                refresh_Manager.prevStage = "emotionRecog";
                gameManager.emotionRecog.SetActive(false);
            }
        }
        else if (gameManager.lovely.activeSelf == true)
        {
            lovely_Manager = GameObject.Find("Lovely").transform.GetChild(0).GetComponent<Lovely_Manager>();
            
            if (lovely_Manager.isNext == false)
            {
                gameManager.stage.SetActive(true);
                gameManager.lovely.SetActive(false);
                gameManager.Set();
            }
            else if (lovely_Manager.isNext == true)
            {
                gameManager.refresh.SetActive(true);
                refresh_Manager = GameObject.Find("Refresh").transform.GetChild(0).GetComponent<Refresh_Manager>();
                refresh_Manager.prevStage = "lovely";
                gameManager.lovely.SetActive(false);
            }
        }
        else if (gameManager.decent.activeSelf == true)
        {
            decent_Manager = GameObject.Find("Decent").transform.GetChild(0).GetComponent<Decent_Manager>();
            
            if (decent_Manager.isNext == false)
            {
                if (decent_Manager.isFinish == true && (gameManager.stage_Select_Step_Num == 1 || gameManager.stage_Select_Step_Num == 2))
                {
                    gameManager.upgrade.SetActive(true);
                    Upgrade();
                }
                
                decent_Manager.Reset();
                gameManager.stage.SetActive(true);
                gameManager.decent.SetActive(false);
                gameManager.Set();
            }
            else if (decent_Manager.isNext == true)
            {
                decent_Manager.Reset();
                gameManager.refresh.SetActive(true);
                refresh_Manager = GameObject.Find("Refresh").transform.GetChild(0).GetComponent<Refresh_Manager>();
                refresh_Manager.prevStage = "decent";
                gameManager.decent.SetActive(false);
            }
        }
        else if (gameManager.refresh.activeSelf == true)
        {
            refresh_Manager = GameObject.Find("Refresh").transform.GetChild(0).GetComponent<Refresh_Manager>();

            if (refresh_Manager.prevStage == "decent")
            {
                gameManager.decent.SetActive(true);
                decent_Manager = GameObject.Find("Decent").transform.GetChild(0).GetComponent<Decent_Manager>();
                gameManager.refresh.SetActive(false);
                decent_Manager.isTutorial = true;
                decent_Manager.background.sprite = decent_Manager.stage6_Background;
                decent_Manager.blur.SetActive(false);
                decent_Manager.stage6.SetActive(true);
                
                if (gameManager.stage_Select_Step_Num == 1)
                {
                    decent_Manager.stage6_Char_Step1.SetActive(true);
                }
                else if (gameManager.stage_Select_Step_Num == 2)
                {
                    decent_Manager.stage6_Char_Step2.SetActive(true);
                }
                else if (gameManager.stage_Select_Step_Num == 3)
                {
                    decent_Manager.stage6_Char_Step3.SetActive(true);
                }
                
                decent_Manager.stage1.SetActive(false);
                decent_Manager.stage = 6;
            }
            else
            {
                gameManager.stage.SetActive(true);
                gameManager.refresh.SetActive(false);
                gameManager.Set();
            }
        }
        
        gameManager.buttons.transform.GetChild(0).gameObject.SetActive(false);
        gameManager.buttons.transform.GetChild(1).gameObject.SetActive(true);
        gameManager.buttons.transform.GetChild(2).gameObject.SetActive(false);
        gameManager.loading.SetActive(false);
        gameManager.refresh_Loading.SetActive(false);
    }

    void Upgrade()
    {
        if (gameManager.stage_Select_Step_Num == 2)
        {
            gameManager.upgrade_Character.GetComponent<Animator>().Play("Step1");
        }
        else if (gameManager.stage_Select_Step_Num == 3)
        {
            gameManager.upgrade_Character.GetComponent<Animator>().Play("Step2");
        }
        
        Invoke("Upgrade_Finish", 11.0f);
    }

    void Upgrade_Finish()
    {
        gameManager.upgrade.SetActive(false);
    }
}
