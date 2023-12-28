using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if (transform.position.x > 1.7f)
        {
            Vector3 right_limit = new Vector3(1.7f, transform.position.y);
            transform.position = right_limit;
        }

        if (transform.position.x < -1.65f)
        {
            Vector3 left_limit = new Vector3(-1.65f, transform.position.y);
            transform.position = left_limit;
        }
    }
}
