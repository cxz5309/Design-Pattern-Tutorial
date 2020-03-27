using System.Collections;
using UnityEngine;

public class PointManager : MonoBehaviour
{
    static PointManager _instance = null;
    public static PointManager Instance()
    {
        return _instance;
    }

    //변수
    int myPoint = 0;


    private void Awake()
    {
        if(_instance == null)
        {
            _instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            if(this != _instance)
            {
                Destroy(this.gameObject);
            }
        }
    }

    public void AddPoint(int num)
    {
        myPoint += num;
    }

    public int GetPoint()
    {
        return myPoint;
    }
}
