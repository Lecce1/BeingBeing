using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Heart : MonoBehaviour
{
    Lovely_Manager lovely_Manager;
    WaitForSeconds waitForSeconds = new WaitForSeconds(0.01f);

    void Awake()
    {
        lovely_Manager = GameObject.Find("Lovely_Manager").GetComponent<Lovely_Manager>();
    }

    public void Touch()
    {
        lovely_Manager.heartNum++;
        StartCoroutine("Touch2");
    }
    
    IEnumerator Touch2()
    {
        while (lovely_Manager.bar.GetComponent<Image>().fillAmount < lovely_Manager.heartNum * 0.03f)
        {
            lovely_Manager.bar.GetComponent<Image>().fillAmount += 0.01f;
            yield return waitForSeconds;
        }
    }
    
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.name == "Character")
        {
            Destroy(gameObject);
        }
    }
}
