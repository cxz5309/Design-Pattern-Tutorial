using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConcreteStateAttack : State
{
    public override void DoAction(MyState state)
    {
        Debug.Log("Down Attack");
        StartCoroutine(HandleAttack(state));
    }

    IEnumerator HandleAttack(MyState state)
    {
        transform.position = new Vector3(0, 0.2f, 0);
        yield return new WaitForSeconds(0.2f);

        transform.position = new Vector3(0, 1.2f, 0);
        yield return new WaitForSeconds(0.2f);

        transform.position = new Vector3(0, 0.2f, 0);
        yield return new WaitForSeconds(0.2f);
        
        transform.position = new Vector3(0, 0.1f, 0);

        GetComponent<MyAction>().setActionType(MyState.STATE_STANDING);
        yield return null;
    }
}