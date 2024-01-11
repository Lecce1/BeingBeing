using UnityEngine;

public class DBManager : MonoBehaviour
{
    public bool isFirst;
    public bool isStageFirst;
    public int level;
    public int currentStep = 1;
    public string currentStage;
    public int musicValue;
    public int vibrateValue;
    public int soundValue;
    public string refresh_PrevStage;
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
    }
}
