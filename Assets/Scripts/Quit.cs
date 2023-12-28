using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Quite : MonoBehaviour
{
    public void quiteGame()
    {
        SceneManager.LoadScene(0);
    }
}