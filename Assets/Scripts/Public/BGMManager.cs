using UnityEngine;

public class BGMManager : MonoBehaviour
{
    [System.Serializable]
    public struct BgmType
    {
        public string name;
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
                bgmAudioSource.clip = BGMList[i].audio;
                bgmAudioSource.Play();
            }
        }
    }

    public void StopBGM()
    {
        bgmAudioSource.Stop();
        voiceAudioSource.Stop();
    }
}