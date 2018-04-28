using System;
using UnityEngine;

public class Player : PlaceableBehavior
{
    public Weapon weapon;

    public Bullet Shoot(Vector3 target)
    {
        transform.LookAt(target, Vector3.up);
        return weapon.Shoot(target);
    }
}