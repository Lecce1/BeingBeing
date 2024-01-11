using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingManager : MonoBehaviour
{
    [SerializeField]
    private float minimumLoadTime = 3f;
    [SerializeField]
    private int currentProgress;

    public static LoadingManager instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    void Start()
    {
        StartCoroutine(LoadScene());
    }

    IEnumerator LoadScene()
    {
        BGMManager.instance.StopBGM();
        AsyncOperation operation = SceneManager.LoadSceneAsync(DBManager.instance.currentStage);
        operation.allowSceneActivation = false;
        float timer = 0.0f;
        float minimumTimer = minimumLoadTime;

        while (!operation.isDone)
        {
            yield return null;

            timer += Time.deltaTime;
            minimumTimer -= Time.deltaTime;

            if (operation.progress < 0.9f)
            {
                currentProgress = Mathf.FloorToInt(operation.progress * 100f);
            }
            else
            {
                if (currentProgress < 100)
                {
                    currentProgress = Mathf.FloorToInt(Mathf.Lerp(currentProgress, 100,
                        (minimumLoadTime - minimumTimer) / minimumLoadTime));

                    if (minimumTimer >= 0f && currentProgress >= 99)
                    {
                        continue;
                    }
                }

                if (minimumTimer >= 0f)
                    continue;

                if (!operation.allowSceneActivation)
                {
                    operation.allowSceneActivation = true;
                    yield break;
                }
            }
        }
    }
}
