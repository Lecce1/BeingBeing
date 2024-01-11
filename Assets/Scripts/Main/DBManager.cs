using UnityEngine;

public class DBManager : MonoBehaviour
{
    public bool isFirst;
    public int level;
    public int currentStep = 1;
    public string currentStage;
    public int musicValue;
    public int vibrateValue;
    public int soundValue;
    public string refresh_PrevStage;
    public bool isLoaded;
    public static DBManager instance;

    void Awake()
    {
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
            isFirst = true;
        }
        else
        {
            isFirst = false;
        }
        
        level = PlayerPrefs.GetInt("level");
        musicValue = PlayerPrefs.GetInt("Music");
        vibrateValue = PlayerPrefs.GetInt("Vibrate");
        soundValue = PlayerPrefs.GetInt("Sound");
    }
}
