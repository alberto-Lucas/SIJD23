using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
using UnityEngine.UI;

public class CoinDisplay : MonoBehaviour
{
    public Text scoreCoin;
    private int score;
    public static CoinDisplay instance;

    void Start()
    {
        instance = this;
    }
    public void UpdateScore(int value)
    {
        score += value;
        scoreCoin.text = score.ToString();
    }
}
