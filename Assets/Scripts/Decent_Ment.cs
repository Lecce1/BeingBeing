using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Decent_Ment : MonoBehaviour
{
    private bool isTouch = false;
    Decent_Manager decent_Manager;
    AnimManager animManager;
    WaitForSeconds waitForSeconds = new WaitForSeconds(0.01f);

    void Awake()
    {
        decent_Manager = GameObject.Find("Decent_Manager").GetComponent<Decent_Manager>();
    }
    
    void Update()
    {
        if (isTouch == false)
        {
            transform.GetComponent<RectTransform>().anchoredPosition = new Vector2(transform.GetComponent<RectTransform>().anchoredPosition.x, transform.GetComponent<RectTransform>().anchoredPosition.y - (200f * Time.deltaTime));
        }
        else if (isTouch == true)
        {
            transform.GetComponent<RectTransform>().anchoredPosition = Vector2.MoveTowards(transform.GetComponent<RectTransform>().anchoredPosition, new Vector2(0, -1600), 1000 * Time.deltaTime);

            if (transform.GetComponent<RectTransform>().anchoredPosition.y == -1600)
            {
                Destroy(gameObject);
            }
        }
    }

    public void Touch()
    {
        transform.GetComponent<Button>().enabled = false;
        isTouch = true;
        StartCoroutine("Touch2");
    }
    
    IEnumerator Touch2()
    {
        float fill = decent_Manager.stage6_Bar.GetComponent<Slider>().value;

        if (fill + 0.143f <= 1)
        {
            while (decent_Manager.stage6_Bar.GetComponent<Slider>().value < fill + 0.143f)
            {
                decent_Manager.stage6_Bar.GetComponent<Slider>().value += 0.01f;
                yield return waitForSeconds;
            }
        }
        else if (fill + 0.143f > 1)
        {
            while (decent_Manager.stage6_Bar.GetComponent<Slider>().value < 1)
            {
                decent_Manager.stage6_Bar.GetComponent<Slider>().value += 0.01f;
                yield return waitForSeconds;
            }

            decent_Manager.Check();
        }
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (isTouch == false && other.name == "Line")
        {
            decent_Manager.stage6_Text.Add(transform.GetChild(0).GetComponent<Text>().text);
            Destroy(gameObject);
        }
    }
}
