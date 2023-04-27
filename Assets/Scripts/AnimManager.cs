using UnityEngine;

public class AnimManager : MonoBehaviour
{
    Animator splash_Animator;
    Animator fade_Animator;
    Animator smile_BackGlow_Animator;
    Animator refresh_BackGlow_Animator;
    Animator emotionRecog_Dot_Animator;
    Animator emotionRecog_Fade_Animator;
    GameManager gameManager;
    Breath_Manager breath_Manager;
    Smile_Manager smile_Manager;
    BodyRecog_Manager bodyRecog_Manager;
    EmotionRecog_Manager emotionRecog_Manager;
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
        smile_Manager = GameObject.Find("Smile_Manager").GetComponent<Smile_Manager>();

        if (smile_Manager.isTutorial == false)
        {
            smile_Manager.tutorial_BackGlow.SetActive(false);
            smile_Manager.isTutorial = true;
        }
        else if (smile_Manager.isTutorial == true)
        {
            smile_Manager.backGlow.SetActive(false);
            
            if (smile_Manager.num != 3)
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
        gameManager.fade.SetActive(true);
        fade_Animator = GameObject.Find("Fade").GetComponent<Animator>();
        fade_Animator.Play("Fade_Out");
    }

    void Fade_Out_Finish()
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
                gameManager.emotionRecog.SetActive(false);
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
        Fade_In();
    }
    
    void Fade_In()
    {
        fade_Animator = GameObject.Find("Fade").GetComponent<Animator>();
        fade_Animator.Play("Fade_In");
    }

    void Fade_In_Finish()
    {
        gameManager.fade.gameObject.SetActive(false);
    }
}
