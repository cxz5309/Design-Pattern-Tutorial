using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProtossFactory : RaceFactory
{
    public GameObject pylon;
    public GameObject gateway;

    public override GameObject makeCapacityBuilding()
    {
        return Instantiate(pylon);
    }

    public override GameObject makeUnitBuilding()
    {
        return Instantiate(gateway);
    }
}
