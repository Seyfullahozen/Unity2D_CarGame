using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yonetici : MonoBehaviour
{
    public bool gameStopped = false;

    public void gameStop()
    {
        if (gameStopped == false)
        {
            Time.timeScale = 0f;
            gameStopped = true;
        }
    }
    public void gameResume()
    {
        if (gameStopped == true)
        {
            Time.timeScale = 1f;
            gameStopped = false;
        }
    }
}
