using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConcreteStateSkill : State
{
    public override void DoAction(MyState state)
    {
        Debug.Log("Forward Attack");
        StartCoroutine("HandleSkill");
    }
    IEnumerator HandleSkill()
    {
        transform.eulerAngles = new Vector3(0, 90, 0);
        transform.position = new Vector3(0, 1f, 0);

        transform.Translate(Vector3.forward * 3f);
        yield return new WaitForSeconds(0.2f);

        transform.Translate(Vector3.back * 1f);
        yield return new WaitForSeconds(0.2f);

        transform.Translate(Vector3.forward * 1f);
        yield return new WaitForSeconds(0.2f);

        transform.position = new Vector3(0, 1f, 0);
        GetComponent<MyAction>().setActionType(MyState.STATE_STANDING);
    }
}