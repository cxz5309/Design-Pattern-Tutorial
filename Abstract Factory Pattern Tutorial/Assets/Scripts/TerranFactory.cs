using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerranFactory : RaceFactory
{
    public GameObject supply;
    public GameObject barracks;

    public override GameObject makeCapacityBuilding()
    {
        return Instantiate(supply);
    }

    public override GameObject makeUnitBuilding()
    {
        return Instantiate(barracks);
    }
}
