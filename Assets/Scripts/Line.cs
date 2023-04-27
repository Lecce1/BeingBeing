using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line : MonoBehaviour
{
    BodyRecog_Manager bodyRecog_Manager;
    
    private void OnTriggerExit2D(Collider2D other)
    {
        bodyRecog_Manager = GameObject.Find("BodyRecog_Manager").GetComponent<BodyRecog_Manager>();
        
        if (bodyRecog_Manager.isTutorial == false)
        {
            if (other.gameObject.name == "1")
            {
                bodyRecog_Manager.GetComponent<AudioSource>().Play();
                bodyRecog_Manager.isStop = true;
                bodyRecog_Manager.Point();
            }
        }
        else if (bodyRecog_Manager.isTutorial == true)
        {
            if (bodyRecog_Manager.pointNum == 1 && other.gameObject.name == "1")
            {
                bodyRecog_Manager.GetComponent<AudioSource>().Play();
                bodyRecog_Manager.isStop = true;
                bodyRecog_Manager.Point();
            }
            else if (bodyRecog_Manager.pointNum == 2 && other.gameObject.name == "2")
            {
                bodyRecog_Manager.GetComponent<AudioSource>().Play();
                bodyRecog_Manager.isStop = true;
                bodyRecog_Manager.Point();
            }
            else if (bodyRecog_Manager.pointNum == 3 && other.gameObject.name == "3")
            {
                bodyRecog_Manager.GetComponent<AudioSource>().Play();
                bodyRecog_Manager.isStop = true;
                bodyRecog_Manager.Point();
            }
            else if (bodyRecog_Manager.pointNum == 4 && other.gameObject.name == "4")
            {
                bodyRecog_Manager.GetComponent<AudioSource>().Play();
                bodyRecog_Manager.isStop = true;
                bodyRecog_Manager.Point();
            }
            else if (bodyRecog_Manager.pointNum == 5 && other.gameObject.name == "5")
            {
                bodyRecog_Manager.GetComponent<AudioSource>().Play();
                bodyRecog_Manager.isStop = true;
                bodyRecog_Manager.Point();
            }
            else if (bodyRecog_Manager.pointNum == 6 && other.gameObject.name == "6")
            {
                bodyRecog_Manager.points.transform.GetChild(7).gameObject.SetActive(false);
                bodyRecog_Manager.isStop = true;
                bodyRecog_Manager.result.gameObject.SetActive(true);
                bodyRecog_Manager.shadow.SetActive(true);
                bodyRecog_Manager.success.SetActive(true);
            }
        }
    }
}
