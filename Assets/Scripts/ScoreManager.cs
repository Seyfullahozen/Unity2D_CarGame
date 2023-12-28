using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text score_txt;
    public static float score;
    void Start()
    {
        score = 0;
    }

    void Update()
    {
        score_txt.text = score.ToString();
    }
}
