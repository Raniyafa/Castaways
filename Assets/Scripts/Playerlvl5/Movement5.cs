using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement5 : MonoBehaviour
{
    public float speed = 5;
    public Rigidbody rb;
    float horizontalInput;

    public float jumpForce = 400f;
    public LayerMask groundMask;

    private void FixedUpdate()
    {
        Vector3 forwardMove = transform.forward * speed * Time.fixedDeltaTime;
        Vector3 horizontalMove = transform.right * horizontalInput * speed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + forwardMove + horizontalMove);
    }
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }

        void Jump()
        {
            float height = GetComponent<Collider>().bounds.size.y;
            bool isGrounded = Physics.Raycast(transform.position, Vector3.down, (height / 2) + 0.1f, groundMask);

            rb.AddForce(Vector3.up * jumpForce);
        }

    }
}
