using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Smile : MonoBehaviour
{
    public GameObject finger;
    public GameObject body;
    private bool isUp = false;
    private bool isDown = false;
    WaitForEndOfFrame waitForEndOfFrame = new WaitForEndOfFrame();

    void Update()
    {
        Cursor();
    }

    void Cursor()
    {
        finger.transform.position = Input.mousePosition;

        if (Input.GetMouseButton(0))
        {
            finger.GetComponent<Image>().sprite = Resources.Load<Sprite>("Finger2");
        }
        else
        {
            finger.GetComponent<Image>().sprite = Resources.Load<Sprite>("Finger");
        }

        if (gameObject.GetComponent<Touch>().result == Result.up)
        {
            isUp = true;
            gameObject.GetComponent<Touch>().result = Result.none;
        }
        else if (gameObject.GetComponent<Touch>().result == Result.down)
        {
            isDown = true;
            gameObject.GetComponent<Touch>().result = Result.none;
        }
    }
}
