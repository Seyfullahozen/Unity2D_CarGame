using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToHowMulti : MonoBehaviour
{
    public void GoHowToMulti()
    {
        SceneManager.LoadScene(5);
    }

    public void GoHowToSingle()
    {
        SceneManager.LoadScene(6);
    }
}
