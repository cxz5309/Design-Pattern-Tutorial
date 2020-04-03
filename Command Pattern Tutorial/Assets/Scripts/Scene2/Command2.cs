using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class CommandKey2
{
    public virtual void Execute(GameObject obj) { }
}

public class CommandAttack2 : CommandKey2
{
    public override void Execute(GameObject obj)
    {
        Attack(obj);
    }

    void Attack(GameObject obj)
    {
        Debug.Log(obj.name + " Attack");
        obj.transform.Translate(Vector3.forward);
    }
}

public class CommandDefense2 : CommandKey2
{
    public override void Execute(GameObject obj)
    {
        Defense(obj);
    }
    void Defense(GameObject obj)
    {
        Debug.Log(obj.name + " Defense");
        obj.transform.Translate(Vector3.back);
    }
}