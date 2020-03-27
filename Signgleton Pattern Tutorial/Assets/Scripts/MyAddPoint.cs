using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyAddPoint : MonoBehaviour
{
    public int myNum = 0;

    private void Start()
    {
        MyFunc();
    }

    void MyFunc()
    {
        PointManager.Instance().AddPoint(myNum);
        int myResult = PointManager.Instance().GetPoint();
        Debug.Log("Point : " + myResult);
    }
}
