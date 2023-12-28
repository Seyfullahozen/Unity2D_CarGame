using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayRace : MonoBehaviour
{
    public void playMultiPlayer()
    {
        SceneManager.LoadScene(4);
        Time.timeScale = 1f;
    }
}
