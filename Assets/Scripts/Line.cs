using UnityEngine;

public class Line : MonoBehaviour
{
    BodyRecog_Manager bodyRecog_Manager;
    GameManager gameManager;
    
    private void OnTriggerExit2D(Collider2D other)
    {
        bodyRecog_Manager = GameObject.Find("BodyRecog_Manager").GetComponent<BodyRecog_Manager>();
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        
        if (bodyRecog_Manager.isTutorial == false)
        {
            if (other.gameObject.name == "Head")
            {
                bodyRecog_Manager.GetComponent<AudioSource>().Play();
                bodyRecog_Manager.isStop = true;
                bodyRecog_Manager.Point();
            }
        }
        else if (bodyRecog_Manager.isTutorial == true)
        {
            if (gameManager.stage_Select_Level_Num == 1)
            {
                if (other.gameObject.name == "Head" || other.gameObject.name == "Shoulder" || other.gameObject.name == "Chest" || other.gameObject.name == "Stomach" || other.gameObject.name == "Knee" || other.gameObject.name == "Foot")
                {
                    bodyRecog_Manager.GetComponent<AudioSource>().Play();
                    bodyRecog_Manager.isStop = true;
                    bodyRecog_Manager.Point();
                }
                else if (other.gameObject.name == "Finish")
                {
                    bodyRecog_Manager.isStop = true;
                    bodyRecog_Manager.result.gameObject.SetActive(true);
                    bodyRecog_Manager.shadow.SetActive(true);
                    bodyRecog_Manager.success.SetActive(true);
                }
            }
            else if (gameManager.stage_Select_Level_Num == 2)
            {
                if (other.gameObject.name == "Head" || other.gameObject.name == "Eye" || other.gameObject.name == "Nose" || other.gameObject.name == "Mouse" || other.gameObject.name == "Neck" || other.gameObject.name == "Hand" || other.gameObject.name == "Hip" || other.gameObject.name == "Thigh" || other.gameObject.name == "Foot")
                {
                    bodyRecog_Manager.GetComponent<AudioSource>().Play();
                    bodyRecog_Manager.isStop = true;
                    bodyRecog_Manager.Point();
                }
                else if (other.gameObject.name == "Finish")
                {
                    bodyRecog_Manager.isStop = true;
                    bodyRecog_Manager.result.gameObject.SetActive(true);
                    bodyRecog_Manager.shadow.SetActive(true);
                    bodyRecog_Manager.success.SetActive(true);
                }
            }
            else if (gameManager.stage_Select_Level_Num == 3)
            {
                if (other.gameObject.name == "Head" || other.gameObject.name == "Eye" || other.gameObject.name == "Nose" || other.gameObject.name == "Mouse" || other.gameObject.name == "Neck" || other.gameObject.name == "Shoulder" || other.gameObject.name == "Chest" || other.gameObject.name == "Stomach" || other.gameObject.name == "Hand" || other.gameObject.name == "Hip" || other.gameObject.name == "Thigh" || other.gameObject.name == "Knee" || other.gameObject.name == "Foot")
                {
                    bodyRecog_Manager.GetComponent<AudioSource>().Play();
                    bodyRecog_Manager.isStop = true;
                    bodyRecog_Manager.Point();
                }
                else if (other.gameObject.name == "Finish")
                {
                    bodyRecog_Manager.isStop = true;
                    bodyRecog_Manager.result.gameObject.SetActive(true);
                    bodyRecog_Manager.shadow.SetActive(true);
                    bodyRecog_Manager.success.SetActive(true);
                }
            }

        }
    }
}
