using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Decent_Sentence : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    private Vector2 mousePosition;
    private Vector2 begin;
    private bool isTrue;
    public bool isTouch;
    private float yPos;
    private List<RaycastResult> results = new List<RaycastResult>();
    private Decent_Manager decent_Manager;

    void Awake()
    {
        decent_Manager = GameObject.Find("DecentManager").GetComponent<Decent_Manager>();
    }
    
    void Start()
    {
        if (!decent_Manager.isTutorial)
        {
            if (transform.GetChild(0).GetComponent<Text>().text == "우리 할머니의 머리는 점점 백발이 되고 있다." ||
                transform.GetChild(0).GetComponent<Text>().text == "오늘 아침에 내 짝이 나를 보고 미소를 지었다." ||
                transform.GetChild(0).GetComponent<Text>().text == "나는 생각하고 느끼는 존재이다.")
            {
                isTrue = true;
            }
            else
            {
                isTrue = false;
            }
        }
        else if (decent_Manager.isTutorial)
        {
            if (transform.GetChild(0).GetComponent<Text>().text == "저 애가 나를 쳐다보고 있어." ||
                transform.GetChild(0).GetComponent<Text>().text == "지금 엄마가 생각나." ||
                transform.GetChild(0).GetComponent<Text>().text == "반 친구들이 여기를 보고 있네."||
                transform.GetChild(0).GetComponent<Text>().text == "나는 현재 긴장된 상태야." ||
                transform.GetChild(0).GetComponent<Text>().text == "지금 어떻게 해야할지 고민이야."||
                transform.GetChild(0).GetComponent<Text>().text == "친구들이 가만히 있기만 하네." ||
                transform.GetChild(0).GetComponent<Text>().text == "손에 힘이 들어가고 있어."||
                transform.GetChild(0).GetComponent<Text>().text == "목이 마르고 열이 나네." ||
                transform.GetChild(0).GetComponent<Text>().text == "우리 할머니의 머리는 점점 백발이 되고 있다.")
            {
                isTrue = true;
            }
            else
            {
                isTrue = false;
            }
        }
        
        yPos = transform.GetComponent<RectTransform>().anchoredPosition.y;
    }

    void Update()
    {
        yPos -= (100f * Time.deltaTime);
        
        if (!isTouch)
        {
            transform.GetComponent<RectTransform>().anchoredPosition = new Vector2(transform.GetComponent<RectTransform>().anchoredPosition.x, transform.GetComponent<RectTransform>().anchoredPosition.y - (100f * Time.deltaTime));
        }
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        isTouch = true;
        begin = eventData.position;
    }

    public void OnEndDrag(PointerEventData eventData) 
    {
        EventSystem.current.RaycastAll(eventData, results);

        for (int i = 0; i < results.Count; i++)
        {
            if (results[i].gameObject.name == "True" && isTrue == true)
            {
                Debug.Log("정답");
                Destroy(gameObject);
            }
            else if (results[i].gameObject.name == "Interpret" && isTrue == false)
            {
                Debug.Log("정답");
                Destroy(gameObject);
            }
            else
            {
                isTouch = false;
                transform.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, yPos);
            }
        }
    }

    public void OnDrag(PointerEventData eventData)
    {
        mousePosition = eventData.position - begin;
        begin = eventData.position;
        transform.GetComponent<RectTransform>().anchoredPosition += mousePosition;
    }
    
    void OnTriggerStay2D(Collider2D other)
    {
        if (!isTouch && other.name == "True")
        {
            if (!decent_Manager.isTutorial)
            {
                decent_Manager.sentence_Text.Add(transform.GetChild(0).GetComponent<Text>().text);
                Destroy(gameObject);
            }
            else
            {
                decent_Manager.shadow.SetActive(true);
                decent_Manager.fail.SetActive(true);
                Time.timeScale = 0;
            }
        }
    }
}
