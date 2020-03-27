using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum WeaponType
{
    Bullet, Missile, Arrow
}

public class WeaponManager : MonoBehaviour
{
    public GameObject arrow;
    public GameObject bullet;
    public GameObject missile;
    private GameObject myWeapon;

    private IWeapon weapon;

    public void SetWeaponType(WeaponType weaponType) {
        Component c = gameObject.GetComponent<IWeapon>() as Component;

        if (c != null)
        {
            Destroy(c);
        }
        switch (weaponType)
        {
            case WeaponType.Bullet:
                weapon = gameObject.AddComponent<Bullet>();
                myWeapon = bullet;
                break;
            case WeaponType.Missile:
                weapon = gameObject.AddComponent<Missile>();
                myWeapon = missile;
                break;
            case WeaponType.Arrow:
                weapon = gameObject.AddComponent<Arrow>();
                myWeapon = arrow;
                break;
            default:
                weapon = gameObject.AddComponent<Bullet>();
                myWeapon = bullet;
                break;
        }
    }

    private void Start()
    {
        SetWeaponType(WeaponType.Bullet);
    }

    public void ChangeBullet()
    {
        SetWeaponType(WeaponType.Bullet);
    }
    public void ChangeMissile()
    {
        SetWeaponType(WeaponType.Missile);
    }
    public void ChangeArrow()
    {
        SetWeaponType(WeaponType.Arrow);
    }
    public void Fire()
    {
        weapon.Shoot(myWeapon);
    }
}
