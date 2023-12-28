using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveArrows : MonoBehaviour
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
        
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            movementY = 5;
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            movementY = -5;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            movementX = -5;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            movementX = 5;
        }
        
        if(Input.GetKeyUp(KeyCode.UpArrow) ||  Input.GetKeyUp(KeyCode.DownArrow)) 
        { 
            movementY = 0; 
        }

        if (Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.RightArrow))
        {
            movementX = 0;
        }
    }
}
