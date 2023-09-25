using UnityEngine;
using UnityEngine.UI;

public class Line : MonoBehaviour
{
    BodyRecog_Manager bodyRecog_Manager;
    GameManager gameManager;
    GameObject results;
    
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
                if (other.gameObject.name == "Head" || other.gameObject.name == "Shoulder" ||
                    other.gameObject.name == "Chest" || other.gameObject.name == "Stomach" ||
                    other.gameObject.name == "Knee" || other.gameObject.name == "Foot")
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
                    bodyRecog_Manager.success.SetActive(true);
                    bodyRecog_Manager.success2.SetActive(true);
                    bodyRecog_Manager.line.SetActive(false);
                    Result();
                }
            }
            else if (gameManager.stage_Select_Level_Num == 2)
            {
                if (other.gameObject.name == "Head" || other.gameObject.name == "Eye" ||
                    other.gameObject.name == "Nose" || other.gameObject.name == "Mouse" ||
                    other.gameObject.name == "Neck" || other.gameObject.name == "Hand" ||
                    other.gameObject.name == "Hip" || other.gameObject.name == "Thigh" ||
                    other.gameObject.name == "Foot")
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
                    bodyRecog_Manager.success.SetActive(true);
                    bodyRecog_Manager.success2.SetActive(true);
                    bodyRecog_Manager.line.SetActive(false);
                    Result();
                }
            }
            else if (gameManager.stage_Select_Level_Num == 3)
            {
                if (other.gameObject.name == "Head" || other.gameObject.name == "Eye" ||
                    other.gameObject.name == "Nose" || other.gameObject.name == "Mouse" ||
                    other.gameObject.name == "Neck" || other.gameObject.name == "Shoulder" ||
                    other.gameObject.name == "Chest" || other.gameObject.name == "Stomach" ||
                    other.gameObject.name == "Hand" || other.gameObject.name == "Hip" ||
                    other.gameObject.name == "Thigh" || other.gameObject.name == "Knee" ||
                    other.gameObject.name == "Foot")
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
                    bodyRecog_Manager.success.SetActive(true);
                    bodyRecog_Manager.success2.SetActive(true);
                    bodyRecog_Manager.line.SetActive(false);
                    Result();
                }
            }
        }
    }

    private void Result()
    {
        bodyRecog_Manager.success_Results_Step1.gameObject.SetActive(false);
        bodyRecog_Manager.success_Results_Step2.gameObject.SetActive(false);
        bodyRecog_Manager.success_Results_Step3.gameObject.SetActive(false);
        string[] temp = bodyRecog_Manager.result.Split(',');

        if (gameManager.stage_Select_Level_Num == 1)
        {
            bodyRecog_Manager.success_Results_Step1.gameObject.SetActive(true);
            results = bodyRecog_Manager.success_Results_Step1;
        }
        else if(gameManager.stage_Select_Level_Num == 2)
        {
            bodyRecog_Manager.success_Results_Step2.gameObject.SetActive(true);
            results = bodyRecog_Manager.success_Results_Step2;
        }
        else if(gameManager.stage_Select_Level_Num == 3)
        {
            bodyRecog_Manager.success_Results_Step3.gameObject.SetActive(true);
            results = bodyRecog_Manager.success_Results_Step3;
        }
        
        int count = 0;

        for (int i = 0; i < temp.Length; i += 3)
        {
            if (temp[i + 1] == "편하다")
            {
                int num = int.Parse(temp[i + 2]);

                switch (num)
                {
                    case 1:
                        results.transform.GetChild(count).GetComponent<Image>().sprite = bodyRecog_Manager.results_Sprite[0];
                        
                        if (results.transform.GetChild(count).childCount >= 1)
                        {
                            results.transform.GetChild(count).GetChild(0).GetComponent<Image>().sprite = bodyRecog_Manager.results_Sprite[0];
                        }
                        break;
                    case 2:
                        results.transform.GetChild(count).GetComponent<Image>().sprite = bodyRecog_Manager.results_Sprite[1];
                        
                        if (results.transform.GetChild(count).childCount >= 1)
                        {
                            results.transform.GetChild(count).GetChild(0).GetComponent<Image>().sprite = bodyRecog_Manager.results_Sprite[1];
                        }
                        break;
                    case 3:
                        results.transform.GetChild(count).GetComponent<Image>().sprite = bodyRecog_Manager.results_Sprite[2];
                        
                        if (results.transform.GetChild(count).childCount >= 1)
                        {
                            results.transform.GetChild(count).GetChild(0).GetComponent<Image>().sprite = bodyRecog_Manager.results_Sprite[2];
                        }
                        break;
                    case 4:
                        results.transform.GetChild(count).GetComponent<Image>().sprite = bodyRecog_Manager.results_Sprite[3];
                        
                        if (results.transform.GetChild(count).childCount >= 1)
                        {
                            results.transform.GetChild(count).GetChild(0).GetComponent<Image>().sprite = bodyRecog_Manager.results_Sprite[3];
                        }
                        break;
                    case 5:
                        results.transform.GetChild(count).GetComponent<Image>().sprite = bodyRecog_Manager.results_Sprite[4];
                        
                        if (results.transform.GetChild(count).childCount >= 1)
                        {
                            results.transform.GetChild(count).GetChild(0).GetComponent<Image>().sprite = bodyRecog_Manager.results_Sprite[4];
                        }
                        break;
                }
            }
            else if (temp[i + 1] == "불편하다")
            {
                int num = int.Parse(temp[i + 2]);

                switch (num)
                {
                    case 1:
                        results.transform.GetChild(count).GetComponent<Image>().sprite = bodyRecog_Manager.results_Sprite[5];
                        
                        if (results.transform.GetChild(count).childCount >= 1)
                        {
                            results.transform.GetChild(count).GetChild(0).GetComponent<Image>().sprite = bodyRecog_Manager.results_Sprite[5];
                        }
                        break;
                    case 2:
                        results.transform.GetChild(count).GetComponent<Image>().sprite = bodyRecog_Manager.results_Sprite[6];
                        
                        if (results.transform.GetChild(count).childCount >= 1)
                        {
                            results.transform.GetChild(count).GetChild(0).GetComponent<Image>().sprite = bodyRecog_Manager.results_Sprite[6];
                        }
                        break;
                    case 3:
                        results.transform.GetChild(count).GetComponent<Image>().sprite = bodyRecog_Manager.results_Sprite[7];
                        
                        if (results.transform.GetChild(count).childCount >= 1)
                        {
                            results.transform.GetChild(count).GetChild(0).GetComponent<Image>().sprite = bodyRecog_Manager.results_Sprite[7];
                        }
                        break;
                    case 4:
                        results.transform.GetChild(count).GetComponent<Image>().sprite = bodyRecog_Manager.results_Sprite[8];
                        
                        if (results.transform.GetChild(count).childCount >= 1)
                        {
                            results.transform.GetChild(count).GetChild(0).GetComponent<Image>().sprite = bodyRecog_Manager.results_Sprite[8];
                        }
                        break;
                    case 5:
                        results.transform.GetChild(count).GetComponent<Image>().sprite = bodyRecog_Manager.results_Sprite[9];
                        
                        if (results.transform.GetChild(count).childCount >= 1)
                        {
                            results.transform.GetChild(count).GetChild(0).GetComponent<Image>().sprite = bodyRecog_Manager.results_Sprite[9];
                        }
                        break;
                }
            }

            count++;
        }
    }
}
