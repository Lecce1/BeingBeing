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
                    switch (other.gameObject.name)
                    {
                        case "Head":
                            bodyRecog_Manager.notice.text = "머리";
                            break;
                        case "Shoulder":
                            bodyRecog_Manager.notice.text = "어깨";
                            break;
                        case "Chest":
                            bodyRecog_Manager.notice.text = "가슴";
                            break;
                        case "Stomach":
                            bodyRecog_Manager.notice.text = "배";
                            break;
                        case "Knee":
                            bodyRecog_Manager.notice.text = "무릎";
                            break;
                        case "Foot":
                            bodyRecog_Manager.notice.text = "발";
                            break;
                    }
                    
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
                    switch (other.gameObject.name)
                    {
                        case "Head":
                            bodyRecog_Manager.notice.text = "머리";
                            break;
                        case "Eye":
                            bodyRecog_Manager.notice.text = "눈";
                            break;
                        case "Nose":
                            bodyRecog_Manager.notice.text = "코";
                            break;
                        case "Mouse":
                            bodyRecog_Manager.notice.text = "입";
                            break;
                        case "Neck":
                            bodyRecog_Manager.notice.text = "목";
                            break;
                        case "Hand":
                            bodyRecog_Manager.notice.text = "손";
                            break;
                        case "Hip":
                            bodyRecog_Manager.notice.text = "엉덩이";
                            break;
                        case "Thigh":
                            bodyRecog_Manager.notice.text = "허벅지";
                            break;
                        case "Foot":
                            bodyRecog_Manager.notice.text = "발";
                            break;
                    }
                    
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
                    switch (other.gameObject.name)
                    {
                        case "Head":
                            bodyRecog_Manager.notice.text = "머리";
                            break;
                        case "Eye":
                            bodyRecog_Manager.notice.text = "눈";
                            break;
                        case "Nose":
                            bodyRecog_Manager.notice.text = "코";
                            break;
                        case "Mouse":
                            bodyRecog_Manager.notice.text = "입";
                            break;
                        case "Neck":
                            bodyRecog_Manager.notice.text = "목";
                            break;
                        case "Shoulder":
                            bodyRecog_Manager.notice.text = "어깨";
                            break;
                        case "Chest":
                            bodyRecog_Manager.notice.text = "가슴";
                            break;
                        case "Stomach":
                            bodyRecog_Manager.notice.text = "배";
                            break;
                        case "Hand":
                            bodyRecog_Manager.notice.text = "손";
                            break;
                        case "Hip":
                            bodyRecog_Manager.notice.text = "엉덩이";
                            break;
                        case "Thigh":
                            bodyRecog_Manager.notice.text = "허벅지";
                            break;
                        case "Knee":
                            bodyRecog_Manager.notice.text = "무릎";
                            break;
                        case "Foot":
                            bodyRecog_Manager.notice.text = "발";
                            break;
                    }
                    
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
