using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using TMPro;

public class Scoredisplay : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private TMP_Text timerText;

    void Update()
    {
        if (ScoreManager.Instance == null) return;

        float score = ScoreManager.Instance.currScore;

        timerText.text = $"{score}";
    }

}
