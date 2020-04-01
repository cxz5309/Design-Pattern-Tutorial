using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Race
{
    Terran,
    Protoss, 
    Zerg
}

public abstract class RaceFactory : MonoBehaviour
{
    public abstract GameObject makeCapacityBuilding();
    public abstract GameObject makeUnitBuilding();
}
