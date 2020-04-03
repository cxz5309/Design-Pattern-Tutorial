using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{
    private void Start()
    {
        IUnitAction act = gameObject.GetComponent<UnitAction>();
        act.NormalMove(this.transform);
    }
}
