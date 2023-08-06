using UnityEngine;
using UnityEngine.Serialization;

public class BGMManager : MonoBehaviour
{
    [System.Serializable]
    public struct BgmType
    {
        public string name;
        public AudioClip audio; 
    }

    // Inspector 에표시할 배경음악 목록
    public BgmType[] BGMList;
    public AudioSource bgmAudioSource;
    public AudioSource voiceAudioSource;

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