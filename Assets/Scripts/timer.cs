using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using TMPro;

public class timer : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] private TMP_Text timerText;

    void Update()
    {
        if (Timekeeper.Instance == null) return;

        float time = Timekeeper.Instance.remainingTime;

        int minutes = Mathf.FloorToInt(time / 60f);
        int seconds = Mathf.FloorToInt(time % 60f);

        timerText.text = $"{minutes:00}:{seconds:00}";
    }

}
