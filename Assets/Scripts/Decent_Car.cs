using UnityEngine;
using UnityEngine.EventSystems;

public class Decent_Car : MonoBehaviour, IBeginDragHandler, IDragHandler
{
    private Vector2 mousePosition;
    private Vector2 begin;

    void Update()
    {
        if (transform.GetComponent<RectTransform>().anchoredPosition.x < -460)
        {
            transform.GetComponent<RectTransform>().anchoredPosition =
                new Vector2(-460, transform.GetComponent<RectTransform>().anchoredPosition.y);
        }
        else if (transform.GetComponent<RectTransform>().anchoredPosition.x > 460)
        {
            transform.GetComponent<RectTransform>().anchoredPosition =
                new Vector2(460, transform.GetComponent<RectTransform>().anchoredPosition.y);
        }
        
        if (transform.GetComponent<RectTransform>().anchoredPosition.y < 0)
        {
            transform.GetComponent<RectTransform>().anchoredPosition =
                new Vector2(transform.GetComponent<RectTransform>().anchoredPosition.x, 0);
        }
        else if (transform.GetComponent<RectTransform>().anchoredPosition.y > 250)
        {
            transform.GetComponent<RectTransform>().anchoredPosition =
                new Vector2(transform.GetComponent<RectTransform>().anchoredPosition.x, 250);
        }
    }
    
    public void OnBeginDrag(PointerEventData eventData)
    {
        begin = eventData.position;
    }
    
    public void OnDrag(PointerEventData eventData)
    {
        mousePosition = eventData.position - begin;
        begin = eventData.position;
        transform.GetComponent<RectTransform>().anchoredPosition += mousePosition;
    }
}
