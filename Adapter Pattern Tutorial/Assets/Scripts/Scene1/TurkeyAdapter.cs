using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurkeyAdapter : Duck
{
    Turkey turkey;

    public TurkeyAdapter(Turkey turkey)
    {
        this.turkey = turkey;
    }
    public void quack()
    {
        turkey.gobble();
    }
    public void fly()
    {
        turkey.fly();
    }
}