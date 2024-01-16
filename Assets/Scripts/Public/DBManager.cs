using UnityEngine;

public class DBManager : MonoBehaviour
{
    public bool isFirst;
    public bool isStageFirst;
    public int level;
    public int currentStep;
    public string currentStage;
    public int musicValue;
    public int vibrateValue;
    public int soundValue;
    public string refresh_PrevStage;
    public bool recog_Step1_Clear;
    public bool recog_Step2_Clear;
    public bool recog_Step3_Clear;
    public int decent_Count;
    public bool decent_Again;
    public bool decent_Anger;
    public bool decent_Unrest;
    public bool decent_Sadness;
    public bool decent_Remorse;
    public bool decent_IsRefresh;
    public bool isLoaded;
    public static DBManager instance;

    void Awake()
    {
        Application.targetFrameRate = 120;
        
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(this);
        }
    }

    void Start()
    {
        Init();
    }
    
    void Init()
    {
        if (PlayerPrefs.GetInt("isFirst") == 0)
        {
            isFirst = false;
            PlayerPrefs.SetInt("Music", 1);
            PlayerPrefs.SetInt("Vibrate", 1);
            PlayerPrefs.SetInt("Sound", 1);
        }
        else
        {
            isFirst = true;
        }
        
        level = PlayerPrefs.GetInt("level");
        musicValue = PlayerPrefs.GetInt("Music");
        vibrateValue = PlayerPrefs.GetInt("Vibrate");
        soundValue = PlayerPrefs.GetInt("Sound");
        isLoaded = true;

        if (level <= 4)
        {
            currentStep = 1;
        }
        else if(level <= 8)
        {
            currentStep = 2;
        }       
        else if(level <= 12)
        {
            currentStep = 3;
        }

        if (PlayerPrefs.GetInt("Recog_Step1_Clear") == 0)
        {
            recog_Step1_Clear = false;
        }
        else
        {
            recog_Step1_Clear = true;
        }
        
        if (PlayerPrefs.GetInt("Recog_Step2_Clear") == 0)
        {
            recog_Step2_Clear = false;
        }
        else
        {
            recog_Step2_Clear = true;
        }
        
        if (PlayerPrefs.GetInt("Recog_Step3_Clear") == 0)
        {
            recog_Step3_Clear = false;
        }
        else
        {
            recog_Step3_Clear = true;
        }
    }

    public void Renewal()
    {        
        level = PlayerPrefs.GetInt("level");
        musicValue = PlayerPrefs.GetInt("Music");
        vibrateValue = PlayerPrefs.GetInt("Vibrate");
        soundValue = PlayerPrefs.GetInt("Sound");
        isLoaded = true;
        
        if (PlayerPrefs.GetInt("Recog_Step1_Clear") == 0)
        {
            recog_Step1_Clear = false;
        }
        else
        {
            recog_Step1_Clear = true;
        }
        
        if (PlayerPrefs.GetInt("Recog_Step2_Clear") == 0)
        {
            recog_Step2_Clear = false;
        }
        else
        {
            recog_Step2_Clear = true;
        }
        
        if (PlayerPrefs.GetInt("Recog_Step3_Clear") == 0)
        {
            recog_Step3_Clear = false;
        }
        else
        {
            recog_Step3_Clear = true;
        }
    }
}
