using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField]
    private float speed;

    private Rigidbody rigidbody;

    private void OnEnable()
    {
        rigidbody = GetComponent<Rigidbody>();
        rigidbody.velocity = transform.forward * speed;
    }
}