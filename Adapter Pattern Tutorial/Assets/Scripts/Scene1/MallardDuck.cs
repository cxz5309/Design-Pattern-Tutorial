using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MallardDuck : Duck
{
    public void quack()
    {
        Debug.Log("오리 : 꽥꽥");
    }

    public void fly()
    {
        Debug.Log("오리 : 날기");
    }
}