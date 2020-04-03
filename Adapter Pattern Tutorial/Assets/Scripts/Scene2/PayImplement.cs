using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PayImplement : PayX, PayY
{
    private string customerCardNum;

    public string getCustomerCardNum()
    {

        Debug.Log("PayY(Get)");
        return customerCardNum;
    }

    public void serCustormerCardNum(string customerCardNum)
    {

        Debug.Log("PayY(Set)");
        this.customerCardNum = customerCardNum;
    }

    public string getCreditCardNum()
    {
        return getCustomerCardNum();
    }

    public void setCreditCardNum(string creditCardNum)
    {
        serCustormerCardNum(creditCardNum);
    }
}