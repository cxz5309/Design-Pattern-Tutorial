using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class EventBoss : Boss
{
    private void Start()
    {
        type = BossType.EventBoss;
        hp = 200;
        exp = 20;

        name = "Event Boss";
        Debug.Log(this.name + " : 출현!!");
    }
    public override void Attack()
    {
        Debug.Log(this.name + " : 공격!!");
    }
}
