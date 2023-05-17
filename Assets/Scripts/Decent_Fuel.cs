using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Decent_Fuel : MonoBehaviour
{
    Decent_Manager decent_Manager;
    WaitForSeconds waitForSeconds = new WaitForSeconds(0.01f);

    void Awake()
    {
        decent_Manager = GameObject.Find("Decent_Manager").GetComponent<Decent_Manager>();
    }
    
    void Update()
    {
        transform.GetComponent<RectTransform>().anchoredPosition = new Vector2(transform.GetComponent<RectTransform>().anchoredPosition.x, transform.GetComponent<RectTransform>().anchoredPosition.y - (700f * Time.deltaTime));

        if (decent_Manager.stage5_Bar.transform.GetChild(0).GetComponent<Image>().fillAmount == 1)
        {
            Destroy(gameObject);
        }
    }

    IEnumerator Bar()
    {
        float fill = decent_Manager.stage5_Bar.transform.GetChild(0).GetComponent<Image>().fillAmount;

        if (fill + 0.1f <= 1)
        {
            while (decent_Manager.stage5_Bar.transform.GetChild(0).GetComponent<Image>().fillAmount < fill + 0.1f)
            {
                decent_Manager.stage5_Bar.transform.GetChild(0).GetComponent<Image>().fillAmount += 0.01f;
                yield return waitForSeconds;
            }
        }
        else if (fill + 0.1f > 1)
        {
            while (decent_Manager.stage5_Bar.transform.GetChild(0).GetComponent<Image>().fillAmount < 1)
            {
                decent_Manager.stage5_Bar.transform.GetChild(0).GetComponent<Image>().fillAmount += 0.01f;
                yield return waitForSeconds;
            }
        }
        
        Destroy(gameObject);
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Car")
        {
            StartCoroutine("Bar");
        }
    }
}
