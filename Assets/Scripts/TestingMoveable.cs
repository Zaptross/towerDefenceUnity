using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestingMoveable : MonoBehaviour
{
    public float moveSpeed = 1.0f;
    public Vector2 turnSpeed = Vector2.one;
    public float jumpPower = 10.0f;
    public Vector3 footPosition = new Vector3(0f, -0.5f, 0f);
    public GameObject camera3p;

    private Rigidbody rigidBody;

    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        Walking();
        Jumping();
        Turning();
    }

    private void Turning()
    {
        float x = Input.GetAxis("Mouse X");

        transform.Rotate(Vector3.up, turnSpeed.x * x * Time.deltaTime);
    }

    private void Jumping()
    {
        bool isOnGround = Physics.Raycast(transform.position + footPosition, Vector3.down, 1.0f) || Mathf.Abs(rigidBody.velocity.y) < 0.005f;
        bool isSpacePressed = Input.GetKeyDown(KeyCode.Space);

        // If the debug character is "on" the gound
        Debug.DrawLine(
            transform.position + footPosition,
            transform.position + footPosition + Vector3.down,
            isOnGround
                ? isSpacePressed
                    ? Color.yellow
                    : Color.green
                : Color.red
        );

        if (isOnGround && isSpacePressed)
        {
            rigidBody.AddForce(Vector3.up * jumpPower);
        }
    }

    private void Walking()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rigidBody.AddForce(transform.forward * moveSpeed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rigidBody.AddForce(-transform.forward * moveSpeed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rigidBody.AddForce(-transform.right * moveSpeed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rigidBody.AddForce(transform.right * moveSpeed);
        }
    }
}
