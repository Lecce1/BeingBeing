using UnityEngine;

public class BGMManager : MonoBehaviour
{
    [System.Serializable]
    public struct BgmType
    {
        public string name;
        public string type;
        public AudioClip audio; 
    }
    
    public BgmType[] BGMList;
    public AudioSource bgmAudioSource;
    public AudioSource voiceAudioSource;
    public static BGMManager instance;

    void Start()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(this);
        }
    }

    public void PlayBGM(string name)
    {
        for (int i = 0; i < BGMList.Length; ++i)
        {
            if (BGMList[i].name.Equals(name))
            {
                switch (BGMList[i].type)
                {
                    case "BGM":
                        bgmAudioSource.clip = BGMList[i].audio;
                        bgmAudioSource.Play();
                        break;
                    
                    case "Voice":
                        voiceAudioSource.clip = BGMList[i].audio;
                        voiceAudioSource.Play();
                        break;
                }
            }
        }
    }

    public void StopBGM()
    {
        bgmAudioSource.Stop();
        voiceAudioSource.Stop();
    }
}