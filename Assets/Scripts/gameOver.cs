using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameOver : MonoBehaviour
{
    public Text lastScoreText;
    void Start()
    {
        float lastScore = PlayerPrefs.GetFloat("LastScore", 0f);

        // Skor deðerini ekrana yazdýr
        lastScoreText.text = "Skor: " + lastScore;
    }
}
