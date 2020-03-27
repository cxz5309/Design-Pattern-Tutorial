using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour, IWeapon
{
    public void Shoot(GameObject obj)
    {
        GameObject bullet = Instantiate(obj) as GameObject;
        bullet.transform.parent = GameObject.Find("Cube").transform;
        bullet.transform.localPosition = Vector3.zero;
    }
}
