using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    private void Start()
    {
        IUnitAction act = gameObject.GetComponent<Adapter>();
        act.NormalMove(this.transform);
    }
}
