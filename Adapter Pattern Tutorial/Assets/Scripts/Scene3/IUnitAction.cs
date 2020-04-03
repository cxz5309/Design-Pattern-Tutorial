using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IUnitAction
{
    void NormalMove(Transform tr);
    void NormalStop(Transform tr);
}