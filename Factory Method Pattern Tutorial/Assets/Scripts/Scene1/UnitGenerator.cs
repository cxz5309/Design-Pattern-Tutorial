using System.Collections;
using System.Collections.Generic;
using UnityEngine;

abstract class UnitGenerator
{
    public List<Unit> units = new List<Unit>();

    public List<Unit> getUnits()
    {
        return units;
    }

    public abstract void CreateUnits();
}
