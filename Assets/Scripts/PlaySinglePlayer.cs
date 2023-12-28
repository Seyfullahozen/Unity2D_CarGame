using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Play : MonoBehaviour
{
    public void playSinglePlayer()
    {
        SceneManager.LoadScene(2);
        Time.timeScale = 1f;
    }
}
