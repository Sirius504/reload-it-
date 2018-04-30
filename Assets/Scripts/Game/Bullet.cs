using UnityEngine;

namespace ReloadIt
{
    public class Bullet : PlaceableBehavior
    {
        [SerializeField]
        private float speed;

        private new Rigidbody rigidbody;

        private void OnEnable()
        {
            rigidbody = GetComponent<Rigidbody>();
            rigidbody.velocity = transform.forward * speed;
        }

        private void OnCollisionEnter(Collision collision)
        {
            PutToPool();
        }
    }
}