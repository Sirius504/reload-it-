using System;
using UnityEngine;
namespace ReloadIt
{
    public class Weapon : MonoBehaviour
    {
        [SerializeField]
        private GameObject bulletPrefab;

        [SerializeField]
        private Transform bulletStartPoint;

        public Bullet Shoot(Vector3 target)
        {
            transform.LookAt(target);
            Bullet bullet = Bullet.GetFromPool<Bullet>(null, bulletStartPoint.position, bulletStartPoint.rotation);
            return bullet;
        }
    }
}