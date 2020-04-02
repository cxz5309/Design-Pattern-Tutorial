using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Observer1 : MonoBehaviour
{
    public abstract void OnNotify(float time);
}