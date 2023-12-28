using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myCar : MonoBehaviour
{
    public float vertical_speed, horizonal_speed, default_speed;
    private float vertical_movement, horizontal_movement;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); 
    }

    void FixedUpdate()
    {
        vertical_movement = Input.GetAxis("Vertical"); 
        horizontal_movement = Input.GetAxis("Horizontal");
        rb.velocity = new Vector3
        (horizontal_movement*50*horizonal_speed*Time.deltaTime, default_speed + vertical_movement * 100 * vertical_speed * Time.deltaTime);

        if(transform.position.x > 5f)
        {
            Vector3 right_limit = new Vector3(5f, transform.position.y);
            transform.position = right_limit;
        } 

        if (transform.position.x < -4.9f)
        {
            Vector3 left_limit = new Vector3(-4.9f, transform.position.y);
            transform.position = left_limit;
        } 
    }
}
