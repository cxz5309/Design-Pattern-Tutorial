using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Adapter : MonoBehaviour, INewAction, IUnitAction
{
    public GameObject shield;

    public void EventMove(Transform tr)
    {
        StartCoroutine(CoEventMove(1f, tr));
    }

    IEnumerator CoEventMove(float tm, Transform tr)
    {
        shield.SetActive(true);

        tr.Translate(Vector3.forward * 1f);
        Debug.Log("이벤트 이동");
        yield return new WaitForSeconds(tm);

        tr.Translate(Vector3.forward * 1f);
        Debug.Log("이벤트 이동");
        yield return new WaitForSeconds(tm);

        shield.SetActive(false);
    }

    public void EventStop(Transform tr)
    {
        Debug.Log("이벤트 정지");
    }

    public void NormalMove(Transform tr)
    {
        EventMove(tr);
    }

    public void NormalStop(Transform tr)
    {
        EventStop(tr);
    }
}