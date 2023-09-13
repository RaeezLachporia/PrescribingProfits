using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    float xInput;
    float yInput;
    public Transform orientation;
    Vector3 direction;
    public Rigidbody rb;

    private void Start()
    {
        rb.GetComponent<Rigidbody>();
        rb.freezeRotation = true;
    }

    private void Update()
    {
        GetInput();
    }

    private void FixeUpdate()
    {
        Move();
    }

    private void GetInput()
    {
        xInput = Input.GetAxisRaw("Horizontal");
        yInput = Input.GetAxisRaw("Vertical");
    }

    private void Move()
    {
        direction = orientation.forward * yInput + orientation.right * xInput;
        rb.AddForce(direction.normalized * speed * 10f, ForceMode.Force);
    }    
}
