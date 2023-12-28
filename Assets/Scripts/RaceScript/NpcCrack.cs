using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NpcCrack : MonoBehaviour
{
    public Sprite crack;

    Rigidbody2D rb;
    SpriteRenderer spr;
    void Start()
    {
        spr = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();

        spr.sprite = crack;

        float randomX = Random.Range(-1.65f, 1.7f);

        transform.position = new Vector3(randomX, transform.position.y + 10, 0);
    }

    void FixedUpdate()
    {
        rb.velocity = new Vector3(rb.velocity.x, 2f, 0);
    }

    void OnCollisionEnter2D(Collision2D temas)
    {
        if (temas.gameObject.tag == "Car1")
        {
            transform.position = new Vector3(0, transform.position.y - 5, 0);
        }
        else if(temas.gameObject.tag == "Car2")
        {
            transform.position = new Vector3(0, transform.position.y - 5, 0);
        }
    }
}
