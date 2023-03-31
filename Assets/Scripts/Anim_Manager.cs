using UnityEngine;

public class Anim_Manager : MonoBehaviour
{
    Animator logo_Animator;
    Animator fade_Animator;
    Animator smile_BackGlow_Animator;
    Animator emotionRecog_Dot_Animator;
    Animator emotionRecog_Fade_Animator;
    GameManager gameManager;
    Breath_Manager breath_Manager;
    Smile_Manager smile_Manager;
    BodyRecog_Manager bodyRecog_Manager;
    EmotionRecog_Manager emotionRecog_Manager;

    void Awake()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    public void Logo()
    {
        logo_Animator = GameObject.Find("Logo").GetComponent<Animator>();
        logo_Animator.Play("Logo");
    }
    
    void Logo_Finish()
    {
        gameManager.logo.SetActive(false);
        gameManager.lobby.SetActive(true);
        gameManager.buttons.SetActive(true);
        gameManager.GetComponent<AudioSource>().Play();
    }

    public void Dot()
    {
        emotionRecog_Manager = GameObject.Find("EmotionRecog_Manager").GetComponent<EmotionRecog_Manager>();
        
        if (emotionRecog_Manager.isTutorial == false)
        {
            emotionRecog_Manager.tutorial_EmotionDot.SetActive(true);
            emotionRecog_Dot_Animator = emotionRecog_Manager.tutorial_EmotionDot.GetComponent<Animator>();
            emotionRecog_Dot_Animator.Play("Dot");
        }
        else if (emotionRecog_Manager.isTutorial == true)
        {
            emotionRecog_Manager.emotionDot.SetActive(true);
            emotionRecog_Dot_Animator = emotionRecog_Manager.emotionDot.GetComponent<Animator>();
            emotionRecog_Dot_Animator.Play("Dot");
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

    public void Fade_Out()
    {
        gameManager.fade.SetActive(true);
        fade_Animator = GameObject.Find("Fade").GetComponent<Animator>();
        fade_Animator.Play("Fade_Out");
    }

    void Fade_Out_Finish()
    {
        if (gameManager.lobby.activeSelf == true)
        {
            gameManager.lobby.SetActive(false);
            gameManager.level.SetActive(true);
        }
        else if (gameManager.level.activeSelf == true)
        {
            gameManager.level.SetActive(false);

            if (gameManager.level_Stage_Num == 1)
            {
                    
            }
            else if (gameManager.level_Stage_Num == 2)
            {
                gameManager.smile.SetActive(true);
            }
            else if (gameManager.level_Stage_Num == 3)
            {
                gameManager.bodyRecog.SetActive(true);
            }
            else if (gameManager.level_Stage_Num == 4)
            {
                gameManager.emotionRecog.SetActive(true);
            }
        }
        else if (gameManager.smile.activeSelf == true)
        {
            smile_Manager = GameObject.Find("Smile").transform.GetChild(0).GetComponent<Smile_Manager>();
            smile_Manager.Reset();
            gameManager.level.SetActive(true);
            gameManager.smile.SetActive(false);
        }
        else if (gameManager.bodyRecog.activeSelf == true)
        {
            bodyRecog_Manager = GameObject.Find("BodyRecog").transform.GetChild(0).GetComponent<BodyRecog_Manager>();
            
            if (bodyRecog_Manager.isNext == false)
            {
                bodyRecog_Manager.Reset();
                gameManager.level.SetActive(true);
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
            emotionRecog_Manager.Reset();
            gameManager.level.SetActive(true);
            gameManager.emotionRecog.SetActive(false);
        }
            
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
