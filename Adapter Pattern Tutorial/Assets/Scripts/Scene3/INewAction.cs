using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface INewAction
{
    void EventMove(Transform tr);
    void EventStop(Transform tr);
}