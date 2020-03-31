using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UseFactoryMethod3 : MonoBehaviour
{
    BossGenerator factory = null;
    public Text desc;

    private void Start()
    {
        factory = GetComponent<BossGenerator>();

        if(factory.type == BossType.NormalBoss)
        {
            desc.text = "Normal Boss";
        }
        else if(factory.type == BossType.EventBoss)
        {
            desc.text = "Event Boss";
        }

        Transform tran = this.gameObject.transform;

        factory.CreateBoss(tran);
    }
}
