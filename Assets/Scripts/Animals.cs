using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animals : MonoBehaviour
{
    private int dir = 0;

    void Start()
    {
        Reset();
    }

    void Update()
    {
        Move();
    }

    void Reset()
    {
        dir = Random.Range(0, 2);

        if (dir == 0)
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }
        else if (dir == 1)
        {
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }
    }

    void Move()
    {
        if (dir == 0)
        {
            gameObject.transform.Translate(0.002f, 0, 0);
        }
        else if (dir == 1)
        {
            gameObject.transform.Translate(-0.002f, 0, 0);
        }

        if (gameObject.GetComponent<RectTransform>().anchoredPosition.x > 7)
        {
            dir = 1;
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }
        else if (gameObject.GetComponent<RectTransform>().anchoredPosition.x < -7)
        {
            dir = 0;
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }
    }
}
