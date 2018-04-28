using System;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField]
    private GameObject bulletPrefab;

    [SerializeField]
    private Transform bulletStartPoint;

    public Bullet Shoot(Vector3 target)
    {
        transform.LookAt(target);
        return Instantiate(bulletPrefab, bulletStartPoint.position, bulletStartPoint.rotation, null).GetComponent<Bullet>();
    }
}