using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wayScript : MonoBehaviour
{
    public GameObject way;
    bool way_design = false;

    void OnTriggerEnter2D(Collider2D temas)
    {
        if (temas.gameObject.tag == "myCar" && way_design == false)
        {
            Vector3 spawn_location = new Vector3(transform.position.x, transform.position.y + 10, 0);
            Instantiate(way, spawn_location, Quaternion.identity);
            way_design = true;
            ScoreManager.score += 10;
            PlayerPrefs.SetFloat("LastScore", ScoreManager.score);

            Destroy(this.gameObject,5f);
        }
    }
}
