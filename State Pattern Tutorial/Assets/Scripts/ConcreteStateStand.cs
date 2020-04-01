using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConcreteStateStand : State
{
    public override void DoAction(MyState state)
    {
        Debug.Log("Stand");
        StartCoroutine(HandleStand(state));
    }
    IEnumerator HandleStand(MyState state)
    {
        transform.eulerAngles = new Vector3(0, 90, 0);
        transform.position = new Vector3(0, 1f, 0);
        yield return null;
    }
}