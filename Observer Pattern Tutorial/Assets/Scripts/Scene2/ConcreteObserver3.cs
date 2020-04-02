using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConcreteObserver3 : Observer1
{
    float accTime = 0f;
    float limitTime = 0f;
    bool bRotate = false;

    public override void OnNotify(float time)
    {
        accTime = 0f;
        limitTime = time;
        bRotate = true;
    }
    
    void Update()
    {
        if(accTime > limitTime)
        {
            bRotate = false;
        }

        if (bRotate)
        {
            accTime += Time.deltaTime;

            transform.Rotate(100f * Time.deltaTime * Vector3.up);
        }
    }
}