using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConcreteObserver1 : Observer
{
    GameObject obj;

    public ConcreteObserver1(GameObject obj)
    {
        this.obj = obj;
    }

    public override void OnNotify(int num)
    {
        int num2 = obj.gameObject.GetComponent<ConcreteSubject>().getNum();

        Debug.Log("옵저버 클래스의 메서드 실행 #1");
        Debug.Log("메서드의 파라미터 : " + num);
        Debug.Log("객체 변수를 통한 접근 : " + num2);

    }
}