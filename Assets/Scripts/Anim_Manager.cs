using UnityEngine;
using UnityEngine.SceneManagement;

public class Anim_Manager : MonoBehaviour
{
    Animator logo_Animator;
    Animator main_Fade_Animator;
    Animator breath_Fade_Animator;
    Animator smile_Fade_Animator;
    Animator smile_BackGlow_Animator;
    Animator recognition_EmotionColor_Animator;
    Animator recognition_Dot_Animator;
    Animator recognition_Fade_Animator;
    GameManager gameManager;
    Breath_Manager breath_Manager;
    Smile_Manager smile_Manager;
    Recognition_Manager recognition_Manager;

    public void Logo()
    {
        logo_Animator = GameObject.Find("Logo").GetComponent<Animator>();
        logo_Animator.Play("Logo");
    }
    
    void Logo_Finish()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        gameManager.logo.SetActive(false);
        gameManager.lobby.SetActive(true);
        gameManager.GetComponent<AudioSource>().Play();
    }

    public void EmotionColor()
    {
        recognition_Manager = GameObject.Find("Recognition_Manager").GetComponent<Recognition_Manager>();
        recognition_EmotionColor_Animator = recognition_Manager.emotionColor.GetComponent<Animator>();
        recognition_EmotionColor_Animator.enabled = true;
        recognition_EmotionColor_Animator.Play("EmotionColor");
    }
    
    void EmotionColor_Finish()
    {
        recognition_Manager = GameObject.Find("Recognition_Manager").GetComponent<Recognition_Manager>();
        recognition_Manager.emotionDot.SetActive(true);
        recognition_EmotionColor_Animator = recognition_Manager.emotionColor.GetComponent<Animator>();
        recognition_EmotionColor_Animator.enabled = false;
        Dot();
    }

    void Dot()
    {
        recognition_Manager = GameObject.Find("Recognition_Manager").GetComponent<Recognition_Manager>();
        recognition_Dot_Animator = recognition_Manager.emotionDot.GetComponent<Animator>();
        recognition_Dot_Animator.Play("Dot");
    }
    
    public void BackGlow()
    {
        smile_Manager = GameObject.Find("Smile_Manager").GetComponent<Smile_Manager>();
        smile_Manager.backGlow.SetActive(true);
        smile_BackGlow_Animator = smile_Manager.backGlow.GetComponent<Animator>();
        smile_BackGlow_Animator.Play("BackGlow");
    }
    
    void BackGlow_Finish()
    {
        smile_Manager = GameObject.Find("Smile_Manager").GetComponent<Smile_Manager>();
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
            Fade_Out();
        }

    }

    public void Fade_Out()
    {
        if (SceneManager.GetActiveScene().name == "Main")
        {
            gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
            gameManager.fade.gameObject.SetActive(true);
            main_Fade_Animator = GameObject.Find("Fade").GetComponent<Animator>();
            main_Fade_Animator.Play("Fade_Out");
        }
        else if (SceneManager.GetActiveScene().name == "Breath")
        {
            breath_Manager = GameObject.Find("Breath_Manager").GetComponent<Breath_Manager>();
            breath_Manager.fade.SetActive(true);
            breath_Fade_Animator = GameObject.Find("Fade").GetComponent<Animator>();
            breath_Fade_Animator.Play("Fade_Out");
        }
        else if (SceneManager.GetActiveScene().name == "Smile")
        {
            smile_Manager = GameObject.Find("Smile_Manager").GetComponent<Smile_Manager>();
            smile_Manager.fade.SetActive(true);
            smile_Fade_Animator = GameObject.Find("Fade").GetComponent<Animator>();
            smile_Fade_Animator.Play("Fade_Out");
        }
        else if (SceneManager.GetActiveScene().name == "Recognition")
        {
            recognition_Manager = GameObject.Find("Recognition_Manager").GetComponent<Recognition_Manager>();
            recognition_Manager.fade.SetActive(true);
            recognition_Fade_Animator = GameObject.Find("Fade").GetComponent<Animator>();
            recognition_Fade_Animator.Play("Fade_Out");
        }
    }

    void Fade_Out_Finish()
    {
        if (SceneManager.GetActiveScene().name == "Main")
        {
            gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();

            if (gameManager.lobby.activeSelf == true)
            {
                gameManager.lobby.SetActive(false);
                gameManager.level.SetActive(true);
            }
            else if (gameManager.level.activeSelf == true)
            {
                gameManager.lobby.SetActive(true);
                gameManager.level.SetActive(false);
            }
            
            Fade_In();
        }
    }
    
    public void Fade_In()
    {
        if (SceneManager.GetActiveScene().name == "Main")
        {
            main_Fade_Animator = GameObject.Find("Fade").GetComponent<Animator>();
            main_Fade_Animator.Play("Fade_In");
        }
        else if (SceneManager.GetActiveScene().name == "Breath")
        {
            breath_Manager = GameObject.Find("Breath_Manager").GetComponent<Breath_Manager>();
            breath_Manager.fade.SetActive(true);
            breath_Fade_Animator = GameObject.Find("Fade").GetComponent<Animator>();
            breath_Fade_Animator.Play("Fade_In");
        }
        else if (SceneManager.GetActiveScene().name == "Smile")
        {
            smile_Manager = GameObject.Find("Smile_Manager").GetComponent<Smile_Manager>();
            smile_Manager.fade.SetActive(true);
            smile_Fade_Animator = GameObject.Find("Fade").GetComponent<Animator>();
            smile_Fade_Animator.Play("Fade_In");
        }
        else if (SceneManager.GetActiveScene().name == "Recognition")
        {
            recognition_Manager = GameObject.Find("Recognition_Manager").GetComponent<Recognition_Manager>();
            recognition_Manager.fade.SetActive(true);
            recognition_Fade_Animator = GameObject.Find("Fade").GetComponent<Animator>();
            recognition_Fade_Animator.Play("Fade_In");
        }
    }

    void Fade_In_Finish()
    {
        if (SceneManager.GetActiveScene().name == "Main")
        {
            gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
            gameManager.fade.gameObject.SetActive(false);
        }
        else if (SceneManager.GetActiveScene().name == "Breath")
        {
            breath_Manager = GameObject.Find("Breath_Manager").GetComponent<Breath_Manager>();
            breath_Manager.fade.SetActive(false);
        }
        else if (SceneManager.GetActiveScene().name == "Smile")
        {
            smile_Manager = GameObject.Find("Smile_Manager").GetComponent<Smile_Manager>();
            smile_Manager.fade.SetActive(false);
        }
        else if (SceneManager.GetActiveScene().name == "Recognition")
        {
            recognition_Manager = GameObject.Find("Recognition_Manager").GetComponent<Recognition_Manager>();
            recognition_Manager.fade.SetActive(false);
        }
    }
}
