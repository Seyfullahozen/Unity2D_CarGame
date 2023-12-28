using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npcHuman : MonoBehaviour
{
    private float default_walk;
    private int go_sidewalk;
    public int human_sprite;
    public Sprite human1, human2, human3;

    Rigidbody2D rb;
    SpriteRenderer spr;
    void Start()
    {
        spr = GetComponent<SpriteRenderer>();
        rb = GetComponent<Rigidbody2D>();

        go_sidewalk = Random.Range(1, 3); //rastgele kaldýrým
        default_walk = Random.Range(0.5f, 1.5f); //rastgele hýz
        human_sprite = Random.Range(1, 4); //rastgele insan

        if (go_sidewalk == 1)
        {
            transform.position = new Vector3(-8f, transform.position.y + 15, 0);
        }
        else
        {
            transform.position = new Vector3(10f, transform.position.y + 15, 0);
        }

        switch (human_sprite)
        {
            case 1:
                spr.sprite = human1;
                break;

            case 2:
                spr.sprite = human2;
                break;

            case 3:
                spr.sprite = human3;
                break;
        }
    }
    void FixedUpdate()
    {
        rb.velocity = new Vector3(rb.velocity.x, default_walk * 50 * Time.deltaTime, 0);
    }
}
