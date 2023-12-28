using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanSpawner : MonoBehaviour
{
    public GameObject random_human_npc;
    bool human_spawn = true;
    void Start()
    {
        StartCoroutine(bekle2());
    }
    IEnumerator bekle2()
    {
        while (human_spawn == true)
        {
            Instantiate(random_human_npc, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(2f);
        }
    }
}
