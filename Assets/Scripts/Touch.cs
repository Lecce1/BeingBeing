using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Result
{
    leftup = 0,
    up,
    rightup,
    right,
    rightdown,
    down,
    leftdown,
    left,
    triangle1,
    triangle2,
    Circle,
    Square,
    Z,
    none
}

public class Touch : MonoBehaviour
{
    enum Direction
    {
        leftup = 1,
        up,
        rightup,
        right,
        rightdown,
        down,
        leftdown,
        left
    }

    public Result result = Result.none;
    float[] degree = new float[50];          // 각도
    int[] vals = new int[250];               // 방향
    int index = 0;                          // 변곡점 갯수
    Direction direction = 0;
    Vector2 StartPosition;
    Vector2 LastPosition;
    Vector2 position;
    public Camera MainCamera;

    void Start()
    {
        Reset();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            StartPosition = position;
        }
        if (Input.GetMouseButton(0))
        {
            if (!(Input.mousePosition.x - position.x > -25 && Input.mousePosition.x - position.x < 25) || !(Input.mousePosition.y - position.y > -25 && Input.mousePosition.y - position.y < 25)) // 사용자의 미세함 떨림으로 인한 오차 범위 ㅇㅇ
            {
                DegreeCheck();
                position = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            }
        }
        if (Input.GetMouseButtonUp(0))
        {
            LastPosition = new Vector2(Input.mousePosition.x, Input.mousePosition.y);
            GestureRecognize();
            Reset();
        }
    }

    void Reset()
    {
        direction = 0;
        index = 0;
    }

    void DegreeCheck()
    {
        Vector2 v = new Vector2(Input.mousePosition.x, Input.mousePosition.y) - position;
        float Atan2s = Mathf.Atan2(v.y, v.x) * Mathf.Rad2Deg + 180;

        if (Atan2s <= 315 - 22.5f && Atan2s > 270 - 22.5f)
        {
            direction = Direction.leftup;
        }
        else if (Atan2s <= 270 - 22.5f && Atan2s > 225 - 22.5f)
        {
            direction = Direction.up;
        }
        else if (Atan2s <= 225 - 22.5f && Atan2s > 180 - 22.5f)
        {
            direction = Direction.rightup;
        }
        else if (Atan2s < 180 - 22.5f && Atan2s > 135 - 22.5f)
        {
            direction = Direction.right;
        }
        else if (Atan2s <= 135 - 22.5f && Atan2s > 90 - 22.5f)
        {
            direction = Direction.rightdown;
        }
        else if (Atan2s <= 90 - 22.5f && Atan2s > 45 - 22.5f)
        {
            direction = Direction.down;
        }
        else if ((Atan2s >= 0 && Atan2s <= 22.5f) || (Atan2s > 337.5f && Atan2s < 360))
        {
            direction = Direction.leftdown;
        }
        else if (Atan2s <= 337.5f && Atan2s > 315 - 22.5f)
        {
            direction = Direction.left;
        }

        if (vals[index] != (int)direction)
        {
            if (direction != 0)
            {
                index++;
                vals[index] = (int)direction;
                degree[index] = Atan2s;
            }
        }
    }

    void StraightLine_Check()
    {
        if (index == 2)
        {
            if (vals[0] - vals[1] == 1 || vals[0] - vals[1] == -1)
            {
                if (degree[0] - degree[1] > -30)
                {
                    index = 1;
                }
                else if (degree[0] - degree[1] < 30)
                {
                    index = 1;
                }
            }
        }

        if (index == 1)
        {
            switch (vals[1])
            {
                case 1:
                    Debug.Log("위로 긋는선");
                    result = Result.up;
                    break;
                case 2:
                    Debug.Log("오른쪽 위로 긋는 대각선");
                    result = Result.rightup;
                    break;
                case 3:
                    Debug.Log("오른쪽으로 긋는선");
                    result = Result.right;
                    break;
                case 4:
                    Debug.Log("오른쪽 아래로 긋는 대각선");
                    result = Result.rightdown;
                    break;
                case 5:
                    Debug.Log("아래로 긋는선");
                    result = Result.down;
                    break;
                case 6:
                    Debug.Log("왼쪽 아래로 긋는 대각선");
                    result = Result.leftdown;
                    break;
                case 7:
                    Debug.Log("왼쪽으로 긋는선");
                    result = Result.left;
                    break;
                case 8:
                    Debug.Log("왼쪽 위로 긋는 대각선");
                    result = Result.leftup;
                    break;
            }
        }
    }

    void Circle_Check()
    {
        if (index > 6 && index < 10)
        {
            if (vals[1] == 8) if (vals[2] == 1) if (vals[3] == 2) if (vals[4] == 3) if (vals[5] == 4) if (vals[6] == 5) if (vals[7] == 6)
                                    {
                                        Debug.Log("Circle");
                                        result = Result.Circle;
                                    }

            if (vals[1] == 7) if (vals[2] == 8) if (vals[3] == 1) if (vals[4] == 2) if (vals[5] == 3) if (vals[6] == 4) if (vals[7] == 5) if (vals[8] == 6)
                                        {
                                            Debug.Log("Circle");
                                            result = Result.Circle;
                                        }
        }
    }

    void Z_Check()
    {
        if (index < 5)
        {
            if (vals[1] == 3)
                if (vals[2] == 5 || vals[2] == 6)
                {
                    if (vals[3] == 6 || vals[3] == 5) if (vals[4] == 3) Debug.Log("Z"); result = Result.Z;
                    if (vals[3] == 3) Debug.Log("Z"); result = Result.Z;
                }
        }
    }

    void Triangle_Check()
    {
        if (index <= 5)
        {
            if (vals[1] == 6)
            {
                for (int i = 2; i <= index - 1; i++)
                    if (vals[i] == 3)
                    {
                        if (vals[index] == 8)
                        {
                            Debug.Log("삼각형");
                            result = Result.triangle1;
                        }
                    }
            }
            else if (vals[1] == 3)
            {
                for (int i = 2; i <= 4; i++)
                {
                    if (vals[i] == 6)
                    {
                        if (vals[index] == 8)
                        {
                            Debug.Log("역 삼각형 1");
                            result = Result.triangle2;
                        }
                        else if (vals[index] == 1)
                        {
                            Debug.Log("역 삼각형 1");
                            result = Result.triangle2;
                        }
                    }
                }
            }
            else if (vals[1] == 7)
            {
                for (int i = 2; i <= 4; i++)
                {
                    if (vals[i] == 4)
                    {
                        if (vals[index] == 2)
                        {
                            Debug.Log("역 삼각형 2");
                            result = Result.triangle2;
                        }
                        else if (vals[index] == 1)
                        {
                            Debug.Log("역 삼각형 2");
                            result = Result.triangle2;
                        }
                    }
                }
            }
        }
    }

    void GestureRecognize()
    {
        Triangle_Check();
        StraightLine_Check();
        Circle_Check();
        Z_Check();
    }
}