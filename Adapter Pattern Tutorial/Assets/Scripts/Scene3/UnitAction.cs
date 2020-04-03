using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UnitAction : MonoBehaviour, IUnitAction
{
    public void NormalMove(Transform tr)
    {
        tr.Translate(Vector3.forward * 1f);
        Debug.Log("노멀 이동");
    }

    public void NormalStop(Transform tr)
    {
        Debug.Log("노멀 정지");
    }
}