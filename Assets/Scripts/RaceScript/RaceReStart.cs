using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RaceReStart : MonoBehaviour
{
    public void restartGame()
    {
        SceneManager.LoadScene(4);
        Time.timeScale = 1f;
    }
}
