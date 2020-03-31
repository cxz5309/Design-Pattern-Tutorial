using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class Marine : Unit
{
    public Marine()
    {
        type = UnitType.Firebat;
        name = "Marine";
        hp = 120;
        exp = 50;

        Debug.Log(this.name + " : 생성");
    }

    public override void Attack()
    {
        Debug.Log(this.name + " : 공격");
    }
}
