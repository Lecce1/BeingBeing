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

        if (decent_Manager.stage5_isTutorial == false)
        {
            if (decent_Manager.stage5_Tutorial_Bar.transform.GetComponent<Slider>().value == 1)
            {
                Destroy(gameObject);
            }
        }
        else if (decent_Manager.stage5_isTutorial == true)
        {
            if (decent_Manager.stage5_Bar.transform.GetComponent<Slider>().value == 1)
            {
                Destroy(gameObject);
            }
        }
    }

    IEnumerator Bar()
    {
        if (decent_Manager.stage5_isTutorial == false)
        {
            float fill = decent_Manager.stage5_Tutorial_Bar.transform.GetComponent<Slider>().value;

            if (fill + 0.2f <= 1)
            {
                while (decent_Manager.stage5_Tutorial_Bar.transform.GetComponent<Slider>().value < fill + 0.2f)
                {
                    decent_Manager.stage5_Tutorial_Bar.transform.GetComponent<Slider>().value += 0.01f;
                    yield return waitForSeconds;
                }
            }
            else if (fill + 0.2f > 1)
            {
                while (decent_Manager.stage5_Tutorial_Bar.transform.GetComponent<Slider>().value < 1)
                {
                    decent_Manager.stage5_Tutorial_Bar.transform.GetComponent<Slider>().value += 0.01f;
                    yield return waitForSeconds;
                }
            }
        
            Destroy(gameObject);
        }
        else if (decent_Manager.stage5_isTutorial == true)
        {
            float fill = decent_Manager.stage5_Bar.transform.GetComponent<Slider>().value;

            if (fill + 0.1f <= 1)
            {
                while (decent_Manager.stage5_Bar.transform.GetComponent<Slider>().value < fill + 0.1f)
                {
                    decent_Manager.stage5_Bar.transform.GetComponent<Slider>().value += 0.01f;
                    yield return waitForSeconds;
                }
            }
            else if (fill + 0.1f > 1)
            {
                while (decent_Manager.stage5_Bar.transform.GetComponent<Slider>().value < 1)
                {
                    decent_Manager.stage5_Bar.transform.GetComponent<Slider>().value += 0.01f;
                    yield return waitForSeconds;
                }
            }
        
            Destroy(gameObject);
        }
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.name == "Car")
        {
            StartCoroutine("Bar");
        }
    }
}
