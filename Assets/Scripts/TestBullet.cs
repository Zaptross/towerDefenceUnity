using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestBullet : MonoBehaviour
{
    public float bulletSpeed = 10.0f;
    public float maxDistance = 300.0f;
    public Vector3 inertia = Vector3.zero;
    private Rigidbody rigidBody;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if ((GameManager.instance.transform.position - transform.position).magnitude > maxDistance)
        {
            Die();
        }
        else
        {
            rigidBody.velocity = Vector3.Lerp(rigidBody.velocity, transform.forward * bulletSpeed + inertia, 0.5f);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        rigidBody.velocity = rigidBody.velocity.magnitude * Vector3.up;
    }

    private void Die()
    {
        Destroy(this);
    }
}
