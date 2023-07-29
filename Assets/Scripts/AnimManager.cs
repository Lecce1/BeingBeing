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
    Breath_Manager breath_Manager;
    Smile_Manager smile_Manager;
    BodyRecog_Manager bodyRecog_Manager;
    EmotionRecog_Manager emotionRecog_Manager;
    Lovely_Manager lovely_Manager;
    Decent_Manager decent_Manager;
    Refresh_Manager refresh_Manager;

    void Awake()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
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
        //gameManager.main_Logo.GetComponent<Animator>().Play("Main");
        gameManager.GetComponent<AudioSource>().Play();
    }

    void Main_Finish()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        gameManager.GetComponent<AudioSource>().Play();
    }

    public void Main_Start_Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        gameManager.main_Logo.GetComponent<Animator>().Play("Main_Start2");
    }
    
    public void Main_Start_Finish()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        gameManager.camera.GetComponent<CustomPostProcessing>().enabled = true;
        gameManager.main_Background.GetComponent<Animator>().Play("Main_Background");
    }

    public void Main_Background_Finish()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        gameManager.camera.GetComponent<CustomPostProcessing>().enabled = false;
        
        if (gameManager.isFirst == 0)
        {
            PlayerPrefs.SetInt("isFirst", 1);
            gameManager.main_Logo.SetActive(false);
            gameManager.main_Text.gameObject.SetActive(true);
            gameManager.Main_Text();
        }
        else
        {
            Fade_Out();
        }
    }

    public void BackGlow()
    {
        Handheld.Vibrate();
        smile_Manager = GameObject.Find("Smile_Manager").GetComponent<Smile_Manager>();

        if (smile_Manager.isTutorial == false)
        {
            smile_Manager.tutorial_BackGlow.SetActive(true);
            smile_BackGlow_Animator = smile_Manager.tutorial_BackGlow.GetComponent<Animator>();
            smile_BackGlow_Animator.Play("BackGlow");
        }
        else if (smile_Manager.isTutorial == true)
        {
            smile_Manager.backGlow.SetActive(true);
            smile_BackGlow_Animator = smile_Manager.backGlow.GetComponent<Animator>();
            smile_BackGlow_Animator.Play("BackGlow");
        }
    }
    
    void BackGlow_Finish()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        smile_Manager = GameObject.Find("Smile_Manager").GetComponent<Smile_Manager>();

        if (smile_Manager.isTutorial == false)
        {
            smile_Manager.tutorial_BackGlow.SetActive(false);
            PlayerPrefs.SetInt("Smile_Tutorial", 1);
            smile_Manager.isTutorial = true;
        }
        else if (smile_Manager.isTutorial == true)
        {
            smile_Manager.backGlow.SetActive(false);
            smile_Manager.shadow.SetActive(true);
            smile_Manager.success.SetActive(true);
        }
    }
    
    public void Lovely_BackGlow()
    {
        lovely_Manager = GameObject.Find("Lovely_Manager").GetComponent<Lovely_Manager>();

        if (lovely_Manager.isTutorial == false)
        {

        }
        else if (lovely_Manager.isTutorial == true)
        {
            lovely_Manager.backGlow.SetActive(true);
            lovely_BackGlow_Animator = lovely_Manager.backGlow.GetComponent<Animator>();
            lovely_BackGlow_Animator.Play("Lovely_BackGlow");
        }
    }
    
    void Lovely_BackGlow_Finish()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        lovely_Manager = GameObject.Find("Lovely_Manager").GetComponent<Lovely_Manager>();

        if (lovely_Manager.isTutorial == false)
        {

        }
        else if (lovely_Manager.isTutorial == true)
        {
            lovely_Manager.backGlow.SetActive(false);
            
            if (lovely_Manager.bar.GetComponent<Slider>().value >= 1f)
            {
                lovely_Manager.isNext = true;
                Fade_Out();
            }
        }
    }

    public void Refresh_BackGlow()
    {
        Handheld.Vibrate();
        refresh_Manager = GameObject.Find("Refresh_Manager").GetComponent<Refresh_Manager>();
        refresh_Manager.backGlow.SetActive(true);
        refresh_BackGlow_Animator = refresh_Manager.backGlow.GetComponent<Animator>();
        refresh_BackGlow_Animator.Play("Refresh_BackGlow");
    }
    
    void Refresh_BackGlow_Finish()
    {
        refresh_Manager = GameObject.Find("Refresh_Manager").GetComponent<Refresh_Manager>();
        
        if (refresh_Manager.prevStage == "decent")
        {
            refresh_Manager.backGlow.SetActive(false);
            Fade_Out();
        }
        else
        {
            refresh_Manager.backGlow.SetActive(false);
            refresh_Manager.shadow.SetActive(true);
            refresh_Manager.success.SetActive(true);
        }
    }

    public void Fade_Out()
    {
        gameManager.loading.SetActive(true);
        Invoke("Loading_Finish", 3.0f);
    }

    void Loading_Finish()
    {
        if (gameManager.main.activeSelf == true)
        {
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
        else if (gameManager.breath.activeSelf == true)
        {
            breath_Manager = GameObject.Find("Breath").transform.GetChild(0).GetComponent<Breath_Manager>();
            
            if (breath_Manager.isNext == false)
            {
                breath_Manager.Reset();
                gameManager.stage.SetActive(true);
                gameManager.breath.SetActive(false);
                gameManager.Set();
            }
            else if (breath_Manager.isNext == true)
            {
                breath_Manager.Reset();
                gameManager.breath.SetActive(false);
                gameManager.smile.SetActive(true);
            }
        }
        else if (gameManager.smile.activeSelf == true)
        {
            smile_Manager = GameObject.Find("Smile").transform.GetChild(0).GetComponent<Smile_Manager>();
            smile_Manager.Reset();
            gameManager.stage.SetActive(true);
            gameManager.smile.SetActive(false);
            gameManager.Set();
        }
        else if (gameManager.bodyRecog.activeSelf == true)
        {
            bodyRecog_Manager = GameObject.Find("BodyRecog").transform.GetChild(0).GetComponent<BodyRecog_Manager>();
            
            if (bodyRecog_Manager.isNext == false)
            {
                bodyRecog_Manager.Reset();
                gameManager.stage.SetActive(true);
                gameManager.bodyRecog.SetActive(false);
                gameManager.Set();
            }
            else if (bodyRecog_Manager.isNext == true)
            {
                bodyRecog_Manager.Reset();
                gameManager.bodyRecog.SetActive(false);
                gameManager.emotionRecog.SetActive(true);
            }
        }
        else if (gameManager.emotionRecog.activeSelf == true)
        {
            emotionRecog_Manager = GameObject.Find("EmotionRecog").transform.GetChild(0).GetComponent<EmotionRecog_Manager>();
            
            if (emotionRecog_Manager.isNext == false)
            {
                emotionRecog_Manager.Reset();
                gameManager.stage.SetActive(true);
                gameManager.emotionRecog.SetActive(false);
                gameManager.Set();
            }
            else if (emotionRecog_Manager.isNext == true)
            {
                emotionRecog_Manager.Reset();
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
                lovely_Manager.Reset();
                gameManager.stage.SetActive(true);
                gameManager.lovely.SetActive(false);
                gameManager.Set();
            }
            else if (lovely_Manager.isNext == true)
            {
                lovely_Manager.Reset();
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
                refresh_Manager.Reset();
                gameManager.refresh.SetActive(false);
                decent_Manager.isTutorial = true;
                decent_Manager.stage1.SetActive(false);
                decent_Manager.stage6.SetActive(true);
                decent_Manager.stage = 6;
            }
            else
            {
                refresh_Manager.Reset();
                gameManager.stage.SetActive(true);
                gameManager.refresh.SetActive(false);
                gameManager.Set();
            }
        }
        
        gameManager.buttons.transform.GetChild(0).gameObject.SetActive(false);
        gameManager.buttons.transform.GetChild(1).gameObject.SetActive(true);
        gameManager.buttons.transform.GetChild(2).gameObject.SetActive(false);
        gameManager.loading.SetActive(false);
    }
}
