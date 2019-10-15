using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    Rigidbody rb;

    public float speed;

    public float jump;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(Time.deltaTime * speed * Vector3.forward);
        }
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Time.deltaTime * speed * Vector3.left);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Time.deltaTime * speed * Vector3.right);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(Time.deltaTime * speed * Vector3.back);
        }
        if (Input.GetKey(KeyCode.Space) && 
            Physics.Raycast(transform.position, Vector3.down, 0.55f))
        {
            rb.AddForce(jump * Vector3.up);
        }
    }
}