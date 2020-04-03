using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyPay : MonoBehaviour
{
    private void Start()
    {
        PayImplement myPay = new PayImplement();
        myPay.setCreditCardNum("12345");
        string myCardNum = myPay.getCreditCardNum();

        Debug.Log("PayY : " + myCardNum);
    }
}
