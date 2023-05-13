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
        gameManager.main_Logo.GetComponent<Animator>().Play("Main");
    }

    void Main_Finish()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        gameManager.GetComponent<AudioSource>().Play();
    }

    public void Main_Start_Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        gameManager.camera.GetComponent<CustomPostProcessing>().enabled = true;
        gameManager.main_Logo.GetComponent<Animator>().Play("Main_Start");
    }
    
    public void Main_Start_Finish()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        gameManager.camera.GetComponent<CustomPostProcessing>().enabled = false;
        Fade_Out();
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
            smile_Manager.isTutorial = true;
        }
        else if (smile_Manager.isTutorial == true)
        {
            smile_Manager.backGlow.SetActive(false);

            if (gameManager.stage_Select_Level_Num == 1)
            {
                if (smile_Manager.num < 3)
                {
                    smile_Manager.time = 0;
                    smile_Manager.isLeftUp = false;
                    smile_Manager.isRightUp = false;
                    smile_Manager.isNum = false;
                }
                else if (smile_Manager.num == 3)
                {
                    smile_Manager.shadow.SetActive(true);
                    smile_Manager.success.SetActive(true);
                }
            }
            else if (gameManager.stage_Select_Level_Num == 2)
            {
                if (smile_Manager.num < 2)
                {
                    smile_Manager.time = 0;
                    smile_Manager.isLeftUp = false;
                    smile_Manager.isRightUp = false;
                    smile_Manager.isNum = false;
                }
                else if (smile_Manager.num == 2)
                {
                    smile_Manager.shadow.SetActive(true);
                    smile_Manager.success.SetActive(true);
                }
            }
            else if (gameManager.stage_Select_Level_Num == 3)
            {
                if (smile_Manager.num == 1)
                {
                    smile_Manager.shadow.SetActive(true);
                    smile_Manager.success.SetActive(true);
                }
            }
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
            
            if (lovely_Manager.bar.transform.GetChild(0).GetComponent<Image>().fillAmount >= 1f)
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
        refresh_Manager.backGlow.SetActive(false);
        refresh_Manager.shadow.SetActive(true);
        refresh_Manager.success.SetActive(true);
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
            gameManager.buttons.SetActive(true);
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
        }
        else if (gameManager.bodyRecog.activeSelf == true)
        {
            bodyRecog_Manager = GameObject.Find("BodyRecog").transform.GetChild(0).GetComponent<BodyRecog_Manager>();
            
            if (bodyRecog_Manager.isNext == false)
            {
                bodyRecog_Manager.Reset();
                gameManager.stage.SetActive(true);
                gameManager.bodyRecog.SetActive(false);
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
            if (lovely_Manager.isNext == false)
            {
                lovely_Manager.Reset();
                gameManager.stage.SetActive(true);
                gameManager.lovely.SetActive(false);
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
            if (decent_Manager.isNext == false)
            {
                decent_Manager.Reset();
                gameManager.stage.SetActive(true);
                gameManager.decent.SetActive(false);
            }
            else if (lovely_Manager.isNext == true)
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
            refresh_Manager.Reset();
            gameManager.stage.SetActive(true);
            gameManager.refresh.SetActive(false);
        }
        
        gameManager.buttons.transform.GetChild(0).gameObject.SetActive(false);
        gameManager.buttons.transform.GetChild(1).gameObject.SetActive(true);
        gameManager.buttons.transform.GetChild(2).gameObject.SetActive(false);
        gameManager.Set();
        gameManager.loading.SetActive(false);
    }
}
