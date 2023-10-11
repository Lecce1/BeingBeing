using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class Decent_Leaf : MonoBehaviour
{
    [SerializeField]
    private float speed;
    [SerializeField]
    private float length;
    [SerializeField] 
    private bool direction;

    private Rigidbody2D rigid;
    
    private bool isTouch = false;
    Decent_Manager decent_Manager;
    AnimManager animManager;
    WaitForSeconds waitForSeconds = new WaitForSeconds(0.01f);
    
    void Awake()
    {
        decent_Manager = GameObject.Find("Decent_Manager").GetComponent<Decent_Manager>();
    }

    private void Start()
    {
        rigid = transform.GetComponent<Rigidbody2D>();
        speed = 1f;
        length = Random.Range(0.5f, 1.5f);
        rigid.gravityScale = 2f;
        direction = Random.Range(0, 2) != 0;
    }

    void FixedUpdate()
    {
        if (isTouch == false)
        {
            float data = Mathf.Sin(Time.time * length) * speed;
            rigid.velocity = direction ? Vector3.right * data : Vector3.left * data;
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
        transform.GetComponentInParent<Button>().enabled = false;
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
    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (isTouch == false && other.name == "Line")
        {
            decent_Manager.stage6_Text.Add(transform.GetChild(0).GetComponent<Text>().text);
            Destroy(gameObject);
        }
    }
}