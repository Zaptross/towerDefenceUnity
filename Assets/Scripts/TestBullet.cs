using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestBullet : MonoBehaviour
{
    public float bulletSpeed = 10.0f;
    public float maxDistance = 300.0f;
    public Vector3 inertia = Vector3.zero;
    private Rigidbody rb;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if ((GameManager.instance.transform.position - transform.position).magnitude > maxDistance) {
            Die();
        } else {
            rb.velocity = transform.forward * bulletSpeed + inertia;
        }
    }

    private void OnCollisionEnter(Collision other) {
        Die();
    }

    private void Die() {
        Destroy(this);
    }
}
