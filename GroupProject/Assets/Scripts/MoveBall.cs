using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBall : MonoBehaviour
{

    private Rigidbody rb;
    public int speed;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            rb.AddForce(Vector3.forward * speed);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.AddForce(Vector3.back * speed);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(Vector3.right * speed);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(Vector3.left * speed);
        }
    }
} 