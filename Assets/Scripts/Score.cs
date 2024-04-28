using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static Score Instance;
    
    public Text ScoreText;
    public int ScoreCount;

    private void Awake()
    {
        Instance = this;
    }

    public void AddScore()
    {
        ScoreCount++;
        ScoreText.text = ScoreCount.ToString();
    }
}
