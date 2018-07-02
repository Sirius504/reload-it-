using System;
using UnityEngine;

namespace ReloadIt
{
    public class Player : PlaceableBehavior
    {
        public Weapon weapon;

        public Bullet Shoot(Vector3 target)
        {
            transform.LookAt(target, Vector3.up);
            return weapon.Shoot(target);
        }

        private void OnTriggerEnter(Collider other)
        {
            Debug.Log("Collision appeared");
            IPlayerInteractable otherObject = other.gameObject.GetComponent<IPlayerInteractable>();
            if (otherObject != null)
                otherObject.OnPlayerCollided(this);
        }
    }
}