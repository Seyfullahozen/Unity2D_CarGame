using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveWASD : MonoBehaviour
{
    public float speed;

    float movementX;
    float movementY;

    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        movementX = 0;
        movementY = 0;
    }

    void Update()
    {
        rb.velocity = new Vector3(movementX * speed * Time.deltaTime, movementY * speed * 12 * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.W))
        {
            movementY = 5;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            movementY = -5;
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            movementX = -5;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            movementX = 5;
        }
        
        if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.S))
        {
            movementY = 0;
        }

        if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D))
        {
            movementX = 0;
        }
    }
}
